using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Data
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;";
        public static OracleConnection OraConn = new OracleConnection(ORADB);
        public static List<ParkingCar> cars = new List<ParkingCar>();
        const string TABLE = "projectcar";

        static void ConnectDB()
        {
            try
            {
                OraConn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void selectQuery()
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " order by to_number(parknum)";

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            cars.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ParkingCar car = new ParkingCar();
                car.ParkNum = int.Parse(item["parknum"].ToString());
                car.CarNumber = item["carnumber"].ToString();
                car.DriverName = item["drivername"].ToString();
                car.PhoneNumber = item["phonenumber"].ToString();
                car.ParkingTime = item["parkingtime"].ToString()
                    == "" ? new DateTime() : DateTime.Parse(item["parkingtime"].ToString());

                cars.Add(car);
            }

            OraConn.Close();
        }

        public static ParkingCar selectQuery(int spot)
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " where parknum=" + spot + " order by to_number(parknum)";

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            DataRow item = ds.Tables[0].Rows[0];
            ParkingCar car = new ParkingCar();
            car.ParkNum = int.Parse(item["parknum"].ToString());
            car.CarNumber = item["carnumber"].ToString();
            car.DriverName = item["drivername"].ToString();
            car.PhoneNumber = item["phonenumber"].ToString();
            car.ParkingTime = item["parkingtime"].ToString()
                == "" ? new DateTime() : DateTime.Parse(item["parkingtime"].ToString());

            OraConn.Close();
            return car;
        }
        static string Query(string menu, string parknum, string carnumber, string drivername, string phonenumber)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set carnumber='{carnumber}',drivername='{drivername}',phonenumber='{phonenumber}',parkingtime=sysdate where parknum={parknum}";
                    break;
                case "delete":
                    query = $"update {TABLE} set carnumber='',drivername='',phonenumber='',parkingtime=null";
                    break;
                default:
                    break;
            }
            return query;
        }
        public static void executeQuery(string menu, string parknum, string carnumber = null, string drivername = null, string phonenumber = null)
        {
            ConnectDB();
            string query = "";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query(menu, parknum, carnumber, drivername, phonenumber);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                OraConn.Close();
                throw;
            }
            OraConn.Close();

            selectQuery();
        }

    }
}
