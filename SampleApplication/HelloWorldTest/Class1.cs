using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleApplication.Controllers;
using System.Web.Mvc;
using System.Web;
//using HelloWorldController;

namespace HelloWorldTest
{
    [TestFixture]
    public class HelloWorldControllerTest
    {
        [Test]
        public void FirstTest()
        {
            string expected = "HelloWorld";
            HelloWorldController controller = new HelloWorldController();
            var result = controller.Index();
            Assert.AreEqual(expected, result); 
           
        }

        [Test]
        public void SecondTest()
        {
            HelloWorldController controller = new HelloWorldController();
            var result = controller.Welcome();
            Assert.AreEqual("This is the Welcome action method...", result);

        }


    }
}
