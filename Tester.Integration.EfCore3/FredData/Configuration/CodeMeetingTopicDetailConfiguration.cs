// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.co.uk/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 15 DEC 2022
//
// The following connection settings were used to generate this file:
//     Connection String Name: "FredDbContext"
//     Connection String:      "Data Source=(local);Initial Catalog=Fred;Integrated Security=True"
//
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2037.2
//
// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V3Fred
{
    // CODE_MeetingTopicDetails
    public class CodeMeetingTopicDetailConfiguration : IEntityTypeConfiguration<CodeMeetingTopicDetail>
    {
        public void Configure(EntityTypeBuilder<CodeMeetingTopicDetail> builder)
        {
            builder.ToTable("CODE_MeetingTopicDetails", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_CODE_MeetingTopicDetails").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.IdReuniao).HasColumnName(@"id_reuniao").HasColumnType("int").IsRequired();
            builder.Property(x => x.OrdTrab).HasColumnName(@"ord_trab").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Assunto).HasColumnName(@"assunto").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Desenvolvimento).HasColumnName(@"desenvolvimento").HasColumnType("nvarchar(max)").IsRequired(false);
            builder.Property(x => x.Origem).HasColumnName(@"origem").HasColumnType("nvarchar(5)").IsRequired(false).HasMaxLength(5);
            builder.Property(x => x.IdOrigem).HasColumnName(@"id_origem").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            builder.Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DateChanged).HasColumnName(@"DateChanged").HasColumnType("datetime").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.CodeParamMeetingTopicDetailSource).WithMany(b => b.CodeMeetingTopicDetails).HasPrincipalKey(p => p.Code).HasForeignKey(c => c.Origem).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource");
        }
    }

}
// </auto-generated>
