using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Shop_Studio.Classes
{
   public class GeneralPerposeClass
    {
        //generall - perpose class for project
        public static string Entered_User { get; set; } = "ناشناخته";
        public static int    Enrered_User_ID { get; set; }
        //public static string userbar 
        public static string DatabaseConnectedString { get; set; } = "متصل به بانک اطلاعاتی";
        public static string DatabaseDisconnectedString { get; set; } = "عدم اتصال به بانک اطلاعاتی";
        public static System.Globalization.PersianCalendar calendar = new System.Globalization.PersianCalendar();
        public GeneralPerposeClass()
        {
        }
        public static string getDate()
        {
            string output = calendar.GetYear(DateTime.Now) + "/" + calendar.GetMonth(DateTime.Now) + "/" + calendar.GetDayOfMonth(DateTime.Now);
            return output;
        }
        public static string getHour()
        {

            string output = calendar.GetHour(DateTime.Now) + ":" + calendar.GetMinute(DateTime.Now) + ":" + calendar.GetSecond(DateTime.Now);
            return output;
        }
        public static bool checkConnection()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                cn.Open();
                return true;


            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
