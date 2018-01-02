using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IESFinder
{
    public partial class FormIES : Form
    {
        private IES ies = null;

        private bool isEdit = false;

        public FormIES(IES ies, bool isEdit)
        {
            InitializeComponent();

            this.ies = ies;
            this.isEdit = isEdit;
        }

        private void FormIES_Load(object sender, EventArgs e)
        {
            List<string> listProperties = Utils.PropertyList(ies);

            int i = 0;
            foreach (var propertieName in listProperties)
            {
                this.dataGridViewIes.Rows.Add();
                this.dataGridViewIes.Rows[i].Cells[0].Value = propertieName;
                i++;
            }

            if (this.isEdit)
            {
                buttonSave.Text = "Atualizar";

                i = 0;

                this.dataGridViewIes.Rows[i].Cells[1].Value =   this.ies.CO_ANO;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.CO_IES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NO_IES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.SG_IES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NU_CNPJ;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.REGIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.REGIAOIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.COUFIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NOMEUFIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.SIGLA;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.MUNICIPIOIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.COMUNICIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.COMUNICIES12;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.LOCIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.LOCALIES;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.ORG;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NOMEORG;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.COREDE;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.REDE;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.CO_DEP;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.DEPADM;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.DEP5;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.DEPADM5;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.MANT;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.MANTENEDORA;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NU_CEP;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.DS_ENDERECO;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.DS_NUMERO_ENDERECO;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.DS_COMPLEMENTO_ENDERECO;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NO_BAIRRO;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NU_TELEFONE;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NU_FAX;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.TX_EMAIL;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.TX_PAGINA_ELETRONICA;
               // this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NO_PROCURADOR_INTITUCIONAL;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NU_CPF_PROCURADOR;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NU_TELEFONE_PROCURADOR;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.TX_EMAIL_PROCURADOR;
                this.dataGridViewIes.Rows[++i].Cells[1].Value = this.ies.NIES;
            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                int co_ano = 0;
                int co_ies = 0;

                int.TryParse(this.dataGridViewIes.Rows[i].Cells[1].Value.ToString(), out co_ano);
                int.TryParse(this.dataGridViewIes.Rows[++i].Cells[1].Value.ToString(), out co_ies);

                this.ies.CO_ANO = co_ano;
                this.ies.CO_IES = co_ies;

                i++;
                this.ies.NO_IES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.SG_IES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NU_CNPJ = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.REGIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.REGIAOIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.COUFIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NOMEUFIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.SIGLA = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.MUNICIPIOIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.COMUNICIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.COMUNICIES12 = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.LOCIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.LOCALIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.ORG = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NOMEORG = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.COREDE = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.REDE = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.CO_DEP = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.DEPADM = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.DEP5 = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.DEPADM5 = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.MANT = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.MANTENEDORA = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NU_CEP = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.DS_ENDERECO = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.DS_NUMERO_ENDERECO = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.DS_COMPLEMENTO_ENDERECO = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NO_BAIRRO = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NU_TELEFONE = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NU_FAX = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.TX_EMAIL = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.TX_PAGINA_ELETRONICA = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                //this.ies.NO_PROCURADOR_INTITUCIONAL = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                //i++;
                this.ies.NU_CPF_PROCURADOR = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NU_TELEFONE_PROCURADOR = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.TX_EMAIL_PROCURADOR = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;
                this.ies.NIES = this.dataGridViewIes.Rows[i].Cells[1].Value == null ? string.Empty : this.dataGridViewIes.Rows[i].Cells[1].Value.ToString();
                i++;

                DadosIES dados = new DadosIES();
                dados.CO_IES = this.ies.CO_IES;
                dados.ies = this.ies;

                bool ret = false;

                if (isEdit)
                    ret = FileHelper.Atualiza(dados);
                else
                    ret = FileHelper.Adiciona(dados);

                MessageBox.Show("Ação realizada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a ação desejada.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
