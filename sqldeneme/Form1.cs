using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using sqldeneme.classes;

namespace sqldeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void refleshpage() 
        {

            SqlCommand command = new SqlCommand("Select * from kevgir", sqlvar.connection);
            sqlvar.Checkconnection(sqlvar.connection);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }



        private void Form1_Load(object sender, EventArgs e)
        {

            refleshpage();
            
        }

        private void register_Click(object sender, EventArgs e)
        {


            SqlCommand com = new SqlCommand("insert into kevgir(ad,numara,kayýt_tarihi) values (@pad,@pnum,@pdate)",sqlvar.connection);
            sqlvar.Checkconnection(sqlvar.connection);

            com.Parameters.AddWithValue("@pad",tboxad.Text);
            com.Parameters.AddWithValue("@pnum", tboxnum.Text);
            com.Parameters.AddWithValue("@pdate", tboxdate.Text);

            com.ExecuteNonQuery();
            refleshpage();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(tboxdelete.Text);

            SqlCommand comdel = new SqlCommand("delete from kevgir where numara=@pid",sqlvar.connection);
            sqlvar.Checkconnection(sqlvar.connection);
            comdel.Parameters.AddWithValue("@pid", selectedId); 
            comdel.ExecuteNonQuery();
            refleshpage();

        }

        private void btnupd_Click(object sender, EventArgs e)
        {



            SqlCommand comup = new SqlCommand("update kevgir set @uptalan='@uptdeðer'where=@uptalan='@uptdeg'", sqlvar.connection);
            sqlvar.Checkconnection(sqlvar.connection);

            comup.Parameters.AddWithValue("@uptalan", tboxuplan.Text);
            comup.Parameters.AddWithValue("@uptdeðer", tboxupdeger.Text);
            comup.Parameters.AddWithValue("@pdate", tboxuptdeg.Text);

            comup.ExecuteNonQuery();
            refleshpage();



        }
    }
}