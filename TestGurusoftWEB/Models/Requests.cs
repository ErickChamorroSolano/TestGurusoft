namespace TestGurusoftWEB.Models
{
    public class Requests
    {
        public int id { get; set; }
        public string? request { get; set; }
        public DateTime fechaRequest { get; set; }
        public string? response { get; set; }
        public DateTime fechaResponse { get; set; }
        public string? usuario { get; set; }
    }
}
