using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTU__Class_Attendance_Monitoring_System
{
    class dbconnection
    {
        public string dbconnect()
        {
            string conn = "server=localhost;user=root;password=;database=db_bscpeams";
            return conn;
        }
    }
}
