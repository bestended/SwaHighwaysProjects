using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaHighwaysProjects.Models;

namespace SwaHighwaysProjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        db db = new db();

        [HttpGet]
        public List<Vehicle> VeGet()
        {

            var result = db.VeListele();
            return result;

        }


        [HttpPost]
        public string Post(Vehicle vehicle)
        {

            string islem = db.VeCrud(vehicle);

            return islem;



        }




        [HttpPut("id")]
        public string VePut(int id, Vehicle vehicle)
        {

            string islem = "";
            vehicle.CarId = id;
            islem = db.VeCrud(vehicle);
            return islem;




        }

        [HttpDelete("id")]
        public string VeDelete(int id, Vehicle vehicle)
        {

            string islem = "";
            vehicle.CarId = id;
            vehicle.type = "delete";
            islem = db.VeCrud(vehicle);
            return islem;


        }



    }
}
