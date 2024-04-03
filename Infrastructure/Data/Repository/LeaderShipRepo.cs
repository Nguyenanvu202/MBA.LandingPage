using Core.Models.Entity;
using Core.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infrastructure.Data.Repository
{
    public class LeaderShipRepo : ILeaderShipRepo
    {
        private readonly MBAContext _mbaContext;

        public LeaderShipRepo(MBAContext mbaContext)
        {
            _mbaContext = mbaContext;
        }

        public async Task<LeaderShip> CreateLeaderShip(LeaderShip leaderShip)
        {
            List<LeaderShip> leaderShips = new List<LeaderShip>();
            leaderShips = await _mbaContext.LeaderShips.ToListAsync();
            leaderShips.Add(leaderShip);
            await _mbaContext.SaveChangesAsync();
            return leaderShip;
        }

        public async Task<LeaderShip> DeleteLeaderShip(int Id)
        {
            var existLeaderShip = await _mbaContext.LeaderShips
                .FirstOrDefaultAsync(i => i.Id == Id);
            _mbaContext.LeaderShips.Remove(existLeaderShip);
            await _mbaContext.SaveChangesAsync();
            return existLeaderShip;
        }

        public Task<List<LeaderShip>> GetAllLeaderShipAsync()
        {
            return _mbaContext.LeaderShips.ToListAsync();
        }


        public async Task<LeaderShip> GetLeaderShipAsync(int Id)
        {
            return await _mbaContext.LeaderShips.FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<LeaderShip> UpdateLeaderShipAsync(int Id, LeaderShip leaderShip)
        {
            var exsitLeaderShip = await _mbaContext.LeaderShips
                .FirstOrDefaultAsync(i => i.Id == Id);
            exsitLeaderShip.Name = exsitLeaderShip.Name;
            exsitLeaderShip.Position = exsitLeaderShip.Position;
            exsitLeaderShip.ImageUrl = exsitLeaderShip.ImageUrl;
            exsitLeaderShip.UpdatedDate = exsitLeaderShip.UpdatedDate;
            exsitLeaderShip.UpdatedBy = exsitLeaderShip.UpdatedBy;
            await _mbaContext.SaveChangesAsync();
            return exsitLeaderShip;
        }


    }
}
