namespace Company.Employees.Database
{
    using System.Collections.Generic;
    using System.Linq;

    public class DataGenerator
    {
        public static void Initialize(OrganisationsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any organisations already in database.
            if (context.Organisations.Any())
            {
                return;   // Database has been seeded
            }

            context.Organisations.AddRange(
                new Organisation
                {
                    OrganisationName = "Barclays UK PLC",
                    OrganisationNumber = "09740322",
                    AddressLine1 = "1 Churchill Place",
                    AddressLine2 = "",
                    AddressLine3 = "",
                    AddressLine4 = "",
                    Town = "London",
                    Postcode = "E14 5HP",
                    House = "12",
                    Employees = new List<Employee>
                                        {
                                            new Employee
                                                {
                                                    OrganisationNumber = "09740322",
                                                    FirstName = "Janet",
                                                    LastName = "Smith"
                                                }
                                        }
                },
                new Organisation
                {
                    OrganisationName = "HSBC BANK PLC",
                    OrganisationNumber = "00014259",
                    AddressLine1 = "8 Canada Square",
                    AddressLine2 = "",
                    AddressLine3 = "",
                    AddressLine4 = "",
                    Town = "London",
                    Postcode = "E14 5HQ",
                    House = "8",
                    Employees = new List<Employee>
                                        {
                                            new Employee
                                                {
                                                    OrganisationNumber = "00002065",
                                                    FirstName = "Mitch",
                                                    LastName = "Krause"
                                                }
                                        }
                });

            context.SaveChanges();

        }
    }
}