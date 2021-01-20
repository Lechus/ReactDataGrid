namespace Company.Employees.Models
{
    public class Organisation
    {
        public Organisation(Database.Organisation entity)
        {
            OrganisationNumber = entity.OrganisationNumber;
            OrganisationName = entity.OrganisationName;
            AddressLine1 = entity.AddressLine1;
            AddressLine2 = entity.AddressLine2;
            AddressLine3 = entity.AddressLine3;
            AddressLine4 = entity.AddressLine4;
            Town = entity.Town;
            Postcode = entity.Postcode;
            House = entity.House;
        }

        public string OrganisationName { get; set; }
        public string OrganisationNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string House { get; set; }
    }
}
