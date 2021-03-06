// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailTemplatesCore.Models
{

    // EmailTemplate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class EmailTemplate
    {
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // Id (Primary key)

        [Required]
        [Display(Name = "Type ID")]
        public int TypeId { get; set; } // TypeId

        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Email from")]
        public string EmailFrom { get; set; } // EmailFrom (length: 150)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Subject")]
        public string Subject { get; set; } // Subject (length: 100)

        [Required]
        [Display(Name = "Template")]
        public string Template { get; set; } // Template

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } // CreatedBy (length: 50)

        [Display(Name = "Created on")]
        public System.DateTime? CreatedOn { get; set; } // CreatedOn

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Modified by")]
        public string ModifiedBy { get; set; } // ModifiedBy (length: 50)

        [Display(Name = "Modified on")]
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn

        // Reverse navigation

        /// <summary>
        /// Child EmailMessageToSends where [EmailMessageToSend].[TemplateId] point to this entity (EmailTemplate_Id_EmailMessageToSend_TemplateId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EmailMessageToSend> EmailMessageToSends { get; set; } // EmailMessageToSend.EmailTemplate_Id_EmailMessageToSend_TemplateId

        // Foreign keys

        /// <summary>
        /// Parent EmailTemplateType pointed by [EmailTemplate].([TypeId]) (EmailTemplateType_ID_EmailTemplate_TypeId)
        /// </summary>
        public virtual EmailTemplateType EmailTemplateType { get; set; } // EmailTemplateType_ID_EmailTemplate_TypeId

        public EmailTemplate()
        {
            EmailMessageToSends = new System.Collections.Generic.List<EmailMessageToSend>();
        }
    }

}
// </auto-generated>
