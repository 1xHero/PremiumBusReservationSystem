﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumBusReservationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class general
    {

        protected static string sqlcon = "server=127.0.0.1;user id=root;database=premiumbus;Password=toor1234;";
        public static string username = "";

        public static string getsql()
        {
            return sqlcon;
        }

        public static string getusername()
        {
            
            return username;
        }
        public static void setusername(string a)
        {
            username = a;
        }
    }
}
