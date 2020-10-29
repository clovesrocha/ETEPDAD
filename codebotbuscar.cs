/* 
ETE PD - AD 
PROFESSOR: CLOVES ROCHA 
CRUD EM C# - Código do botão buscar 
*/

private void tsbBuscar_Click(object sender, EventArgs e)
 {
     string sql = "SELECT * FROM CLIENTE WHERE ID=" + tstId.Text;

     SqlConnection con = new SqlConnection(connectionString);
     SqlCommand cmd = new SqlCommand(sql, con);
     cmd.CommandType = CommandType.Text;
     SqlDataReader reader;
     con.Open();

     try
     {
         reader = cmd.ExecuteReader();
         if (reader.Read())
         {
             tsbNovo.Enabled = false;
             tsbSalvar.Enabled = true;
             tsbCancelar.Enabled = true;
             tsbExcluir.Enabled = true;
             tstId.Enabled = false;
             tsbBuscar.Enabled = false;
             txtNome.Enabled = true;
             txtEndereco.Enabled = true;
             mskCep.Enabled = true;
             txtBairro.Enabled = true;
             txtCidade.Enabled = true;
             txtUf.Enabled = true;
             mskTelefone.Enabled = true;
             txtNome.Focus();
             txtId.Text = reader[0].ToString();
             txtNome.Text = reader[1].ToString();
             txtEndereco.Text = reader[2].ToString();
             mskCep.Text = reader[3].ToString();
             txtBairro.Text = reader[4].ToString();
             txtCidade.Text = reader[5].ToString();
             txtUf.Text = reader[6].ToString();
             mskTelefone.Text = reader[7].ToString();
             novo = false;
         }
         else
             MessageBox.Show("Nenhum registro encontrado com o Id
             informado!");

     }
     catch (Exception ex)
     {
         MessageBox.Show("Erro: " + ex.ToString());
     }
     finally
     {
         con.Close();
     }

     tstId.Text = "";

 }
