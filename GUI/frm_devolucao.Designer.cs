namespace GUI
{
    partial class frm_devolucao
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.dgvfilmelOCACAO = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarLoc = new Guna.UI.WinForms.GunaButton();
            this.cboxSituacaopag = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel36 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtIdFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnDevolver = new Guna.UI.WinForms.GunaButton();
            this.txt_VlPagoDevolucao = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_vlMultaDevolucao = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_vlTotalDevolucao = new Guna.UI.WinForms.GunaTextBox();
            this.btn_RegistrarDevolucao = new Guna.UI.WinForms.GunaButton();
            this.btn_Buscar_Item = new Guna.UI.WinForms.GunaButton();
            this.txt_locacao = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel29 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CodBarrasDevolucao = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel31 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dtDevolu = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilmelOCACAO)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.gunaElipsePanel1.Controls.Add(this.dtDevolu);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel5);
            this.gunaElipsePanel1.Controls.Add(this.dgvfilmelOCACAO);
            this.gunaElipsePanel1.Controls.Add(this.btnBuscarLoc);
            this.gunaElipsePanel1.Controls.Add(this.cboxSituacaopag);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel36);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel1.Controls.Add(this.txtIdFilme);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Controls.Add(this.btnDevolver);
            this.gunaElipsePanel1.Controls.Add(this.txt_VlPagoDevolucao);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Controls.Add(this.txt_vlMultaDevolucao);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.txt_vlTotalDevolucao);
            this.gunaElipsePanel1.Controls.Add(this.btn_RegistrarDevolucao);
            this.gunaElipsePanel1.Controls.Add(this.btn_Buscar_Item);
            this.gunaElipsePanel1.Controls.Add(this.txt_locacao);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel29);
            this.gunaElipsePanel1.Controls.Add(this.txt_CodBarrasDevolucao);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel31);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1396, 1085);
            this.gunaElipsePanel1.TabIndex = 38;
            // 
            // dgvfilmelOCACAO
            // 
            this.dgvfilmelOCACAO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvfilmelOCACAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfilmelOCACAO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodBarras,
            this.Titulo});
            this.dgvfilmelOCACAO.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvfilmelOCACAO.Location = new System.Drawing.Point(642, 288);
            this.dgvfilmelOCACAO.Name = "dgvfilmelOCACAO";
            this.dgvfilmelOCACAO.RowHeadersWidth = 51;
            this.dgvfilmelOCACAO.RowTemplate.Height = 24;
            this.dgvfilmelOCACAO.Size = new System.Drawing.Size(329, 267);
            this.dgvfilmelOCACAO.TabIndex = 59;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_Filme";
            this.Id.HeaderText = "ID Filme";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // CodBarras
            // 
            this.CodBarras.DataPropertyName = "codBarras";
            this.CodBarras.HeaderText = "Cod. Barras";
            this.CodBarras.MinimumWidth = 6;
            this.CodBarras.Name = "CodBarras";
            this.CodBarras.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // btnBuscarLoc
            // 
            this.btnBuscarLoc.AnimationHoverSpeed = 0.07F;
            this.btnBuscarLoc.AnimationSpeed = 0.03F;
            this.btnBuscarLoc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnBuscarLoc.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarLoc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarLoc.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnBuscarLoc.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLoc.Image = null;
            this.btnBuscarLoc.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarLoc.Location = new System.Drawing.Point(316, 250);
            this.btnBuscarLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLoc.Name = "btnBuscarLoc";
            this.btnBuscarLoc.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnBuscarLoc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarLoc.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarLoc.OnHoverImage = null;
            this.btnBuscarLoc.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarLoc.Size = new System.Drawing.Size(100, 42);
            this.btnBuscarLoc.TabIndex = 57;
            this.btnBuscarLoc.Text = "Buscar";
            this.btnBuscarLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarLoc.Click += new System.EventHandler(this.btnBuscarLoc_Click);
            // 
            // cboxSituacaopag
            // 
            this.cboxSituacaopag.BackColor = System.Drawing.Color.Transparent;
            this.cboxSituacaopag.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cboxSituacaopag.BorderColor = System.Drawing.Color.Silver;
            this.cboxSituacaopag.BorderSize = 0;
            this.cboxSituacaopag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSituacaopag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSituacaopag.FocusedColor = System.Drawing.Color.Empty;
            this.cboxSituacaopag.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxSituacaopag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.cboxSituacaopag.FormattingEnabled = true;
            this.cboxSituacaopag.Items.AddRange(new object[] {
            "Pago",
            "Pago Parcial",
            "Pagar na devolução"});
            this.cboxSituacaopag.Location = new System.Drawing.Point(466, 458);
            this.cboxSituacaopag.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSituacaopag.Name = "cboxSituacaopag";
            this.cboxSituacaopag.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.cboxSituacaopag.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cboxSituacaopag.Size = new System.Drawing.Size(137, 31);
            this.cboxSituacaopag.TabIndex = 56;
            // 
            // gunaLabel36
            // 
            this.gunaLabel36.AutoSize = true;
            this.gunaLabel36.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel36.Location = new System.Drawing.Point(308, 462);
            this.gunaLabel36.Name = "gunaLabel36";
            this.gunaLabel36.Size = new System.Drawing.Size(150, 23);
            this.gunaLabel36.TabIndex = 55;
            this.gunaLabel36.Text = "St. de pagamento:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel4.Location = new System.Drawing.Point(72, 329);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(74, 23);
            this.gunaLabel4.TabIndex = 51;
            this.gunaLabel4.Text = "Vl. Total:";
            // 
            // txtIdFilme
            // 
            this.txtIdFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtIdFilme.BorderColor = System.Drawing.Color.Silver;
            this.txtIdFilme.BorderSize = 0;
            this.txtIdFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtIdFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txtIdFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtIdFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txtIdFilme.Location = new System.Drawing.Point(588, 117);
            this.txtIdFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFilme.Name = "txtIdFilme";
            this.txtIdFilme.PasswordChar = '\0';
            this.txtIdFilme.Size = new System.Drawing.Size(80, 41);
            this.txtIdFilme.TabIndex = 50;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel3.Location = new System.Drawing.Point(549, 126);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(31, 23);
            this.gunaLabel3.TabIndex = 49;
            this.gunaLabel3.Text = "ID:";
            // 
            // btnDevolver
            // 
            this.btnDevolver.AnimationHoverSpeed = 0.07F;
            this.btnDevolver.AnimationSpeed = 0.03F;
            this.btnDevolver.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnDevolver.BorderColor = System.Drawing.Color.Black;
            this.btnDevolver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDevolver.FocusedColor = System.Drawing.Color.Empty;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Image = null;
            this.btnDevolver.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDevolver.Location = new System.Drawing.Point(697, 174);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnDevolver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDevolver.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDevolver.OnHoverImage = null;
            this.btnDevolver.OnPressedColor = System.Drawing.Color.Black;
            this.btnDevolver.Size = new System.Drawing.Size(221, 42);
            this.btnDevolver.TabIndex = 48;
            this.btnDevolver.Text = "Devolver Filme";
            this.btnDevolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // txt_VlPagoDevolucao
            // 
            this.txt_VlPagoDevolucao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_VlPagoDevolucao.BorderColor = System.Drawing.Color.Silver;
            this.txt_VlPagoDevolucao.BorderSize = 0;
            this.txt_VlPagoDevolucao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_VlPagoDevolucao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_VlPagoDevolucao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_VlPagoDevolucao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_VlPagoDevolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_VlPagoDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_VlPagoDevolucao.Location = new System.Drawing.Point(185, 452);
            this.txt_VlPagoDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VlPagoDevolucao.Name = "txt_VlPagoDevolucao";
            this.txt_VlPagoDevolucao.PasswordChar = '\0';
            this.txt_VlPagoDevolucao.Size = new System.Drawing.Size(99, 41);
            this.txt_VlPagoDevolucao.TabIndex = 47;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel1.Location = new System.Drawing.Point(72, 461);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel1.TabIndex = 46;
            this.gunaLabel1.Text = "Vl. Pago:";
            // 
            // txt_vlMultaDevolucao
            // 
            this.txt_vlMultaDevolucao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_vlMultaDevolucao.BorderColor = System.Drawing.Color.Silver;
            this.txt_vlMultaDevolucao.BorderSize = 0;
            this.txt_vlMultaDevolucao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vlMultaDevolucao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_vlMultaDevolucao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_vlMultaDevolucao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_vlMultaDevolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_vlMultaDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_vlMultaDevolucao.Location = new System.Drawing.Point(185, 388);
            this.txt_vlMultaDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vlMultaDevolucao.Name = "txt_vlMultaDevolucao";
            this.txt_vlMultaDevolucao.PasswordChar = '\0';
            this.txt_vlMultaDevolucao.Size = new System.Drawing.Size(99, 41);
            this.txt_vlMultaDevolucao.TabIndex = 45;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel2.Location = new System.Drawing.Point(72, 397);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(83, 23);
            this.gunaLabel2.TabIndex = 44;
            this.gunaLabel2.Text = "Vl. Multa:";
            // 
            // txt_vlTotalDevolucao
            // 
            this.txt_vlTotalDevolucao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_vlTotalDevolucao.BorderColor = System.Drawing.Color.Silver;
            this.txt_vlTotalDevolucao.BorderSize = 0;
            this.txt_vlTotalDevolucao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vlTotalDevolucao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_vlTotalDevolucao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_vlTotalDevolucao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_vlTotalDevolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_vlTotalDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_vlTotalDevolucao.Location = new System.Drawing.Point(185, 320);
            this.txt_vlTotalDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vlTotalDevolucao.Name = "txt_vlTotalDevolucao";
            this.txt_vlTotalDevolucao.PasswordChar = '\0';
            this.txt_vlTotalDevolucao.Size = new System.Drawing.Size(99, 41);
            this.txt_vlTotalDevolucao.TabIndex = 43;
            // 
            // btn_RegistrarDevolucao
            // 
            this.btn_RegistrarDevolucao.AnimationHoverSpeed = 0.07F;
            this.btn_RegistrarDevolucao.AnimationSpeed = 0.03F;
            this.btn_RegistrarDevolucao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_RegistrarDevolucao.BorderColor = System.Drawing.Color.Black;
            this.btn_RegistrarDevolucao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_RegistrarDevolucao.FocusedColor = System.Drawing.Color.Empty;
            this.btn_RegistrarDevolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_RegistrarDevolucao.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarDevolucao.Image = null;
            this.btn_RegistrarDevolucao.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_RegistrarDevolucao.Location = new System.Drawing.Point(185, 513);
            this.btn_RegistrarDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RegistrarDevolucao.Name = "btn_RegistrarDevolucao";
            this.btn_RegistrarDevolucao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_RegistrarDevolucao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_RegistrarDevolucao.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_RegistrarDevolucao.OnHoverImage = null;
            this.btn_RegistrarDevolucao.OnPressedColor = System.Drawing.Color.Black;
            this.btn_RegistrarDevolucao.Size = new System.Drawing.Size(247, 42);
            this.btn_RegistrarDevolucao.TabIndex = 30;
            this.btn_RegistrarDevolucao.Text = "Registrar Devolucão";
            this.btn_RegistrarDevolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_RegistrarDevolucao.Click += new System.EventHandler(this.btn_RegistrarDevolucao_Click);
            // 
            // btn_Buscar_Item
            // 
            this.btn_Buscar_Item.AnimationHoverSpeed = 0.07F;
            this.btn_Buscar_Item.AnimationSpeed = 0.03F;
            this.btn_Buscar_Item.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_Buscar_Item.BorderColor = System.Drawing.Color.Black;
            this.btn_Buscar_Item.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Buscar_Item.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Buscar_Item.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_Buscar_Item.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar_Item.Image = null;
            this.btn_Buscar_Item.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Buscar_Item.Location = new System.Drawing.Point(697, 116);
            this.btn_Buscar_Item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar_Item.Name = "btn_Buscar_Item";
            this.btn_Buscar_Item.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_Buscar_Item.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Buscar_Item.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Buscar_Item.OnHoverImage = null;
            this.btn_Buscar_Item.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Buscar_Item.Size = new System.Drawing.Size(221, 42);
            this.btn_Buscar_Item.TabIndex = 28;
            this.btn_Buscar_Item.Text = "Buscar p/ Cod. Barras";
            this.btn_Buscar_Item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Buscar_Item.Click += new System.EventHandler(this.btn_Buscar_Item_Click);
            // 
            // txt_locacao
            // 
            this.txt_locacao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_locacao.BorderColor = System.Drawing.Color.Silver;
            this.txt_locacao.BorderSize = 0;
            this.txt_locacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_locacao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_locacao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_locacao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_locacao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_locacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_locacao.Location = new System.Drawing.Point(185, 251);
            this.txt_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_locacao.Name = "txt_locacao";
            this.txt_locacao.PasswordChar = '\0';
            this.txt_locacao.Size = new System.Drawing.Size(99, 41);
            this.txt_locacao.TabIndex = 5;
            // 
            // gunaLabel29
            // 
            this.gunaLabel29.AutoSize = true;
            this.gunaLabel29.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel29.Location = new System.Drawing.Point(72, 260);
            this.gunaLabel29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel29.Name = "gunaLabel29";
            this.gunaLabel29.Size = new System.Drawing.Size(98, 23);
            this.gunaLabel29.TabIndex = 4;
            this.gunaLabel29.Text = "ID Locacão:";
            // 
            // txt_CodBarrasDevolucao
            // 
            this.txt_CodBarrasDevolucao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodBarrasDevolucao.BorderColor = System.Drawing.Color.Silver;
            this.txt_CodBarrasDevolucao.BorderSize = 0;
            this.txt_CodBarrasDevolucao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CodBarrasDevolucao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodBarrasDevolucao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CodBarrasDevolucao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodBarrasDevolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CodBarrasDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodBarrasDevolucao.Location = new System.Drawing.Point(185, 117);
            this.txt_CodBarrasDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodBarrasDevolucao.Name = "txt_CodBarrasDevolucao";
            this.txt_CodBarrasDevolucao.PasswordChar = '\0';
            this.txt_CodBarrasDevolucao.Size = new System.Drawing.Size(342, 41);
            this.txt_CodBarrasDevolucao.TabIndex = 1;
            // 
            // gunaLabel31
            // 
            this.gunaLabel31.AutoSize = true;
            this.gunaLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel31.Location = new System.Drawing.Point(72, 126);
            this.gunaLabel31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel31.Name = "gunaLabel31";
            this.gunaLabel31.Size = new System.Drawing.Size(101, 23);
            this.gunaLabel31.TabIndex = 0;
            this.gunaLabel31.Text = "Cod. Barras:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel5.Location = new System.Drawing.Point(566, 236);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(122, 23);
            this.gunaLabel5.TabIndex = 60;
            this.gunaLabel5.Text = "Dt. Devolução:";
            // 
            // dtDevolu
            // 
            this.dtDevolu.BaseColor = System.Drawing.Color.White;
            this.dtDevolu.BorderColor = System.Drawing.Color.Silver;
            this.dtDevolu.CustomFormat = null;
            this.dtDevolu.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDevolu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtDevolu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDevolu.ForeColor = System.Drawing.Color.Black;
            this.dtDevolu.Location = new System.Drawing.Point(695, 233);
            this.dtDevolu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDevolu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDevolu.Name = "dtDevolu";
            this.dtDevolu.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtDevolu.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtDevolu.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtDevolu.OnPressedColor = System.Drawing.Color.Black;
            this.dtDevolu.Size = new System.Drawing.Size(223, 30);
            this.dtDevolu.TabIndex = 61;
            this.dtDevolu.Text = "segunda-feira, 18 de novembro de 2019";
            this.dtDevolu.Value = new System.DateTime(2019, 11, 18, 10, 56, 39, 647);
            // 
            // frm_devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1085);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_devolucao";
            this.Text = "frm_devolucao";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilmelOCACAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton btn_RegistrarDevolucao;
        private Guna.UI.WinForms.GunaButton btn_Buscar_Item;
        private Guna.UI.WinForms.GunaTextBox txt_locacao;
        private Guna.UI.WinForms.GunaLabel gunaLabel29;
        private Guna.UI.WinForms.GunaTextBox txt_CodBarrasDevolucao;
        private Guna.UI.WinForms.GunaLabel gunaLabel31;
        private Guna.UI.WinForms.GunaTextBox txt_vlMultaDevolucao;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_vlTotalDevolucao;
        private Guna.UI.WinForms.GunaTextBox txt_VlPagoDevolucao;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnDevolver;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtIdFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cboxSituacaopag;
        private Guna.UI.WinForms.GunaLabel gunaLabel36;
        private Guna.UI.WinForms.GunaButton btnBuscarLoc;
        private System.Windows.Forms.DataGridView dgvfilmelOCACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDateTimePicker dtDevolu;
    }
}