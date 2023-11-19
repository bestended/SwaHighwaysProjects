using System.Data.SqlClient;
using System.Data;
namespace SwaHighwaysProjects.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PBLKBH\SQLEXPRESS;Initial Catalog=HighwaysProject;User ID=sa;Password=12345;");


        //Bridge Tablosu
        public string BrCrud(Bridge bridge)
        {
            string islem = "";
            con.Open();

            using (SqlCommand cmd=new SqlCommand ("brcrud",con))
            {

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BridgeId",bridge.BridgeId);
                cmd.Parameters.AddWithValue("@BridgeName", bridge.BridgeName);
                cmd.Parameters.AddWithValue("@DatetimeOfEntry", bridge.DatetimeOfEntry);
                cmd.Parameters.AddWithValue("@ReleaseDatetime", bridge.ReleaseDatetime);
                cmd.Parameters.AddWithValue("@Toll", bridge.Toll);
                cmd.Parameters.AddWithValue("@EntranceLocation", bridge.EntranceLocation);
                cmd.Parameters.AddWithValue("@ExitLocation", bridge.ExitLocation);
                cmd.Parameters.AddWithValue("@MotorwayId", bridge.MotorwayId);
                cmd.Parameters.AddWithValue("@type",bridge.type);

                cmd.ExecuteNonQuery();


            }
            con.Close();
            return islem;



        }

        public List<Bridge> BrListe()
        {
            List<Bridge> listem = new List<Bridge>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "brListele";
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                Bridge bridge = new Bridge();

                bridge.BridgeId = Convert.ToInt32(rd["BridgeId"]);
                bridge.BridgeName = (rd["BridgeName"]).ToString();
                bridge.DatetimeOfEntry = Convert.ToDateTime(rd["DatetimeOfEntry"]);
                bridge.ReleaseDatetime= Convert.ToDateTime(rd["ReleaseDatetime"]);
                bridge.Toll= Convert.ToInt32(rd["Toll"]);
                bridge.EntranceLocation= (rd["EntranceLocation"]).ToString();
                bridge.ExitLocation= (rd["ExitLocation"]).ToString();
                bridge.MotorwayId = Convert.ToInt32(rd["MotorwayId"]);


                listem.Add(bridge);

            }


            con.Close();
            return listem;



        }

        //Driver Tablosu

        public string Drcrud(Driver driver)
        {
            string islem = "";
            con.Open();

            
            using (SqlCommand cmd=new SqlCommand ("drcrud",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DriverId", driver.DriverId);
                cmd.Parameters.AddWithValue("@IdentificationNum", driver.IdentificationNum);
                cmd.Parameters.AddWithValue("@Name", driver.Name);
                cmd.Parameters.AddWithValue("@Surname", driver.Surname);
                cmd.Parameters.AddWithValue("@LicenceDate", driver.LicenceDate);
                cmd.Parameters.AddWithValue("@Age", driver.Age);
                cmd.Parameters.AddWithValue("@Phone", driver.Phone);
                cmd.Parameters.AddWithValue("@mail", driver.mail);
                cmd.Parameters.AddWithValue("@type", driver.type);


                cmd.ExecuteNonQuery();




            }
            con.Close();
            return islem;



        }

        public List<Driver> DrListe()
        {
            List<Driver> listem = new List<Driver>();
         
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "drListele";
            con.Open();
           
           

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Driver driver = new Driver();
                driver.DriverId = Convert.ToInt32(rd["DriverId"]);
                driver.IdentificationNum = (rd["IdentificationNum"]).ToString();
                driver.Name= (rd["Name"]).ToString();
                driver.Surname = (rd["Surname"]).ToString();
                driver.LicenceDate =Convert.ToDateTime(rd["LicenceDate"]);
                driver.Age = Convert.ToInt32(rd["Age"]);
                driver.Phone = (rd["Phone"]).ToString();
                driver.mail = (rd["mail"]).ToString();
              

                listem.Add(driver);






            }
            con.Close();
            return listem;





        }



        //Motorway


        public string MwCrud(Motorways motor)
        {
            string islem = "";

            con.Open();

            using (SqlCommand cmd=new SqlCommand ("mwcrud",con))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MotorwayId", motor.MotorwayId);
                cmd.Parameters.AddWithValue("@Distance", motor.Distance);
                cmd.Parameters.AddWithValue("@NumberOfLanes", motor.NumberOfLanes);
                cmd.Parameters.AddWithValue("@NumberOfSigns", motor.NumberOfSigns);
                cmd.Parameters.AddWithValue("@NumberOfTollGate", motor.NumberOfTollGate);
                cmd.Parameters.AddWithValue("@type", motor.type);

                cmd.ExecuteNonQuery();



            }

            con.Close();
            return islem;




        }


        public List<Motorways> MwListe()
        {


            List<Motorways> listem = new List<Motorways>();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "mwListele";
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {
                Motorways motor = new Motorways();

                motor.MotorwayId = Convert.ToInt32(rd["MotorwayId"]);
                motor.Distance = Convert.ToInt32(rd["Distance"]);
                motor.NumberOfLanes = Convert.ToInt32(rd["NumberOfLanes"]);
                motor.NumberOfSigns = Convert.ToInt32(rd["NumberOfSigns"]);
                motor.NumberOfTollGate = Convert.ToInt32(rd["NumberOfTollGate"]);

                listem.Add(motor);
            }
            con.Close();
            return listem;


        }


        //Vehicle

        public string VeCrud(Vehicle vehicle)
        {
            string islem = "";
            con.Open();

            using (SqlCommand cmd = new SqlCommand("vecrud",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                

                cmd.Parameters.AddWithValue("@CarId", vehicle.CarId);
                cmd.Parameters.AddWithValue("@Plate", vehicle.Plate);
                cmd.Parameters.AddWithValue("@Brand", vehicle.Brand);
                cmd.Parameters.AddWithValue("@Model", vehicle.Model);
                cmd.Parameters.AddWithValue("@Color", vehicle.Color);
                cmd.Parameters.AddWithValue("@DriverId", vehicle.DriverId);
                cmd.Parameters.AddWithValue("@BridgeId", vehicle.BridgeId);
                cmd.Parameters.AddWithValue("@type", vehicle.type);


                cmd.ExecuteNonQuery();


            }

            con.Close();
            return islem;


        }

         public List<Vehicle> VeListele()
        {
            List<Vehicle> listem = new List<Vehicle>();
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "veListele";
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                Vehicle vehicle = new Vehicle();


                vehicle.CarId = Convert.ToInt32(rd["CarId"]);
                vehicle.Plate = (rd["Plate"]).ToString();
                vehicle.Brand = (rd["Brand"]).ToString();
                vehicle.Model = (rd["Model"]).ToString();
                vehicle.Color = (rd["Color"]).ToString();
                vehicle.DriverId = Convert.ToInt32(rd["DriverId"]);
                vehicle.BridgeId = Convert.ToInt32(rd["BridgeId"]);


                listem.Add(vehicle);
                   



            }
            con.Close();
            return listem;



        }



    }
}
