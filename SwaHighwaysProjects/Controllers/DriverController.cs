using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaHighwaysProjects.Models;

namespace SwaHighwaysProjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {

        db db = new db();

        [HttpGet]
        public List<Driver> DrList()
        {

            var result=db.DrListe();
            return result;


        }


        [HttpPost]
        public string DrPost(Driver driver)
        {
           
           string islem=db.Drcrud(driver);
            return islem;



        }



        [HttpPut("id")]
        public string DrPut(int id,Driver driver)
        {

            string islem = "";

            driver.DriverId = id;
            islem=db.Drcrud(driver);
            return islem;


        }

        [HttpDelete("id")]
        public string DrDelete(int id,Driver driver)
        {

            string islem = "";

            driver.DriverId = id;
            driver.type = "delete";
            islem = db.Drcrud(driver);
            return islem;



        }

    }
}
