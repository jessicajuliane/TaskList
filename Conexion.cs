using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using TaskList.Models;

namespace WebApplication1.App_Data
{
    public class Conexion
    {

        private Tasks tasks;

        protected void AdicionarTask(object sender, EventArgs e)
        {
            //definição da string de conexão
            SqlConnection conn = new SqlConnection(@"Data Source=CEPEDI-
                AF2B68DC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            //definição do comando sql'
            string sql = "INSERT INTO Tasks(titulo, status, descricao)" +
                "VALUES(@titulo, @status, @descricao)";


            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@titulo", this.txtNome.Text));
                comando.Parameters.Add(new SqlParameter("@status", this.txtEndereco.Text));
                comando.Parameters.Add(new SqlParameter("@descricao", this.txtNumero.Text));
                //abre a conexao
                conn.Open();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();
                //Minha função para limpar os textBox
                LimpaCamos();
                //Abaixo temos a ultlização de javascript para apresentar ao usuário um alert
                // referente ao msgbox
                RegisterClientScriptBlock("cadastrado", "< script > alert(Operação concluida !) </ script > ");
            }
            catch
            {
                RegisterClientScriptBlock("naoCadastrado", "< script > alert(Operação não concluida !) </ script > ");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LimpaCamos()
        {
            this..txtNome.Text = "";
            this..txtEndereco.Text = "";
            this.txtNumero.Text = "";
            this.txtRG.Text = "";

        }
    }
}