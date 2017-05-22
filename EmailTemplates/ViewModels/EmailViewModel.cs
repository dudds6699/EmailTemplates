using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailTemplates.ViewModels
{
    public class EmailViewModel
    {
        public string Subject { get; set; }

        [AllowHtml]
        public string Body { get; set; }

        public int Id { get; set; }

        public int TypeId { get; set; }
    }
}