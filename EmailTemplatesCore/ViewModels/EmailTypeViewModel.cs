using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailTemplatesCore.ViewModels
{

    /// <summary>
    /// Each template must have a single type
    /// </summary>
    public class EmailTypeViewModel
    {
        public int Id { get; set; }

        [RegularExpression("^[-_,A-Za-z0-9]*$", ErrorMessage = "No Spaces or Special Characters Allowed for Key")]
        public string Key { get; set; }

        public string Name { get; set; }
    }


    /// <summary>
    /// Editing and viewing email templates
    /// </summary>
    public class EmailTemplateViewModel
    {
        public int Id { get; set; }
        public int typeId { get; set; }

        [AllowHtml]
        public string Template { get; set; }

        public string From { get; set; }
        public string Subject { get; set; }

        public DateTime? CreatedOn { get; set; }

        [RegularExpression("^[-_,A-Za-z0-9]*$", ErrorMessage = "No Spaces or Special Characters Allowed for Key")]
        public string Key { get; set; }

        public string Name { get; set; }
    }



    /// <summary>
    /// We are going to use this as a simple data template of what to inject into the email
    /// </summary>
    public class EmailDataViewModel
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }



    /// <summary>
    /// Allow us to view the messages sent
    /// </summary>
    public class EmailSendViewModel
    {
        public string SentTo { get; set; }
        public string SentFrom { get; set; }
        public DateTime? SentOn { get; set; }
        public DateTime? CreatedOn { get; set; }
    }

}