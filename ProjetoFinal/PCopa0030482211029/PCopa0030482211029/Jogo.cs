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
    class Jogo
    {
        public int Id { get; set; }

        public int EstadioId { get; set; }

        public int PaisId1 { get; set; }

        public int PaisId2 { get; set; }

        public DateTime Datahora { get; set; }

        public string Observacao { get; set; }

        // métodos
        // listar, adicionar, alterar, excluir

        public DataTable Listar()
        {
            SqlDataAdapter daJogo;
            DataTable dtJogo = new DataTable();
            try
            {
                daJogo = new SqlDataAdapter("SELECT * FROM JOGO",
                    frmPrincipal.conexao);
                daJogo.Fill(dtJogo);
                daJogo.FillSchema(dtJogo, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtJogo;
        }

        public int Excluir() // EXCLUSÃO
        {
            int nReg = 0;

            try
            { 
                 SqlCommand mycommand; 

                 mycommand = new SqlCommand("DELETE FROM JOGO WHERE ID=@id",
                     frmPrincipal.conexao); 

                 mycommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)); 
                 mycommand.Parameters["@id"].Value = Id; 

                 nReg = mycommand.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Salvar() // INCLUSÃO
        { 
            int retorno = 0; 

            try
            { 
                SqlCommand mycommand; 

                int nReg = 0; 

                mycommand = new SqlCommand("INSERT INTO JOGO VALUES (@pais1," + 
                    "@pais2,@estadio,@datahora,@observacao)",
                    frmPrincipal.conexao); 

                mycommand.Parameters.Add(new SqlParameter("@pais1", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@pais2", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@estadio", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@datahora", SqlDbType.Date));
                mycommand.Parameters.Add(new SqlParameter("@observacao", SqlDbType.VarChar));

                mycommand.Parameters["@pais1"].Value = PaisId1;
                mycommand.Parameters["@pais2"].Value = PaisId2;
                mycommand.Parameters["@estadio"].Value = EstadioId;
                mycommand.Parameters["@datahora"].Value = Datahora;
                mycommand.Parameters["@observacao"].Value = Observacao;

                retorno = mycommand.ExecuteNonQuery(); 

                if (nReg > 0) 
                { 
                    retorno = nReg; 
                } 
            } 

            catch (Exception) 
            { 
                throw; 
            } 

            return retorno; 
        }

        public int Alterar() // alteração
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                int nReg = 0;

                mycommand = new SqlCommand("UPDATE JOGO SET ESTADIO_ID=@estadio," +
                    "PAIS_ID=@pais1, PAIS_ID2=@pais2, DATAHORA=@datahora, OBSERVACAO=@observacao WHERE ID = @id",
                    frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@pais1", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@pais2", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@estadio", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@datahora", SqlDbType.Date));
                mycommand.Parameters.Add(new SqlParameter("@observacao", SqlDbType.VarChar));

                mycommand.Parameters["@id"].Value = Id;
                mycommand.Parameters["@pais1"].Value = PaisId1;
                mycommand.Parameters["@pais2"].Value = PaisId2;
                mycommand.Parameters["@estadio"].Value = EstadioId;
                mycommand.Parameters["@datahora"].Value = Datahora;
                mycommand.Parameters["@observacao"].Value = Observacao;

                retorno = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }

            catch (Exception)
            {
                throw;
            }

            return retorno;
        } 

    }
}
