#Organisations WebAPI

Provides an interface to the Company's organisation data store.

Built using Reactjs, and .Net Core API 3.1 with EF Core using InMemoryDatabase

## Overview

A simple Web Application that provides a web interface into the Organisations data store. It is coded in C# and built using .NET Core 3.1 (LTS).
There is a simple InMemoryDatabase database that provides the in memory storage.


###Backend:

API exposes two endpoints:
*api/Organisation*
 Get - returns all Organisations
*api/Employee*
Get - returns all Employees


###Frontend:

*/employees* - display all employees
*/organisations* - display all organisations

## Get started

Just click Run


## Next Versions

1. Provide all data from xls
2. Update Employees controller to use OrganisationsDbContext
3. Ensure the data displayed on screen is paged
4. Master / Details view for Organisations
5. Add Swagger documentation
6. Auditing capability to track data usage
