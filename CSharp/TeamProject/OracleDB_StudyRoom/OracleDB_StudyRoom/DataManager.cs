using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDB_StudyRoom
{
    public class DataManager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
       "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
       "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
       "User Id=c##scott;Password=tiger;";

        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<StudyRoom> rooms = new List<StudyRoom>();

        const string TABLE = "studycar";

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
            sql = "select * from " + TABLE + " order by to_number(seatspot)";

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
                room.UseTime = int.Parse(item["UseTime"].ToString());
                room.RegisTime = item["RegisTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["RegisTime"].ToString());
                room.EndTime = item["RegisTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["RegisTime"].ToString()); //수정
            
                rooms.Add(room);
            }

            OraConn.Close();
        }

        static string Query(string menu, string seatSpot, string regisName, string phoneNumber, string useTime)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set RegisName='{regisName}', PhoneNumber='{phoneNumber}', " +
                        $"UseTime = {useTime}, RegisTime = sysdate where seatspot = {seatSpot}, EndTime = sysdate where seatspot = {seatSpot}"; //수정
                    break;
                case "insert":
                    query = $"insert into {TABLE} (seatspot) values({seatSpot})";
                    break;
                case "delete":
                    query = $"delete from {TABLE} where SeatSpot = {seatSpot})";
                    break;
                default:
                    break;
            }
            return query;
        }

        public static void executeQuery(string menu, string seatSpot, string regisName = null, string phoneNumber = null, string useTime = null)
        {
            ConnectDB();
            string query = "";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query(menu, seatSpot, regisName, phoneNumber, useTime);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                OraConn.Close();

                throw new Exception("DB 연결 에러 " + ex.Message + "에러 위치 " + Environment.NewLine + ex.StackTrace);
            }

            OraConn.Close();

            selectQuery();
        }

    }
}
