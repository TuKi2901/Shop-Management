using System.Configuration;
using System.Data.SqlClient;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        /*<connectionStrings>
		<add name = "DuAnMau"

             connectionString="Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DuAnMau.mdf;Integrated Security=True; " />
	</connectionStrings>*/


        static string connstr = ConfigurationManager.ConnectionStrings["DuAnMau"].ConnectionString.ToString();
        protected SqlConnection _conn = new SqlConnection(connstr);



        //protected SqlConnection _conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\FPT Polytechnic\\DuAnMau\\Assignment\\ASM\\QuanLyBanHang\\DAL_QLBanHang\\DuAnMau.mdf\";Integrated Security=True");

    }
}

