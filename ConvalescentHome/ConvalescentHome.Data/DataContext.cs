using ConvalescentHome.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConvalescentHome.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
        public DbSet<BabyEntity> babies { get; set; }
        public DbSet<InvitationEntity> invitations { get; set; }
        public DbSet<ParturientEntity> Parturients { get; set; }
        public DbSet<RoomsEntity> rooms { get; set; }
        public DbSet<WorkerEntity> workers { get; set; }


    }
}
