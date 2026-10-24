namespace LineResultsBoard.Models
{
    public class ProductionRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public string Line { get; set; } = "Line 1";
        public string Hour { get; set; } = string.Empty; // "06:00 - 07:00"
        public bool IsDayShift { get; set; }
        public int Target { get; set; }
        public int Actual { get; set; } // Result
        public int Difference => Actual - Target;
        public string Comments { get; set; } = "No Issues";
    }

    public class LineBoardViewModel
    {
        public DateTime Date { get; set; } = DateTime.Today;
        // Risks Top
        public bool SafetyRisk { get; set; }
        public string SafetyDescription { get; set; } = "No Safety Risks";
        public string SafetyComments { get; set; } = "";
        public bool QualityRisk { get; set; }
        public string QualityDescription { get; set; } = "Product has dust Particles";
        public string QualityComments { get; set; } = "Blowing out dust Particles";

        // Operators
        public string DayLeadOperator { get; set; } = "Lorraine";
        public string NightLeadOperator { get; set; } = "Godfrey";

        public List<ProductionRecord> DayShift { get; set; } = new();
        public List<ProductionRecord> NightShift { get; set; } = new();

        public int DayShiftTarget => DayShift.Sum(x => x.Target);
        public int DayShiftResult => DayShift.Sum(x => x.Actual);
        public int NightShiftTarget => NightShift.Sum(x => x.Target);
        public int NightShiftResult => NightShift.Sum(x => x.Actual);

        public int Total24hTarget => DayShiftTarget + NightShiftTarget;
        public int Total24hResult => DayShiftResult + NightShiftResult;
        public int Total24hDiff => Total24hResult - Total24hTarget;

        public string PlannedEvent { get; set; } = "PO order Change";
    }
}