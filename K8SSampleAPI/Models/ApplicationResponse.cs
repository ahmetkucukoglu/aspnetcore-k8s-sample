namespace K8SSampleAPI.Models
{
    using System;

    public class ApplicationResponse
    {
        public Guid ApplicationId { get; set; }
        public string APIKey { get; set; }
        public string APISecret { get; set; }
    }
}
