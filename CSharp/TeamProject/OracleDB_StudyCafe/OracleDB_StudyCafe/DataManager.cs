using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDB_StudyCafe
{
    public class DataManager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;";

        public static OracleConnection OraConn = new OracleConnection(ORADB); //오라클 연결 정보 생성

        public static List<StudyCafe> seats = new List<StudyCafe>();

        const string TABLE = "studycafe";

        static void ConnectDB()
        {
            try
            {
                OraConn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception("DB 연결 에러 " + ex.Message + "에러 위치 " + Environment.NewLine + ex.StackTrace);
            }
        }

        public static void selectQuery()
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " order by to_number(seatspot)"; //테이블 조회, 좌석번호를 기준으로 조회

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);
            
            seats.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                StudyCafe seat = new StudyCafe();
                seat.SeatSpot = int.Parse(item["SeatSpot"].ToString());
                seat.RegisName = item["RegisName"].ToString();
                seat.PhoneNumber = item["PhoneNumber"].ToString();
                seat.RegisMonth = int.Parse(item["RegisMonth"].ToString());
                seat.RegisDate = item["RegisDate"].ToString()
                    == "" ? new DateTime() : DateTime.Parse(item["RegisDate"].ToString());
                seat.EndDate = item["EndDate"].ToString();

                seats.Add(seat);
            }
            OraConn.Close();
        }

        public static StudyCafe selectQuery(int spot)
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " where studyCafe=" + spot + " order by to_number(seatspot)"; //테이블을 조회하되, 좌석번호를 기준으로 조회

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql; //select문을 날린 거

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            DataRow item = ds.Tables[0].Rows[0];
            StudyCafe seat = new StudyCafe();
            seat.SeatSpot = int.Parse(item["SeatSpot"].ToString());
            seat.RegisName = item["RegisName"].ToString();
            seat.PhoneNumber = item["PhoneNumber"].ToString();
            seat.RegisMonth = int.Parse(item["RegisMonth"].ToString());
            //ParkingTime 컬럼에 아무것도 없다면 ParkingTime 속성에 new DateTime()//(현재시간) 삽입
            //아니면 테이블에서 읽어온 값 그대로 삽입
            seat.RegisDate = item["RegisDate"].ToString()
                == "" ? new DateTime() : DateTime.Parse(item["RegisDate"].ToString());
            seat.EndDate = item["EndDate"].ToString();

            OraConn.Close();
            return seat;
        }




            static string Query(string menu, string seatSpot, string regisName, string phoneNumber, string regisMonth)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set RegisName='{regisName}', PhoneNumber='{phoneNumber}',  " +
                        $"RegisMonth='{regisMonth}', RegisDate=sysdate where SeatSpot={seatSpot}";
                    break;
                case "insert":
                    query = $"insert into {TABLE} (seatspot) values({seatSpot})";
                    break;
                case "delete":
                    query = $"delete from {TABLE} where SeatSpot={seatSpot}";
                    break;
                default:
                    break; 
            }
            return query;
        }

        public static void executeQuery(string menu, string seatSpot, string regisName = null, string phoneNumber = null, string regisMonth)
        {
            ConnectDB();
            string query = "";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query(menu, seatSpot, regisName, phoneNumber, regisMonth);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DB 연결 에러 " + ex.Message + "에러 위치 " + Environment.NewLine + ex.StackTrace);
            }
            OraConn.Close();

            selectQuery();

        }
    }
}
