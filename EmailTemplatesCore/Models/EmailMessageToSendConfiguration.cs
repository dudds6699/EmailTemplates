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

    // EmailMessageToSend
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class EmailMessageToSendConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmailMessageToSend>
    {
        public EmailMessageToSendConfiguration()
            : this("dbo")
        {
        }

        public EmailMessageToSendConfiguration(string schema)
        {
            ToTable("EmailMessageToSend", schema);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TemplateId).HasColumnName(@"TemplateId").HasColumnType("int");
            Property(x => x.Data).HasColumnName(@"Data").HasColumnType("nvarchar(max)");
            Property(x => x.EmailTo).HasColumnName(@"EmailTo").HasColumnType("nvarchar");
            Property(x => x.SentOn).HasColumnName(@"SentOn").HasColumnType("datetime").IsOptional();
            Property(x => x.Sent).HasColumnName(@"Sent").HasColumnType("bit").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsOptional();
            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime").IsOptional();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsOptional();
            Property(x => x.ModifiedOn).HasColumnName(@"ModifiedOn").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.EmailTemplate).WithMany(b => b.EmailMessageToSends).HasForeignKey(c => c.TemplateId).WillCascadeOnDelete(false); // EmailTemplate_Id_EmailMessageToSend_TemplateId
        }
    }

}
// </auto-generated>
