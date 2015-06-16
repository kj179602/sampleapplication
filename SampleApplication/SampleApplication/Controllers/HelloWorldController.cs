using System.Web;
using System.Web.Mvc; 
 
namespace SampleApplication.Controllers 
{ 
    public class HelloWorldController : Controller 
    { 
        // 
        // GET: /HelloWorld/ 
 
        public string Index() 
        { 
            return "HelloWorld"; 
        } 
 
        // 
        // GET: /HelloWorld/Welcome/ 
 
        public string Welcome() 
        { 
            return "This is the Welcome action method..."; 
        } 
    } 
}