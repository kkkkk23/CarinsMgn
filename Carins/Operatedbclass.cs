using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace Carins
{
    class Operatedbclass
    {
        //SqlConnection sqlconn = Connectclass.MyConnection();
        public SqlConnection Opendbcn()
        {
           // string connectionstring = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Carinsdt.mdf;Integrated Security=True");
            string connectionstring = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=d:\visual studio 2013\Projects\Carins\Carins\Carinsdt.mdf;Integrated Security=True");
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                Console.WriteLine("Successfully open the connection.");
            }
            catch (Exception q)
            {
                Console.WriteLine("Not able to open the connection due to\n" + q.ToString());
            }
              con.Close();
            return con;
        }
        

        public void CloseDatabaseCnn() /////close connection
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Close();
        }

        public string Finduserpass(string username)///////match login password
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string userpass = "";
            string sql = "select Pass from Loinfo where Acc = '" + username + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                userpass = dr["Pass"].ToString();
            }
            sqlconn.Close();
            return userpass;
        }

        public string Findusertype(string username)///////find account type
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();   
            string usertype = "";
            string sql = "select Actype from Loinfo where Acc = '" + username + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                usertype = dr["Actype"].ToString();
            }
            sqlconn.Close();
            return usertype;
        }

        public void Insertcusinfo(string cusname,string carnum,string cusphone,int carprice){
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "Insert into Cusinsinfo" +
               "(Cusphone, Cusname, Carnum, Carprice) values ('" + cusphone + "'," +
               "N'" + cusname + "', N'" + carnum + "', '" + carprice + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }

        public void Insertinsrecord(int rcid,string cusname,string carnum,string cusphone,int carprice,
            string instype,string fayear,string ncd,int sum,string stdate,string endate) {
                SqlConnection sqlconn = Opendbcn();
                sqlconn.Open();
                string sql = "Insert into Insinfos" +
                   "(Rcid,Cusname, Carnum,Cusphone, Carprice,Instype,Fayear,NCD,Sum,Stdate,Enddate) values ('" + rcid + "'," +
                   "N'" + cusname + "', N'" + carnum + "', '" + cusphone + "', '" + carprice + "'," +
            "'" + instype + "','" + fayear + "','" + ncd + "','" + sum + "','" + stdate + "','" + endate + "')";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                cmd.ExecuteNonQuery();
                sqlconn.Close();
        }


        public void Insertloinfo(string actype, string acc, string pass)
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "Insert into Loinfo" +
               "(Actype,Acc, Pass) values ('" + actype + "'," +
               "'" + acc + "', '" + pass + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.ExecuteNonQuery();
            sqlconn.Close();

        }
        public string Matchphone(string usphone)///////detec phone number already exist?
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string countnumber = "";
            string sql = "select count(Cusphone) as number from Cusinsinfo where Cusphone= '" + usphone + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                countnumber = dr["number"].ToString();
            }
            sqlconn.Close();
            return countnumber;
        }

        public string Matchaccount(string acc)
        {  ////detec account already exist?
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string acco = "";
            string sql = "select count(Acc) as number from Loinfo where Acc= '" + acc + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                acco = dr["number"].ToString();
            sqlconn.Close();
            return acco;

        }

        public void initdtbind(DataGridView dgv, string tableName)
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "select * from Insinfos where Rcid=0";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds, tableName);
            dgv.DataSource = ds.Tables[0];

            for (int i = 0; i < dgv.Rows.Count; )
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
                i += 1;
            }

            sqlconn.Close();
            ds.Dispose();
        }
        
        public string dtbind(DataGridView dgv,  string tableName,string phone)
        {
            string usphone="";
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "select * from Cusinsinfo where Cusphone= '" + phone + "'and Instype is null";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds, tableName);
            dgv.DataSource = ds.Tables[0];
            for (int i = 0; i < dgv.Rows.Count; )
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
                i += 1;
            }
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usphone = dr["Cusphone"].ToString();
            }
            sqlconn.Close();
            ds.Dispose();
            return usphone;
        }

        public string dtallbind(DataGridView dgv, string tableName,string phone)
        {
            string usphone = "";
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "select * from Insinfos where Cusphone= '" + phone + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds, tableName);
            dgv.DataSource = ds.Tables[0];

            for (int i = 0; i < dgv.Rows.Count; )
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
                i += 1;
            }
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usphone = dr["Cusphone"].ToString();
            }
            sqlconn.Close();
            ds.Dispose();
            return usphone;
        }

        public string dtrcbind(DataGridView dgv, string tableName, int rcidd)
        {
            string rcid = "";
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "select * from Insinfos where Rcid= '" + rcidd + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds, tableName);
            dgv.DataSource = ds.Tables[0];

            for (int i = 0; i < dgv.Rows.Count; )
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
                i += 1;
            }
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rcid = dr["Rcid"].ToString();
            }
            sqlconn.Close();
            ds.Dispose();
            return rcid;
        }

        public void Deletercid(int rcid)
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "delete from Insinfos where Rcid='"+rcid+"'";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.ExecuteNonQuery();
            
        }

        public string Detecrcid(int rcid) {
            string detectrcid = "";
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql2 = "select* from Insinfos where Rcid='" + rcid + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, sqlconn);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                detectrcid = dr["Rcid"].ToString();
            }
            sqlconn.Close();
            return detectrcid;
        }


        public void Updatecusinfo(string cusname, string carnum, string cusphone, int carprice)
        {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql0="delete from Cusinsinfo where Cusphone='"+cusphone+"'";
            SqlCommand cmd0 = new SqlCommand(sql0, sqlconn);
            cmd0.ExecuteNonQuery();
            /////////////////////////later create
            string sql = "Insert into Cusinsinfo" +
               "(Cusphone, Cusname, Carnum, Carprice) values ('" + cusphone + "'," +
               "N'" + cusname + "', N'" + carnum + "', '" + carprice + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }
        
        public void test() {
            SqlConnection sqlconn = Opendbcn();
            sqlconn.Open();
            string sql = "insert into Cusinsinfo(Cusphone, Cusname, Carnum, Carprice) values ('01989625','jack','wqa5789',15000)";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }
    }
}
