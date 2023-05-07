namespace JuniorTest
{

    public class Result
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum>? data { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public long timestamp { get; set; }
        public Diagnosis? diagnosis { get; set; }
        public Vitals? vitals { get; set; }
        public Doctor? doctor { get; set; }
        public int userId { get; set; }
        public string? userName { get; set; }
        public string? userDob { get; set; }
        public Meta? meta { get; set; }
    }

    public class Diagnosis
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int severity { get; set; }
    }

    public class Vitals
    {
        public int bloodPressureDiastole { get; set; }
        public int bloodPressureSystole { get; set; }
        public int pulse { get; set; }
        public int breathingRate { get; set; }
        public float bodyTemperature { get; set; }
    }

    public class Doctor
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class Meta
    {
        public int height { get; set; }
        public int weight { get; set; }
    }
}
