﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementSimulator
{
    public class Content : ContentStatusManager, IContentItem
    {
        public  int ID { get; set; }
        public  string Title { get; set; }
        public string Author { get; set; }
        public DateTime TimeCreation { get; set; }
        public ContentStatus Status { get; set; }
    }
}
