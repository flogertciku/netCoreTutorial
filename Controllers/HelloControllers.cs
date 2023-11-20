// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace NetCoreTutorial.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet("")]
    public ViewResult Index()        
    {            
    	return View();  
            //  Views/Hello/Index.cshtml
    }    

    [HttpGet("user/more/{name}/{age}")]
    public ViewResult UserName(string name,string age){
        // Console.WriteLine(name);
        ViewBag.Name = name ;  
        ViewBag.Age= age;  
        return View();
    }
}

