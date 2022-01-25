using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDB_StudyRoom
{
    internal class DataMannager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;";

        public static OracleConnection OraConn = new OracleConnection(ORADB); //오라클 연결 정보 생성

        public static List<StudyRoom> rooms = new List<StudyRoom>();

        const string TABLE = "studyroom";

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

            rooms.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                StudyRoom room = new StudyRoom();
                room.SeatSpot = int.Parse(item["SeatSpot"].ToString());
                room.RegisName = item["RegisName"].ToString();
                room.PhoneNumber = item["PhoneNumber"].ToString();
                room.RegisMonth = int.Parse(item["RegisMonht"].ToString());
                room.RegisDate = item["RegisTime"].ToString()
                    == "" ? new DateTime() : DateTime.Parse(item["RegisTime"].ToString());

                rooms.Add(room);
            }
            OraConn.Close();
        }

        /*
        public static StudyRoom selectQuery(int room)
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " Where studyroom=" + room + " order by to_number(seatspot)"; //테이블 조회, 좌석번호를 기준으로 조회

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            rooms.Clear();

            DataRow item = ds.Tables[0].Rows[0];  
            StudyRoom room = new StudyRoom();
            room.SeatSpot = int.Parse(item["SeatSpot"].ToString());
            room.RegisName = item["RegisName"].ToString();
            room.PhoneNumber = item["PhoneNumber"].ToString();
            room.RegisMonth = int.Parse(item["RegisMonht"].ToString());
            room.RegisTime = item["RegisTime"].ToString()
                == "" ? new DateTime() : DateTime.Parse(item["RegisTime"].ToString());

            OraConn.Close();
            return room;
        }
        */

        static string Query(string menu, string seatSpot, string regisName, string phoneNumber, string regisMonth)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set SeatSpot='{seatSpot}', RegisName='{regisName}', PhoneNumber='{phoneNumber}',  " +
                        $"RegisMonth='{regisMonth}', regisTime=sysdate where seatspot={seatSpot}";
                    break;
                case "insert":
                    query = $"insert into {TABLE} (seatspot) values({seatSpot})";
                    break;
                case "delete":
                    query = $"delete from {TABLE} where seatSpot={seatSpot}";
                    break;
                default:
                    break;
            }
            return query;
        }

        public static void executeQuery(string menu, string seatSpot, string regisName = null, string phoneNumber = null, string regisMonth = null)
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

