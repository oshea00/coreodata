## .Net Core 2.0 OData example
### Purpose
I put this example together to validate that indeed you can create OData 4.x services using .Net Core 2.0.
### Creating the Project
1. Used Visual Studio 2017 to create the project from the ASP Core Web API template.
2. Added additional dependencies:
- Microsoft.AspNetCore.OData"
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools"
- Microsoft.VisualStudio.Web.CodeGeneration.Design"
3. Used DBScaffolding tool to extract some table Models:
- Example command:
Scaffold-DbContext "Server=localhost;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables Customer, Order, Product

Note: The one of the tables I forgot had spaces in the name "Order Details". It didn't "scaffold". Subsequent tries with just the table name in quotes results in "Build Failed."

I tried a few things then gave up and hand-coded the OrderDetails model class and the NorthwindContext entries for that particular table...

4. Setting up the connection string and configuring services in Startup.cs for OData and SqlDB (See code), as well as generating the EDM model and adding the route setup for the odata endpoint.

5. Added controllers for Customer and Order (use API controller and change it to extend ODataController. Annotate the [EnableQuery] on the actions, etc.)

### Testing the service
1. http://localhost:port/odata/$metadata.
2. http://localhost:port/odata/Customers




