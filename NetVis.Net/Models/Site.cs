﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetVis.Net.Models
{
    public class Site
    {
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Subnet> Subnets { get; set; }
    }
}