using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linko.Domain
{
    public class UserProfileMap : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable("UserProfile", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username);
            builder.Property(x => x.Password);
            builder.Property(x => x.Email);
            builder.Property(x => x.AccountNo);
            builder.Property(x => x.FallName);
            builder.Property(x => x.ProfileImg);
            builder.Property(x => x.Bio);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.LastAccessDate);
            builder.Property(x => x.DeleteAfterperiod);
            builder.Property(x => x.InsertDate);
            builder.Property(x => x.UpdateDate);
            builder.Property(x => x.DeleteDate);
            builder.Property(x => x.Version).IsRowVersion();

            builder.Ignore(x => x.Accounts);
        }
}
}
