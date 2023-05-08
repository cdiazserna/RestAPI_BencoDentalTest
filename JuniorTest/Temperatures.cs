using System.Text.Json;

namespace JuniorTest
{
    public static class Temperatures
    {
        public static List<int> bodyTamperature(string doctorName, int diagnosisId)
        {
            var filtered = new List<Datum>();
            for (int i = 1; i <= 10; i++)
            {
                var url = $"https://jsonmock.hackerrank.com/api/medical_records?page={i}";
                using (var httpClient = new HttpClient())
                {
                    var response = httpClient.GetAsync(url).Result;                        
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        var result = JsonSerializer.Deserialize<Result>(content);
                        filtered
                            .AddRange(result!.data!.Where(x => x.doctor!.name == doctorName && x.diagnosis!.id == diagnosisId)
                            .ToList());
                    }
                }
            }
            var min = (int)filtered.Min(x => x.vitals!.bodyTemperature);
            var max = (int)filtered.Max(x => x.vitals!.bodyTemperature);
            return new List<int>
            {
                min,
                max
            };
        }
    }
}
