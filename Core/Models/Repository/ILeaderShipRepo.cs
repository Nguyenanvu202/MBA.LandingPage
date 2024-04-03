using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface ILeaderShipRepo
    {
        Task<List<LeaderShip>> GetAllLeaderShipAsync();
        Task<LeaderShip> GetLeaderShipAsync(int Id);
        Task<LeaderShip> UpdateLeaderShipAsync(int Id, LeaderShip leaderShip);
        Task<LeaderShip> CreateLeaderShip(LeaderShip leaderShip);
        Task<LeaderShip> DeleteLeaderShip(int Id);
    }
}
