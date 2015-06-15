using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class DemoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Category { get; set; }
    }
}