namespace LineResultsBoard.Models
{
    public class ShiftSummaryViewModel
    {
        public string Shift { get; set; } = string.Empty;
        public string Line { get; set; } = string.Empty;
        public List<ProductionRecord> Records { get; set; } = new List<ProductionRecord>();
        public int TotalTarget { get; set; }
        public int TotalActual { get; set; }
    }
}