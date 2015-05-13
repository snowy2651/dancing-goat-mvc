﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

using CMS.Helpers;

namespace MvcDemo.Web.Infrastructure
{
    /// <summary>
    /// Provides localization for the data annotation attributes
    /// </summary>
    public class LocalizedModelMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        /// <summary>
        /// Gets the localized metadata for the specified property.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="containerType">The type of the container.</param>
        /// <param name="modelAccessor">The model accessor.</param>
        /// <param name="modelType">The type of the model.</param>
        /// <param name="propertyName">The name of the property.</param>
        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            var attributesList = attributes as IList<Attribute> ?? attributes.ToList();

            var metadata = base.CreateMetadata(attributesList, containerType, modelAccessor, modelType, propertyName);

            // Find and localize first DisplayAttribute
            var displayAttribute = attributesList.OfType<DisplayAttribute>().FirstOrDefault();
            if (displayAttribute != null)
            {
                LocalizeDisplayAttribute(metadata, displayAttribute);
            }

            // Find and localize first DisplayNameAttribute
            var displayNameAttribute = attributesList.OfType<DisplayNameAttribute>().FirstOrDefault();
            if (displayNameAttribute != null)
            {
                metadata.DisplayName = Localize(displayNameAttribute.DisplayName);
            }

            return metadata;
        }


        private void LocalizeDisplayAttribute(ModelMetadata metadata, DisplayAttribute attribute)
        {
            metadata.DisplayName = Localize(attribute.GetName());
            metadata.ShortDisplayName = Localize(attribute.GetShortName());
            metadata.Description = Localize(attribute.GetDescription());
            metadata.Watermark = Localize(attribute.GetPrompt());
        }


        private static string Localize(string expression)
        {
            if (expression == null)
            {
                return null;
            }

            return ResHelper.GetString(expression);
        }
    }
}