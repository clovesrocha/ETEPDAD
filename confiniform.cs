/* 
ETE PD - AD 
PROFESSOR: CLOVES ROCHA 
CRUD EM C# - Configuração inicial do formulário 
*/

private void frmCadastroCliente_Load(object sender, EventArgs e)
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
}
