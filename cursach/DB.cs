using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach
{
    class DB
    {
        string StringConnection = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
        NpgsqlConnection Con;
        NpgsqlCommand Cmd;
        private void connection()
        {
            Con = new NpgsqlConnection();
            Con.ConnectionString = StringConnection;

            if(Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }

            
        }

    }
}
