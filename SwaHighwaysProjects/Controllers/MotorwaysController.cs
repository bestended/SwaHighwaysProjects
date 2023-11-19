using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaHighwaysProjects.Models;

namespace SwaHighwaysProjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorwaysController : ControllerBase
    {

        db db = new db();

        [HttpGet]
        public List<Motorways> MwGet()
        {
            var result=db.MwListe();
            return result;



        }

        [HttpPost]
        public string MwPost(Motorways motor)
        {
            string islem=db.MwCrud(motor);

            return islem;

        }

        [HttpPut("id")]
        public string MwPut(int id,Motorways motor)
        {

            string islem = "";
            motor.MotorwayId = id;
           islem =db.MwCrud(motor);
            return islem;

        }

        [HttpDelete("id")]
        public string MwDelete(int id,Motorways motor)
        {

            string islem = "";

            motor.MotorwayId = id;
            motor.type = "delete";

            islem = db.MwCrud(motor);
            return islem;




        }   

    }
}
