namespace Company.Employees.Database
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string OrganisationNumber { get; set; }
        public Organisation Organisation { get; set; }
    }
}