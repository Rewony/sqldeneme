using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqldeneme.classes
{
    public class sqlvar
    {


        public static SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=deneme;Encrypt=False;Integrated Security = True");

        public static void Checkconnection(SqlConnection tempCon)
        {
            if (tempCon.State == ConnectionState.Closed)
            {
                tempCon.Open();

            }
            else
            {


            }



        }


    }



}

