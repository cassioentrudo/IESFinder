using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace IESFinder
{
    public partial class FormMain : Form
    {
        private List<DadosIES> currentList = new List<DadosIES>();

        public FormMain()
        {
            InitializeComponent();

            //Cria a grid com as colunas que serão exibidas
            Dictionary<string, int> columns = new Dictionary<string, int>();
            columns.Add(nameof(IES.CO_IES), 50);
            columns.Add(nameof(IES.NO_IES), 400);
            columns.Add(nameof(IES.SG_IES), 80);
            columns.Add(nameof(IES.REGIAOIES), 80);
            columns.Add(nameof(IES.SIGLA), 50);

            foreach (var item in columns)
            {
                DataGridViewColumn column = new DataGridViewColumn();

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                column.DefaultCellStyle = cellStyle;

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                column.CellTemplate = cell;

                column.HeaderText = item.Key.ToString();
                column.Width = item.Value;

                this.dataGridViewResult.Columns.Add(column);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictSearch = new Dictionary<string, string>();

            string iesName = this.textBoxName.Text;
            string iesRegion = this.textBoxRegion.Text;
            string iesUF = this.textBoxUF.Text;

            if (!string.IsNullOrEmpty(iesRegion))
                SearchIES(iesRegion, nameof(IES.REGIAOIES));
            else if (!string.IsNullOrEmpty(iesUF))
                SearchIES(iesUF, nameof(IES.SIGLA));
            else
                SearchIES(iesName, nameof(IES.NO_IES));
        }

        private void SearchIES(string valor, string criterio)
        {
            List<DadosIES> list = FileHelper.Search(valor, criterio);

            this.currentList = list;
            this.UpdateGrid(list);           
        }

        private void UpdateGrid(List<DadosIES> list)
        {
            this.dataGridViewResult.Rows.Clear();

            foreach (var dado in list)
            {
                this.dataGridViewResult.Rows.Add(dado.ies.CO_IES, dado.ies.NO_IES, dado.ies.SG_IES, dado.ies.REGIAOIES, dado.ies.SIGLA);
            }

            this.toolStripStatusLabelTotalValue.Text = list.Count.ToString();
        }

        private void UpdateIESInfo(DadosIES dados)
        {
            if (dados != null)
            {
                StringBuilder fullString = new StringBuilder();

                fullString.Append(nameof(IES.CO_ANO) + ": " + dados.ies.CO_ANO + "\r\n");
                fullString.Append(nameof(IES.CO_IES) + ": " + dados.ies.CO_IES + "\r\n");
                fullString.Append(nameof(IES.NO_IES) + ": " + dados.ies.NO_IES + "\r\n");
                fullString.Append(nameof(IES.SG_IES) + ": " + dados.ies.SG_IES + "\r\n");
                fullString.Append(nameof(IES.NU_CNPJ) + ": " + dados.ies.NU_CNPJ + "\r\n");
                fullString.Append(nameof(IES.REGIES) + ": " + dados.ies.REGIES + "\r\n");
                fullString.Append(nameof(IES.REGIAOIES) + ": " + dados.ies.REGIAOIES + "\r\n");
                fullString.Append(nameof(IES.COUFIES) + ": " + dados.ies.COUFIES + "\r\n");
                fullString.Append(nameof(IES.NOMEUFIES) + ": " + dados.ies.NOMEUFIES + "\r\n");
                fullString.Append(nameof(IES.SIGLA) + ": " + dados.ies.SIGLA + "\r\n");
                fullString.Append(nameof(IES.MUNICIPIOIES) + ": " + dados.ies.MUNICIPIOIES + "\r\n");
                fullString.Append(nameof(IES.COMUNICIES) + ": " + dados.ies.COMUNICIES + "\r\n");
                fullString.Append(nameof(IES.COMUNICIES12) + ": " + dados.ies.COMUNICIES12 + "\r\n");
                fullString.Append(nameof(IES.LOCIES) + ": " + dados.ies.LOCIES + "\r\n");
                fullString.Append(nameof(IES.LOCALIES) + ": " + dados.ies.LOCALIES + "\r\n");
                fullString.Append(nameof(IES.ORG) + ": " + dados.ies.ORG + "\r\n");
                fullString.Append(nameof(IES.NOMEORG) + ": " + dados.ies.NOMEORG + "\r\n");
                fullString.Append(nameof(IES.COREDE) + ": " + dados.ies.COREDE + "\r\n");
                fullString.Append(nameof(IES.REDE) + ": " + dados.ies.REDE + "\r\n");
                fullString.Append(nameof(IES.CO_DEP) + ": " + dados.ies.CO_DEP + "\r\n");
                fullString.Append(nameof(IES.DEPADM) + ": " + dados.ies.DEPADM + "\r\n");
                fullString.Append(nameof(IES.DEP5) + ": " + dados.ies.DEP5 + "\r\n");
                fullString.Append(nameof(IES.DEPADM5) + ": " + dados.ies.DEPADM5 + "\r\n");
                fullString.Append(nameof(IES.MANT) + ": " + dados.ies.MANT + "\r\n");
                fullString.Append(nameof(IES.MANTENEDORA) + ": " + dados.ies.MANTENEDORA + "\r\n");
                fullString.Append(nameof(IES.NU_CEP) + ": " + dados.ies.NU_CEP + "\r\n");
                fullString.Append(nameof(IES.DS_ENDERECO) + ": " + dados.ies.DS_ENDERECO + "\r\n");
                fullString.Append(nameof(IES.DS_NUMERO_ENDERECO) + ": " + dados.ies.DS_NUMERO_ENDERECO + "\r\n");
                fullString.Append(nameof(IES.DS_COMPLEMENTO_ENDERECO) + ": " + dados.ies.DS_COMPLEMENTO_ENDERECO + "\r\n");
                fullString.Append(nameof(IES.NO_BAIRRO) + ": " + dados.ies.NO_BAIRRO + "\r\n");
                fullString.Append(nameof(IES.NU_TELEFONE) + ": " + dados.ies.NU_TELEFONE + "\r\n");
                fullString.Append(nameof(IES.NU_FAX) + ": " + dados.ies.NU_FAX + "\r\n");
                fullString.Append(nameof(IES.TX_EMAIL) + ": " + dados.ies.TX_EMAIL + "\r\n");
                fullString.Append(nameof(IES.TX_PAGINA_ELETRONICA) + ": " + dados.ies.TX_PAGINA_ELETRONICA + "\r\n");
                fullString.Append(nameof(IES.NO_PROCURADOR_INTITUCIONAL) + ": " + dados.ies.NO_PROCURADOR_INTITUCIONAL + "\r\n");
                fullString.Append(nameof(IES.NU_CPF_PROCURADOR) + ": " + dados.ies.NU_CPF_PROCURADOR + "\r\n");
                fullString.Append(nameof(IES.NU_TELEFONE_PROCURADOR) + ": " + dados.ies.NU_TELEFONE_PROCURADOR + "\r\n");
                fullString.Append(nameof(IES.TX_EMAIL_PROCURADOR) + ": " + dados.ies.TX_EMAIL_PROCURADOR+ "\r\n");
                fullString.Append(nameof(IES.NIES) + ": " + dados.ies.NIES + "\r\n");


                this.textDadoSelecionado.Text = fullString.ToString();

                gmapControl.SetPositionByKeywords(dados.ies.MUNICIPIOIES);
                gmapControl.Visible = true;
            }
            else
            {
                this.textDadoSelecionado.Text = string.Empty;
            }
        }

        private void buttonOrdemCrescente_Click(object sender, EventArgs e)
        {
            this.currentList = OrdenaDados.QSRM_Nome(this.currentList, true);
            UpdateGrid(this.currentList);
        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            int index = this.dataGridViewResult.CurrentCell.RowIndex;
            DadosIES dados = null;

            if (index != -1)
            {
                if (this.currentList.Count > 0 && index < this.currentList.Count)
                {
                    dados = this.currentList[index];
                }

                this.UpdateIESInfo(dados);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = this.dataGridViewResult.CurrentCell.RowIndex;

                if (index != -1 && this.currentList.Count > 0)
                {
                    DadosIES dado = this.currentList[index];
                    bool ret = FileHelper.Remove(dado.CO_IES);

                    if (ret)
                    {
                        MessageBox.Show("IES removida com sucess0.", "" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonFind_Click(null, null);
                    }
                }
            }
            catch (Exception)
            { 
                MessageBox.Show("Não foi possível remover a IES selecionada.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gmapControl_Load(object sender, EventArgs e)
        {
            gmapControl.DisableFocusOnMouseEnter = true;
            gmapControl.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmapControl.ShowCenter = false;
            gmapControl.Visible = false;
        }

        private void limparPesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBoxSearch.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }
        }

        private void limparArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHelper.RemoveBinFile();
        }

        private void gerarArquivoBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHelper.LerCSV();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FileHelper.LerCSV();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            IES ies = new IES();
            FormIES formIes = new FormIES(ies, false);
            formIes.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewResult.CurrentCell != null)
            {
                int index = this.dataGridViewResult.CurrentCell.RowIndex;

                if (index != -1 && this.currentList.Count > 0)
                {
                    DadosIES dado = this.currentList[index];

                    FormIES formIes = new FormIES(dado.ies, true);
                    formIes.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentList = OrdenaDados.QSRM_Nome(this.currentList, false);
            UpdateGrid(this.currentList);
        }
    }
}
