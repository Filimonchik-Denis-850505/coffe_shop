using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

using NLayerApp.DAL.Repositories.Data;

namespace DbMigrator
{
    internal class Startup : IHostedService
    {
        private readonly ShopDbContext _dbContext;

        public Startup(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _dbContext.Database.Migrate();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return _dbContext.DisposeAsync().AsTask();
        }
    }
}