using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionsRepository : IRegionRepository
    {
        private readonly NZWalksDBContext nZWalksDB;

        public RegionsRepository(NZWalksDBContext NZWalksDB)
        {
            this.nZWalksDB = NZWalksDB;
        }
  

        public async Task<IEnumerable<Region>> GetAll()
        {
            return await nZWalksDB.Regions.ToListAsync();
        }
    }
}
