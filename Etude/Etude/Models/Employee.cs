using Newtonsoft.Json;

namespace Etude.Models
{
    public class Employee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("employee_name")]
        public string Name { get; set; }

        [JsonProperty("employee_salary")]
        public int Salary { get; set; }

        [JsonProperty("employee_age")]
        public int Age { get; set; }
    }
}
