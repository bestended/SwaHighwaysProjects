using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaHighwaysProjects.Models;

namespace SwaHighwaysProjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BridgeController : ControllerBase
    {

        db db = new db();



        [HttpGet]
        public List<Bridge> BrGet()
        {

            var result = db.BrListe();
            return result;


        }


        [HttpPost]
        public string BrPost(Bridge bridge)
        {
            string islem = db.BrCrud(bridge);

            return islem;



        }


        [HttpPut("id")]
        public string BrPut(int id,Bridge bridge)
        {
            string islem = "";

            bridge.BridgeId = id;
            islem=db.BrCrud(bridge);

            return islem;



        }


        [HttpDelete("id")]
        public string BrDelete(int id,Bridge bridge)
        {
            string islem = "";
            bridge.BridgeId = id;
            bridge.type = "delete";
            islem=db.BrCrud(bridge);

            return islem;

        }





    }
}
