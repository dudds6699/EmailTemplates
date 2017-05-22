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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class DbContext : System.Data.Entity.DbContext, IDbContext
    {
        public System.Data.Entity.DbSet<EmailMessageToSend> EmailMessageToSends { get; set; } // EmailMessageToSend
        public System.Data.Entity.DbSet<EmailTemplate> EmailTemplates { get; set; } // EmailTemplate
        public System.Data.Entity.DbSet<EmailTemplateType> EmailTemplateTypes { get; set; } // EmailTemplateType

        static DbContext()
        {
            System.Data.Entity.Database.SetInitializer<DbContext>(null);
        }

        public DbContext()
            : base("Name=EmailTemplates")
        {
        }

        public DbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public DbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public DbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new EmailMessageToSendConfiguration());
            modelBuilder.Configurations.Add(new EmailTemplateConfiguration());
            modelBuilder.Configurations.Add(new EmailTemplateTypeConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new EmailMessageToSendConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailTemplateConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailTemplateTypeConfiguration(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>
