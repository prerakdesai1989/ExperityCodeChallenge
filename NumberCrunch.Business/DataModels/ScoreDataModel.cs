using System.Collections.Generic;

namespace NumberCrunch.Business.DataModels
{
    public class ScoreDataModel
    {
        public IEnumerable<ScoreData> ScoreData { get; set; }
        public string MyMsg { get; set; }

    }

    public class ScoreData
    {
        public int SampleNo { get; set; }
        public string Score { get; set; }
    }

    public class Scores
    {
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";
        public static string Both = "Both";
        public static string None = "None";
    }

}