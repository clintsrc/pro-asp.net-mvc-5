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

Issue: After a successful build, launching the app under IIS Express reports an error:
   Could not load file or assembly 'Microsoft.Web.Infrastructure...' or one of its dependencies. The system cannot find the file specified.
Soln: Restore MVC5 NuGet dependencies for VS2022/.NET 4.8 -- this is broadly required to bring the source up to date with more modern compilers
   1. Go to Tools | NuGet Package Manager | Package Manager Console
   2. Run: Update-Package -Reinstall




TODO:

Ch3
Issue: Launching the app under IIS Express reports error:
   This site can’t be reached The webpage at http://localhost:NNNN/ might be temporarily down or it may have moved permanently to a new web address. ERR_UNSAFE_PORT
Soln: IIS Express is assigning the next available port but the browser considers it unsafe. Manually set the port to a valid number:
   1. Right-click project | Properties | Web
   2. Locate Project URL. Change it to a safe port, e.g.: http://localhost:5000/ (or 5200)
   3. Save, then restart the project (F5)
     
   .vs\<name>\config\applicationhost.config: <binding protocol="http" bindingInformation="*:6566:localhost" />

Ch06
Found conflicts between different versions of the same dependent assembly. In Visual Studio, double-click this warning (or select it and press Enter) to fix the conflicts; otherwise, add the following binding redirects to the "runtime" node in the application configuration file: <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Web.Mvc" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.0.0.0" newVersion="5.0.0.0" /></dependentAssembly></assemblyBinding>


Ch07
Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code.

Exception Details: Ninject.ActivationException: Error activating IProductRepository
No matching bindings are available, and the type is not self-bindable.
Activation path:
 2) Injection of dependency IProductRepository into parameter productRepository of constructor of type ProductController
 1) Request for ProductController

Suggestions:
 1) Ensure that you have defined a binding for IProductRepository.
 2) If the binding was defined in a module, ensure that the module has been loaded into the kernel.
 3) Ensure you have not accidentally created more than one kernel.
 4) If you are using constructor arguments, ensure that the parameter name matches the constructors parameter name.
 5) If you are using automatic module loading, ensure the search path and filters are correct.
