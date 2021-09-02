using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Angular5AndDotNetCore5.EntityFrameworkCore
{
    public static class Angular5AndDotNetCore5DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Angular5AndDotNetCore5DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Angular5AndDotNetCore5DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
