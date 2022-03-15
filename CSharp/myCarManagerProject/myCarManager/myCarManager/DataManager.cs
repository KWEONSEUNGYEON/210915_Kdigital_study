using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCarManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {

        }
        public static void Save() //주차 출차때 주로 사용
        {

        }
        public static void PrintLog(string contents)
        {
            //폴더 명이 ParkingHistory인 것을 찾는 중
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");

            if(!di.Exists)
            {
                di.Create();
            }

            using(StreamWriter Writer = new StreamWriter("ParkingHistory\\ParkingHistory.txt", true))
            {
                Writer.WriteLine(contents);
            }
        }
    }
}
