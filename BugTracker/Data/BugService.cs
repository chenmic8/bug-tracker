using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class BugService
    {
        List<Bug> BugList = new List<Bug>
        {

        };

        //property
        private readonly AppDBContext _dbContext;

        //constructor
        public BugService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //get list of bugs
        public async Task<List<Bug>> GetAllBugsAsync()
        {
            return await _dbContext.Bugs.ToListAsync();
        }

        //create bug
        public async Task<bool> CreateBugAsync(Bug bug)
        {
            await _dbContext.Bugs.AddAsync(bug);
            await _dbContext.SaveChangesAsync();
            return true; //success flag
        }

        //get bug by id
        public async Task<Bug> GetBugAsync(int id)
        {
            //c is type bug. its short hand like list comp. goes thru list of bugs and returns first bug with Id equal to id
            Bug bug = await _dbContext.Bugs.FirstOrDefaultAsync(c => c.Id.Equals(id)); 
            return bug;
        }

        //update bug
        public async Task<bool> UpdateBugAsync(Bug bug)
        {
            _dbContext.Bugs.Update(bug);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //delete bug
        public async Task<bool> DeleteBugAsync(Bug bug)
        {
            _dbContext.Bugs.Remove(bug);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
