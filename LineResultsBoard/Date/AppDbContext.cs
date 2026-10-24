using Microsoft.EntityFrameworkCore;

namespace LineResultsBoard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductionRecordDb> ProductionRecords { get; set; } = null!;
        public DbSet<ShiftDb> Shifts { get; set; } = null!;
    }

    public class ProductionRecordDb
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Hour { get; set; } = string.Empty;
        public string Shift { get; set; } = string.Empty;
        public string Line { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public string DayOperator { get; set; } = string.Empty;
        public string NightOperator { get; set; } = string.Empty;
        public string DayLeadOperator { get; set; } = string.Empty;
        public string NightLeadOperator { get; set; } = string.Empty;
        public int Target { get; set; }
        public int Actual { get; set; }
    }

    public class ShiftDb
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
    }
}