using IELTS.Entity_Models.Entity_Config;
using IELTS.Entity_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;
using System.Text;

namespace IELTS.Entity_Models
{
    public class IELTSStoreDbContext : DbContext
    {
        public IELTSStoreDbContext(DbContextOptions<IELTSStoreDbContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<IELTSStoreDbContext>
        {
            IELTSStoreDbContext IDesignTimeDbContextFactory<IELTSStoreDbContext>.CreateDbContext(string[] args)
            {
                DbContextOptionsBuilder<IELTSStoreDbContext> optionsBuilder = new();
                if(!optionsBuilder.IsConfigured)
                {
                    var projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new[] { @"bin\" }, StringSplitOptions.RemoveEmptyEntries)[0];
                    var configuration = new ConfigurationBuilder().SetBasePath(projectPath).AddJsonFile("appsettings.json").Build();
                    var connectionString = configuration.GetConnectionString("CMTConnection");
                    optionsBuilder.EnableSensitiveDataLogging().UseLazyLoadingProxies().UseSqlServer(connectionString);                 
                }
                return new IELTSStoreDbContext(optionsBuilder.Options);
            }
        }
        public DbSet<WordMeaning> WordMeanings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ApplyConfiguration(new WordMeaningConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}

static class IndexExtension
{
    public static IndexBuilder Include<TEntity>(this IndexBuilder indexBuilder, Expression<Func<TEntity, object>> indexExpression)
    {
        StringBuilder includeStatement = new();
        foreach(var column in indexExpression.GetPropertyAccessList())
        {
            if(includeStatement.Length > 0)
            {
                includeStatement.Append(", ");
            }
            includeStatement.Append($"[{column.Name}]");
        }
        indexBuilder.HasAnnotation("SqlServer:IncludeIndex", includeStatement.ToString());
        return indexBuilder;
    }
}
