using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace ConnectionMySQL
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; Database=COMERCIO; Password=caroli@#db1597");
            MySqlCommand comando = new MySqlCommand ("SELECT * FROM CLIENTE", conexao);
            DataTable Cliente = new DataTable();
            try
            {
                conexao.Open(); 
                gdvDados.DataSource = comando.ExecuteReader();
                gdvDados.DataBind();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
