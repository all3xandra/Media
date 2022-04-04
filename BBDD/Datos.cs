using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD
{
    public class Datos
    {
        private SqlConnection connection;

        public Datos()
        {
            connect();
        }

        /// <summary>
        /// Este método realiza la conexion a la base de datos.
        /// </summary>
        /// <returns>Boolean</returns>
        public void connect()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:hads2207.database.windows.net,1433";
                builder.UserID = "apelipian001@ikasle.ehu.eus@hads2207";
                builder.Password = "hadsaj2122@";
                builder.InitialCatalog = "HADS22-07";

                connection = new SqlConnection(builder.ConnectionString);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public List<int> getHoras(String asign)
        {
            List<int> horas = new List<int>();

            String sql = "SELECT EstudianteTarea.hReales FROM EstudianteTarea INNER JOIN TareaGenerica ON EstudianteTarea.codTarea = TareaGenerica.codigo WHERE (EstudianteTarea.codTarea = TareaGenerica.codigo AND TareaGenerica.codAsig = @asign)";
            SqlCommand sqlCmd = new SqlCommand(sql, connection);
            sqlCmd.Parameters.AddWithValue("@asign", asign);

            using (SqlDataReader reader = sqlCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    horas.Add(Int32.Parse(string.Format("{0}", reader["hReales"])));
                }
            }

            return horas;
        }
    }
}
