using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PCopa0030482211029
{
    class Pais
    {
        // propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daPais;
            DataTable dtPais = new DataTable();
            try
            {
                daPais = new SqlDataAdapter("SELECT * FROM PAIS ORDER BY NOME",
                    frmPrincipal.conexao);
                daPais.Fill(dtPais);
                daPais.FillSchema(dtPais, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtPais;
        } 
    }
}
