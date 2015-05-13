﻿using System.Collections.Generic;

using CMS.DocumentEngine.Types;

namespace MvcDemo.Web.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<Article> LatestArticles 
        {
            get;
            set;
        }


        public IEnumerable<Cafe> CompanyCafes
        {
            get;
            set;
        }
        

        public string OurStory
        {
            get;
            set;
        }
    }
}