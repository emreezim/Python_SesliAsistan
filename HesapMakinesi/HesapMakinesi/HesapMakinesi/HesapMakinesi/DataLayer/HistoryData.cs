using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

using System.Data.Entity;

using System.Data.SqlTypes;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;
using Entity;

namespace HesapMakinesi
{


    public class HistoryData:IData
    {

        SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\emre2\\OneDrive\\Desktop\\HesapMakinesi\\HesapMakinesi\\HesapMakinesi\\HesapMakinesi\\DataLayer\\CalculatorData.mdf;Integrated Security=True");
       

        SqlCommand cmd;
     

        //Geçmişi kayıt eden Fonksiyon
        public object BringData(object bringData) {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("BringData", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                bringData = ds.Tables[0];
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Bağlantı Hatası");
            }
          
            //bringData = calQuery.BringData();

            return bringData;

        }
        //Geçmişi kayıt eden fonksiyon
        public  void SaveData(string lbValue,string lbProcces) {

            try
            {
                con.Open();
                cmd = new SqlCommand("SaveData @p1,@p2,@p3", con);

                cmd.Parameters.AddWithValue("@p1", lbValue);
                cmd.Parameters.AddWithValue("@p2", lbProcces);
                cmd.Parameters.AddWithValue("@p3", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           

            //calQuery.SaveData(lbValue, lbProcces, (DateTime.Now));
            //calQuery.SaveChanges();
        }

        //Geçmişi Silen Fonksiyon
        public  object DelData(object deldata) {
            con.Open();
            cmd = new SqlCommand("DelData", con);
            cmd.ExecuteNonQuery();
            con.Close();
            deldata = BringData(deldata);

            //calQuery.DelData();
            //calQuery.SaveChanges();

            return deldata;
            
        }
        public  void SelectData(object selectdata) {
            con.Open();
            cmd = new SqlCommand("SelectDel @ID",con);
            cmd.Parameters.AddWithValue("@ID",selectdata);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  object FindData(object findata,string textId) {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter($"FindData {textId}", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                findata = ds.Tables[0];
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return findata;
        }
    }
}
