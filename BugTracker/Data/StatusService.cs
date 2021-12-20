using BugTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class StatusService
    {
        //property
        private readonly AppDBContext _dbContext;

        //constructor
        public StatusService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //get status by id
        public async Task<Status> GetStatusAsync(int id)
        {
            Status status = await _dbContext.Statuses.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return status;
        }
    }
}
