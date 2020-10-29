/* 
ETE PD - AD 
PROFESSOR: CLOVES ROCHA 
CRUD EM C# - Código do botão Novo 
*/

private void tsbNovo_Click(object sender, EventArgs e)
{
    tsbNovo.Enabled = false;
    tsbSalvar.Enabled = true;
    tsbCancelar.Enabled = true;
    tsbExcluir.Enabled = false;
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
    novo = true;

}
