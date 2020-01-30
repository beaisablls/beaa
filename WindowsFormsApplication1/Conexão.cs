using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    class Conexão
    {
        private String dadosCon = @"SERVER=LAB604-3;database=dentibao;INTEGRATED SECURITY= TRUE;";
        private SqlConnection SqlCon;
        public void conectar()
        {
            SqlCon = new SqlConnection(dadosCon);
            try
            {
                SqlCon.Open();
                Console.WriteLine("conectado");
            }
            catch (SqlException sqlE)
            {
                Console.WriteLine("ERROR:" + sqlE);
            }
        }
        public void desconectar()
        {
            SqlCon.Close();
        }
        public int executar(String sql)
        {
            SqlCommand sqlC = new SqlCommand(sql, SqlCon);
            return sqlC.ExecuteNonQuery();
        }
        public SqlDataReader EXEconsulta(String sql)
        {
            SqlCommand sqlC = new SqlCommand(sql, SqlCon);
            return sqlC.ExecuteReader();
        }
    }
}
   