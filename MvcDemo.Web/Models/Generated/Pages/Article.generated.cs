//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com. 
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;

using CMS;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Article.CLASS_NAME, typeof(Article))]

namespace CMS.DocumentEngine.Types 
{
    /// <summary>
    /// Sample item class.
    /// </summary>
    public partial class Article : TreeNode
    {
        #region "Constants"

        /// <summary>
        /// Class name of the item.
        /// </summary>
        public const string CLASS_NAME = "TestMvcDemo.Article";

        #endregion


        #region "Properties"

        /// <summary>
        /// ArticleID.
        /// </summary>
        [DatabaseField]
        public int ArticleID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("ArticleID"), 0);
            }
            set
            {
                SetValue("ArticleID", value);
            }
        }


        /// <summary>
        /// Title.
        /// </summary>
        [DatabaseField]
        public string ArticleTitle
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ArticleTitle"), "");
            }
            set
            {
                SetValue("ArticleTitle", value);
            }
        }


        /// <summary>
        /// Teaser.
        /// </summary>
        [DatabaseField]
        public Guid ArticleTeaser
        {
            get
            {
                return ValidationHelper.GetGuid(GetValue("ArticleTeaser"), Guid.Empty);
            }
            set
            {
                SetValue("ArticleTeaser", value);
            }
        }


        /// <summary>
        /// Summary.
        /// </summary>
        [DatabaseField]
        public string ArticleSummary
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ArticleSummary"), "");
            }
            set
            {
                SetValue("ArticleSummary", value);
            }
        }


        /// <summary>
        /// Text.
        /// </summary>
        [DatabaseField]
        public string ArticleText
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ArticleText"), "");
            }
            set
            {
                SetValue("ArticleText", value);
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Constructor.
        /// </summary>
        public Article()
            : base(CLASS_NAME)
        {
        }

        #endregion
    }
}
