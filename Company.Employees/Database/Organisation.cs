namespace Company.Employees.Database
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Organisation
    {
        [Key]
        public string OrganisationNumber { get; set; }
        public string OrganisationName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string House { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}