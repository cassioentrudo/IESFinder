namespace IESFinder
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textDadoSelecionado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gmapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparPesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarArquivoBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDadoSelecionado
            // 
            this.textDadoSelecionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDadoSelecionado.Location = new System.Drawing.Point(3, 16);
            this.textDadoSelecionado.Multiline = true;
            this.textDadoSelecionado.Name = "textDadoSelecionado";
            this.textDadoSelecionado.ReadOnly = true;
            this.textDadoSelecionado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDadoSelecionado.Size = new System.Drawing.Size(516, 361);
            this.textDadoSelecionado.TabIndex = 114;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.buttonRemove);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridViewResult);
            this.groupBox2.Controls.Add(this.buttonOrdenar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 553);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado da busca";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(732, 184);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 117;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(732, 213);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 116;
            this.buttonNew.Text = "Novo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(732, 242);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 115;
            this.buttonRemove.Text = "Remover";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // button1
            // 
            this.button1.Image = global::IESFinder.Properties.Resources.cima;
            this.button1.Location = new System.Drawing.Point(732, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 49);
            this.button1.TabIndex = 111;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToOrderColumns = true;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(723, 518);
            this.dataGridViewResult.TabIndex = 105;
            this.dataGridViewResult.SelectionChanged += new System.EventHandler(this.dataGridViewResult_SelectionChanged);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Image = global::IESFinder.Properties.Resources.baixo;
            this.buttonOrdenar.Location = new System.Drawing.Point(732, 71);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(43, 49);
            this.buttonOrdenar.TabIndex = 108;
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdemCrescente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gmapControl);
            this.groupBox3.Controls.Add(this.textDadoSelecionado);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 553);
            this.groupBox3.TabIndex = 115;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item selecionado";
            // 
            // gmapControl
            // 
            this.gmapControl.Bearing = 0F;
            this.gmapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gmapControl.CanDragMap = true;
            this.gmapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapControl.GrayScaleMode = false;
            this.gmapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapControl.LevelsKeepInMemmory = 5;
            this.gmapControl.Location = new System.Drawing.Point(3, 377);
            this.gmapControl.MarkersEnabled = true;
            this.gmapControl.MaxZoom = 18;
            this.gmapControl.MinZoom = 2;
            this.gmapControl.MouseWheelZoomEnabled = true;
            this.gmapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapControl.Name = "gmapControl";
            this.gmapControl.NegativeMode = false;
            this.gmapControl.PolygonsEnabled = true;
            this.gmapControl.RetryLoadTile = 0;
            this.gmapControl.RoutesEnabled = true;
            this.gmapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapControl.ShowTileGridLines = false;
            this.gmapControl.Size = new System.Drawing.Size(516, 173);
            this.gmapControl.TabIndex = 115;
            this.gmapControl.Zoom = 13D;
            this.gmapControl.Load += new System.EventHandler(this.gmapControl_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(839, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 553);
            this.panel1.TabIndex = 116;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 553);
            this.panel2.TabIndex = 117;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxSearch);
            this.panel3.Controls.Add(this.buttonFind);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1361, 117);
            this.panel3.TabIndex = 9;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.label4);
            this.groupBoxSearch.Controls.Add(this.textBoxUF);
            this.groupBoxSearch.Controls.Add(this.textBoxRegion);
            this.groupBoxSearch.Controls.Add(this.label3);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxName);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 37);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(645, 74);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UF";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(542, 41);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(39, 20);
            this.textBoxUF.TabIndex = 6;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(401, 41);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(75, 20);
            this.textBoxRegion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Região";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da IES";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(316, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(663, 49);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(69, 62);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Buscar";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1361, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparPesquisaToolStripMenuItem,
            this.limparArquivoToolStripMenuItem,
            this.gerarArquivoBinToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // limparPesquisaToolStripMenuItem
            // 
            this.limparPesquisaToolStripMenuItem.Name = "limparPesquisaToolStripMenuItem";
            this.limparPesquisaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.limparPesquisaToolStripMenuItem.Text = "Limpar Pesquisa";
            this.limparPesquisaToolStripMenuItem.Click += new System.EventHandler(this.limparPesquisaToolStripMenuItem_Click);
            // 
            // limparArquivoToolStripMenuItem
            // 
            this.limparArquivoToolStripMenuItem.Name = "limparArquivoToolStripMenuItem";
            this.limparArquivoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.limparArquivoToolStripMenuItem.Text = "Remover arquivo Bin";
            this.limparArquivoToolStripMenuItem.Click += new System.EventHandler(this.limparArquivoToolStripMenuItem_Click);
            // 
            // gerarArquivoBinToolStripMenuItem
            // 
            this.gerarArquivoBinToolStripMenuItem.Name = "gerarArquivoBinToolStripMenuItem";
            this.gerarArquivoBinToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gerarArquivoBinToolStripMenuItem.Text = "Gerar arquivo Bin";
            this.gerarArquivoBinToolStripMenuItem.Click += new System.EventHandler(this.gerarArquivoBinToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotal,
            this.toolStripStatusLabelTotalValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1361, 22);
            this.statusStrip1.TabIndex = 118;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotal
            // 
            this.toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            this.toolStripStatusLabelTotal.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelTotal.Text = "Total: ";
            // 
            // toolStripStatusLabelTotalValue
            // 
            this.toolStripStatusLabelTotalValue.Name = "toolStripStatusLabelTotalValue";
            this.toolStripStatusLabelTotalValue.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelTotalValue.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "IES Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.TextBox textDadoSelecionado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private GMap.NET.WindowsForms.GMapControl gmapControl;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolStripMenuItem limparPesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarArquivoBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

