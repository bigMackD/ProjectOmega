using System.Collections.Generic;

namespace ProjectOmega.Data.Models.Client
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartamentNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public IEnumerable<string> PhoneNumber { get; set; }
        public IEnumerable<string> EMail { get; set; }
    }
}
