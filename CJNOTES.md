INPROGRESS -- To be formatted later...

For VS2022 support:

Issue: VS2022 automatically prompts to update projects to .NET Framework 4.8 (effects .csproj, .csproj.user, web.config)
Soln: Accept the upgrade to 4.8

Issue: The Web Project <name> requires SQL Server 2012 express LocalDB which is not installed on this computer
Soln: This is the express SQL included with Visual Studio. The default LocalDB instance has changed in newer versions from "(localdb)\v11.0" to "(localdb)\MSSQLLocalDB"
   Update the connectionString in Web.config:
   <connectionStrings>
      <add name="EFDbContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsStore;Integrated Security=True" providerName="System.Data.SqlClient"/>
   </connectionStrings>
