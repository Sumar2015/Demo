﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Models;
using System.Web.WebPages.Html;


namespace Demo.Models
{
    public class DataViewModel
    {
        public DemoViewModel()
        {
            DateCreated = DateTime.Now;
        }

        
    
public  DateTime DateCreated { get; set; }}
}