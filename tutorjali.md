
<!-- 1  create the app -->
dotnet new web --no-https -o ProjectName
<!-- bejini run appit -->
dotnet watch run
<!--  2 gitbash -->
setx ASPNETCORE_ENVIRONMENT Development
<!--2  powershell -->
[Environment]::SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT","Development","User")
<!--  2 macos -->
export ASPNETCORE_ENVIRONMENT=Development


<!-- 3 add at program.cs -->
<!-- before the app -->
builder.Services.AddControllersWithViews();

<!-- after the app -->
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


<!-- Krijo folderin Controllers -->
<!-- krijo kontrollerin e pare me strukture emri HelloControllers.cs ,UserControllers.cs -->
<!--inside Controller -->

// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace NetCoreTutorial.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{    
      <!-pa parameter-  -->
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next ""
    public string Index()        
    {            
    	return "Hello World from HelloController!";        
    }    

    [HttpGet("user/more")]
    public string User(){
        return "hello from user";
    }
    <!-- Me parameter -->
    [HttpGet("user/more/{name}/{age}")]
    public string UserName(string name,string age){
        Console.WriteLine(name);
        return $"hello from user {name} and his age is {age}";
    }
}

