/* 
ETE PD - AD 
PROFESSOR: CLOVES ROCHA 
CRUD EM C# - Código do botão cancelar 
*/

private void tsbCancelar_Click(object sender, EventArgs e)
{
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
