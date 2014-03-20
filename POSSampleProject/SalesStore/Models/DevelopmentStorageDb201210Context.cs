using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SalesStore.Models.Mapping;

namespace SalesStore.Models
{
    public partial class DevelopmentStorageDb201210Context : DbContext
    {
        static DevelopmentStorageDb201210Context()
        {
            Database.SetInitializer<DevelopmentStorageDb201210Context>(null);
        }

        public DevelopmentStorageDb201210Context()
            : base("Name=DevelopmentStorageDb201210Context")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Blob> Blobs { get; set; }
        public DbSet<BlobContainer> BlobContainers { get; set; }
        public DbSet<BlockData> BlockDatas { get; set; }
        public DbSet<CommittedBlock> CommittedBlocks { get; set; }
        public DbSet<CurrentPage> CurrentPages { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<QueueContainer> QueueContainers { get; set; }
        public DbSet<QueueMessage> QueueMessages { get; set; }
        public DbSet<TableContainer> TableContainers { get; set; }
        public DbSet<TableRow> TableRows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new BlobMap());
            modelBuilder.Configurations.Add(new BlobContainerMap());
            modelBuilder.Configurations.Add(new BlockDataMap());
            modelBuilder.Configurations.Add(new CommittedBlockMap());
            modelBuilder.Configurations.Add(new CurrentPageMap());
            modelBuilder.Configurations.Add(new PageMap());
            modelBuilder.Configurations.Add(new QueueContainerMap());
            modelBuilder.Configurations.Add(new QueueMessageMap());
            modelBuilder.Configurations.Add(new TableContainerMap());
            modelBuilder.Configurations.Add(new TableRowMap());
        }
    }
}
