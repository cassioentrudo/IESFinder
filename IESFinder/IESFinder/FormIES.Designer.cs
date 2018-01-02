namespace IESFinder
{
    partial class FormIES
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
            this.dataGridViewIes = new System.Windows.Forms.DataGridView();
            this.ColumnCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIes)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewIes
            // 
            this.dataGridViewIes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCampo,
            this.ColumnInfo});
            this.dataGridViewIes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIes.Name = "dataGridViewIes";
            this.dataGridViewIes.Size = new System.Drawing.Size(567, 480);
            this.dataGridViewIes.TabIndex = 0;
            // 
            // ColumnCampo
            // 
            this.ColumnCampo.HeaderText = "Campo";
            this.ColumnCampo.Name = "ColumnCampo";
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.HeaderText = "Info";
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.Width = 400;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(567, 49);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 480);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(567, 49);
            this.panelButtons.TabIndex = 3;
            // 
            // FormIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 529);
            this.Controls.Add(this.dataGridViewIes);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormIES";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIes)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
    }
}