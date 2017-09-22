using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;


namespace Mi_Cooperativa_App_VS
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
            Application.Run(new Login(Connection()));
        }
        static FbConnection Connection ()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            FbConnection db = new FbConnection(connectionString);
            /*FbConnectionStringBuilder csb = new FbConnectionStringBuilder();
            csb.DataSource = "localhost";
            csb.Port = 3050;
            csb.Database = @"C:\Users\renan\Desktop\Proyecto\MI_COOPERATIVA.FDB";
            csb.UserID = "SYSDBA";
            csb.Password = "Honduras2017";
            csb.ServerType = FbServerType.Default;

            FbConnection db = new FbConnection(csb.ToString());*/
            db.Open();
            return db;
        }
    }
}
