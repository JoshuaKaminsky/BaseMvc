using System.Data.Entity;

namespace BaseMvc.Data.Seed
{
    internal class DbSeeder : CreateDatabaseIfNotExists<BaseDbContext>
    {
        protected override void Seed(BaseDbContext context)
        {
        }
    }
}