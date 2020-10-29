/* 
ETE PD - AD 
PROFESSOR: CLOVES ROCHA 
CRUD EM C# - Código do botão Excluir
*/

private void tsbExcluir_Click(object sender, EventArgs e)
{

    string sql = "DELETE FROM CLIENTE WHERE ID=" + txtId.Text;

    SqlConnection con = new SqlConnection(connectionString);
    SqlCommand cmd = new SqlCommand(sql, con);
    cmd.CommandType = CommandType.Text;
    con.Open();

    try
    {
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            MessageBox.Show("Registro excluído com sucesso!");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erro: " + ex.ToString());
    }
    finally
    {
        con.Close();
    }

    tsbNovo.Enabled = true;
    tsbSalvar.Enabled = false;
    tsbCancelar.Enabled = false;
    tsbExcluir.Enabled = false;
    tstId.Enabled = true;
    tsbBuscar.Enabled = true;
    txtNome.Enabled = false;
    txtEndereco.Enabled = false;
    mskCep.Enabled = false;
    txtBairro.Enabled = false;
    txtCidade.Enabled = false;
    txtUf.Enabled = false;
    mskTelefone.Enabled = false;
    txtId.Text = "";
    txtNome.Text = "";
    txtEndereco.Text = "";
    mskCep.Text = "";
    txtBairro.Text = "";
    txtCidade.Text = "";
    txtUf.Text = "";
    mskTelefone.Text = "";

}
