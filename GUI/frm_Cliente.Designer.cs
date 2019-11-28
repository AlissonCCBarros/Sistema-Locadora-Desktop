namespace GUI
{
    partial class frm_Cliente
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
            this.dgvLocacoes = new System.Windows.Forms.DataGridView();
            this.NomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Estado = new Guna.UI.WinForms.GunaComboBox();
            this.txt_EstadoCivil = new Guna.UI.WinForms.GunaComboBox();
            this.gvCliente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_BuscarPorCpf = new Guna.UI.WinForms.GunaButton();
            this.txt_statusCliente = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel17 = new Guna.UI.WinForms.GunaLabel();
            this.btn_BuscarCliente = new Guna.UI.WinForms.GunaButton();
            this.btn_excluirCliente = new Guna.UI.WinForms.GunaButton();
            this.btn_AtualizarCliente = new Guna.UI.WinForms.GunaButton();
            this.btn_InserirCliente = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CelularCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel19 = new Guna.UI.WinForms.GunaLabel();
            this.txt_emailCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel20 = new Guna.UI.WinForms.GunaLabel();
            this.txt_telefoneCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel21 = new Guna.UI.WinForms.GunaLabel();
            this.txt_sexoCliente = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel22 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CidadeCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel23 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CepCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel24 = new Guna.UI.WinForms.GunaLabel();
            this.txt_EnderecoCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel25 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CpfCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel26 = new Guna.UI.WinForms.GunaLabel();
            this.txt_RgCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel27 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel28 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DtNascimentoCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel29 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CodigoCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel30 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nomeCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel31 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.gunaElipsePanel1.Controls.Add(this.dgvLocacoes);
            this.gunaElipsePanel1.Controls.Add(this.txt_Estado);
            this.gunaElipsePanel1.Controls.Add(this.txt_EstadoCivil);
            this.gunaElipsePanel1.Controls.Add(this.gvCliente);
            this.gunaElipsePanel1.Controls.Add(this.btn_BuscarPorCpf);
            this.gunaElipsePanel1.Controls.Add(this.txt_statusCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel17);
            this.gunaElipsePanel1.Controls.Add(this.btn_BuscarCliente);
            this.gunaElipsePanel1.Controls.Add(this.btn_excluirCliente);
            this.gunaElipsePanel1.Controls.Add(this.btn_AtualizarCliente);
            this.gunaElipsePanel1.Controls.Add(this.btn_InserirCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel18);
            this.gunaElipsePanel1.Controls.Add(this.txt_CelularCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel19);
            this.gunaElipsePanel1.Controls.Add(this.txt_emailCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel20);
            this.gunaElipsePanel1.Controls.Add(this.txt_telefoneCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel21);
            this.gunaElipsePanel1.Controls.Add(this.txt_sexoCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel22);
            this.gunaElipsePanel1.Controls.Add(this.txt_CidadeCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel23);
            this.gunaElipsePanel1.Controls.Add(this.txt_CepCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel24);
            this.gunaElipsePanel1.Controls.Add(this.txt_EnderecoCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel25);
            this.gunaElipsePanel1.Controls.Add(this.txt_CpfCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel26);
            this.gunaElipsePanel1.Controls.Add(this.txt_RgCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel27);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel28);
            this.gunaElipsePanel1.Controls.Add(this.txt_DtNascimentoCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel29);
            this.gunaElipsePanel1.Controls.Add(this.txt_CodigoCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel30);
            this.gunaElipsePanel1.Controls.Add(this.txt_nomeCliente);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel31);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1072, 860);
            this.gunaElipsePanel1.TabIndex = 37;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // dgvLocacoes
            // 
            this.dgvLocacoes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCli,
            this.Dt_Atual,
            this.VlPago,
            this.dt_devo,
            this.Dt_prev});
            this.dgvLocacoes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLocacoes.Location = new System.Drawing.Point(574, 620);
            this.dgvLocacoes.Name = "dgvLocacoes";
            this.dgvLocacoes.RowHeadersWidth = 51;
            this.dgvLocacoes.RowTemplate.Height = 24;
            this.dgvLocacoes.Size = new System.Drawing.Size(483, 154);
            this.dgvLocacoes.TabIndex = 41;
            // 
            // NomeCli
            // 
            this.NomeCli.DataPropertyName = "NomeCli";
            this.NomeCli.HeaderText = "Nome do Cliente";
            this.NomeCli.MinimumWidth = 6;
            this.NomeCli.Name = "NomeCli";
            this.NomeCli.Width = 125;
            // 
            // Dt_Atual
            // 
            this.Dt_Atual.DataPropertyName = "Dt_Atual";
            this.Dt_Atual.HeaderText = "Data da Locação";
            this.Dt_Atual.MinimumWidth = 6;
            this.Dt_Atual.Name = "Dt_Atual";
            this.Dt_Atual.Width = 125;
            // 
            // VlPago
            // 
            this.VlPago.DataPropertyName = "Vl_Pago";
            this.VlPago.HeaderText = "Valor Pago";
            this.VlPago.MinimumWidth = 6;
            this.VlPago.Name = "VlPago";
            this.VlPago.Width = 125;
            // 
            // dt_devo
            // 
            this.dt_devo.DataPropertyName = "Dt_Devolucao";
            this.dt_devo.HeaderText = "Data de Devolução";
            this.dt_devo.MinimumWidth = 6;
            this.dt_devo.Name = "dt_devo";
            this.dt_devo.Width = 125;
            // 
            // Dt_prev
            // 
            this.Dt_prev.DataPropertyName = "Dt_Prevista";
            this.Dt_prev.HeaderText = "Dt. Devolução Prevista";
            this.Dt_prev.MinimumWidth = 6;
            this.Dt_prev.Name = "Dt_prev";
            this.Dt_prev.Width = 125;
            // 
            // txt_Estado
            // 
            this.txt_Estado.BackColor = System.Drawing.Color.Transparent;
            this.txt_Estado.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_Estado.BorderColor = System.Drawing.Color.Silver;
            this.txt_Estado.BorderSize = 0;
            this.txt_Estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Estado.FocusedColor = System.Drawing.Color.Empty;
            this.txt_Estado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_Estado.FormattingEnabled = true;
            this.txt_Estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txt_Estado.Location = new System.Drawing.Point(549, 365);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.txt_Estado.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_Estado.Size = new System.Drawing.Size(122, 31);
            this.txt_Estado.TabIndex = 40;
            // 
            // txt_EstadoCivil
            // 
            this.txt_EstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.txt_EstadoCivil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_EstadoCivil.BorderColor = System.Drawing.Color.Silver;
            this.txt_EstadoCivil.BorderSize = 0;
            this.txt_EstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_EstadoCivil.FocusedColor = System.Drawing.Color.Empty;
            this.txt_EstadoCivil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_EstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_EstadoCivil.FormattingEnabled = true;
            this.txt_EstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)"});
            this.txt_EstadoCivil.Location = new System.Drawing.Point(223, 214);
            this.txt_EstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EstadoCivil.Name = "txt_EstadoCivil";
            this.txt_EstadoCivil.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.txt_EstadoCivil.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_EstadoCivil.Size = new System.Drawing.Size(235, 31);
            this.txt_EstadoCivil.TabIndex = 39;
            // 
            // gvCliente
            // 
            this.gvCliente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Status});
            this.gvCliente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvCliente.Location = new System.Drawing.Point(73, 620);
            this.gvCliente.Name = "gvCliente";
            this.gvCliente.RowHeadersWidth = 51;
            this.gvCliente.RowTemplate.Height = 24;
            this.gvCliente.Size = new System.Drawing.Size(483, 154);
            this.gvCliente.TabIndex = 38;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Codigo";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 140;
            // 
            // btn_BuscarPorCpf
            // 
            this.btn_BuscarPorCpf.AnimationHoverSpeed = 0.07F;
            this.btn_BuscarPorCpf.AnimationSpeed = 0.03F;
            this.btn_BuscarPorCpf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarPorCpf.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarPorCpf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BuscarPorCpf.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BuscarPorCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_BuscarPorCpf.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarPorCpf.Image = null;
            this.btn_BuscarPorCpf.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BuscarPorCpf.Location = new System.Drawing.Point(679, 255);
            this.btn_BuscarPorCpf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarPorCpf.Name = "btn_BuscarPorCpf";
            this.btn_BuscarPorCpf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarPorCpf.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarPorCpf.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarPorCpf.OnHoverImage = null;
            this.btn_BuscarPorCpf.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarPorCpf.Size = new System.Drawing.Size(148, 42);
            this.btn_BuscarPorCpf.TabIndex = 37;
            this.btn_BuscarPorCpf.Text = "Buscar Por CPF";
            this.btn_BuscarPorCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarPorCpf.Click += new System.EventHandler(this.btn_BuscarPorCpf_Click);
            // 
            // txt_statusCliente
            // 
            this.txt_statusCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_statusCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_statusCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_statusCliente.BorderSize = 0;
            this.txt_statusCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_statusCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_statusCliente.FocusedColor = System.Drawing.Color.Empty;
            this.txt_statusCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_statusCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_statusCliente.FormattingEnabled = true;
            this.txt_statusCliente.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txt_statusCliente.Location = new System.Drawing.Point(631, 473);
            this.txt_statusCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_statusCliente.Name = "txt_statusCliente";
            this.txt_statusCliente.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.txt_statusCliente.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_statusCliente.Size = new System.Drawing.Size(96, 31);
            this.txt_statusCliente.TabIndex = 35;
            // 
            // gunaLabel17
            // 
            this.gunaLabel17.AutoSize = true;
            this.gunaLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel17.Location = new System.Drawing.Point(562, 477);
            this.gunaLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel17.Name = "gunaLabel17";
            this.gunaLabel17.Size = new System.Drawing.Size(61, 23);
            this.gunaLabel17.TabIndex = 34;
            this.gunaLabel17.Text = "Status:";
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.AnimationHoverSpeed = 0.07F;
            this.btn_BuscarCliente.AnimationSpeed = 0.03F;
            this.btn_BuscarCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarCliente.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BuscarCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BuscarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_BuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarCliente.Image = null;
            this.btn_BuscarCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BuscarCliente.Location = new System.Drawing.Point(866, 112);
            this.btn_BuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarCliente.OnHoverImage = null;
            this.btn_BuscarCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarCliente.Size = new System.Drawing.Size(100, 42);
            this.btn_BuscarCliente.TabIndex = 32;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // btn_excluirCliente
            // 
            this.btn_excluirCliente.AnimationHoverSpeed = 0.07F;
            this.btn_excluirCliente.AnimationSpeed = 0.03F;
            this.btn_excluirCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluirCliente.BorderColor = System.Drawing.Color.Black;
            this.btn_excluirCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_excluirCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btn_excluirCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_excluirCliente.ForeColor = System.Drawing.Color.White;
            this.btn_excluirCliente.Image = null;
            this.btn_excluirCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_excluirCliente.Location = new System.Drawing.Point(430, 543);
            this.btn_excluirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluirCliente.Name = "btn_excluirCliente";
            this.btn_excluirCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluirCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_excluirCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_excluirCliente.OnHoverImage = null;
            this.btn_excluirCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btn_excluirCliente.Size = new System.Drawing.Size(235, 42);
            this.btn_excluirCliente.TabIndex = 30;
            this.btn_excluirCliente.Text = "Excluir";
            this.btn_excluirCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_excluirCliente.Click += new System.EventHandler(this.btn_excluirCliente_Click);
            // 
            // btn_AtualizarCliente
            // 
            this.btn_AtualizarCliente.AnimationHoverSpeed = 0.07F;
            this.btn_AtualizarCliente.AnimationSpeed = 0.03F;
            this.btn_AtualizarCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_AtualizarCliente.BorderColor = System.Drawing.Color.Black;
            this.btn_AtualizarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AtualizarCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AtualizarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_AtualizarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_AtualizarCliente.Image = null;
            this.btn_AtualizarCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AtualizarCliente.Location = new System.Drawing.Point(698, 543);
            this.btn_AtualizarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AtualizarCliente.Name = "btn_AtualizarCliente";
            this.btn_AtualizarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_AtualizarCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_AtualizarCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AtualizarCliente.OnHoverImage = null;
            this.btn_AtualizarCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AtualizarCliente.Size = new System.Drawing.Size(221, 42);
            this.btn_AtualizarCliente.TabIndex = 29;
            this.btn_AtualizarCliente.Text = "Atualizar";
            this.btn_AtualizarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AtualizarCliente.Click += new System.EventHandler(this.btn_AtualizarCliente_Click);
            // 
            // btn_InserirCliente
            // 
            this.btn_InserirCliente.AnimationHoverSpeed = 0.07F;
            this.btn_InserirCliente.AnimationSpeed = 0.03F;
            this.btn_InserirCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_InserirCliente.BorderColor = System.Drawing.Color.Black;
            this.btn_InserirCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_InserirCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btn_InserirCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_InserirCliente.ForeColor = System.Drawing.Color.White;
            this.btn_InserirCliente.Image = null;
            this.btn_InserirCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_InserirCliente.Location = new System.Drawing.Point(186, 543);
            this.btn_InserirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_InserirCliente.Name = "btn_InserirCliente";
            this.btn_InserirCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_InserirCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_InserirCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_InserirCliente.OnHoverImage = null;
            this.btn_InserirCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btn_InserirCliente.Size = new System.Drawing.Size(221, 42);
            this.btn_InserirCliente.TabIndex = 28;
            this.btn_InserirCliente.Text = "Inserir";
            this.btn_InserirCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_InserirCliente.Click += new System.EventHandler(this.btn_InserirCliente_Click);
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel18.Location = new System.Drawing.Point(476, 422);
            this.gunaLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(68, 23);
            this.gunaLabel18.TabIndex = 27;
            this.gunaLabel18.Text = "Celular:";
            // 
            // txt_CelularCliente
            // 
            this.txt_CelularCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CelularCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_CelularCliente.BorderSize = 0;
            this.txt_CelularCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CelularCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CelularCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CelularCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CelularCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CelularCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CelularCliente.Location = new System.Drawing.Point(552, 413);
            this.txt_CelularCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CelularCliente.Name = "txt_CelularCliente";
            this.txt_CelularCliente.PasswordChar = '\0';
            this.txt_CelularCliente.Size = new System.Drawing.Size(175, 41);
            this.txt_CelularCliente.TabIndex = 26;
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel19.Location = new System.Drawing.Point(117, 477);
            this.gunaLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(62, 23);
            this.gunaLabel19.TabIndex = 25;
            this.gunaLabel19.Text = "E-mail:";
            // 
            // txt_emailCliente
            // 
            this.txt_emailCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_emailCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_emailCliente.BorderSize = 0;
            this.txt_emailCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emailCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_emailCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_emailCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_emailCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_emailCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_emailCliente.Location = new System.Drawing.Point(206, 468);
            this.txt_emailCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emailCliente.Name = "txt_emailCliente";
            this.txt_emailCliente.PasswordChar = '\0';
            this.txt_emailCliente.Size = new System.Drawing.Size(348, 41);
            this.txt_emailCliente.TabIndex = 24;
            // 
            // gunaLabel20
            // 
            this.gunaLabel20.AutoSize = true;
            this.gunaLabel20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel20.Location = new System.Drawing.Point(112, 422);
            this.gunaLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel20.Name = "gunaLabel20";
            this.gunaLabel20.Size = new System.Drawing.Size(78, 23);
            this.gunaLabel20.TabIndex = 23;
            this.gunaLabel20.Text = "Telefone:";
            // 
            // txt_telefoneCliente
            // 
            this.txt_telefoneCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_telefoneCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_telefoneCliente.BorderSize = 0;
            this.txt_telefoneCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telefoneCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_telefoneCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_telefoneCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_telefoneCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_telefoneCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_telefoneCliente.Location = new System.Drawing.Point(206, 413);
            this.txt_telefoneCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefoneCliente.Name = "txt_telefoneCliente";
            this.txt_telefoneCliente.PasswordChar = '\0';
            this.txt_telefoneCliente.Size = new System.Drawing.Size(252, 41);
            this.txt_telefoneCliente.TabIndex = 22;
            // 
            // gunaLabel21
            // 
            this.gunaLabel21.AutoSize = true;
            this.gunaLabel21.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel21.Location = new System.Drawing.Point(476, 368);
            this.gunaLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel21.Name = "gunaLabel21";
            this.gunaLabel21.Size = new System.Drawing.Size(65, 23);
            this.gunaLabel21.TabIndex = 21;
            this.gunaLabel21.Text = "Estado:";
            // 
            // txt_sexoCliente
            // 
            this.txt_sexoCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_sexoCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_sexoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_sexoCliente.BorderSize = 0;
            this.txt_sexoCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_sexoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sexoCliente.FocusedColor = System.Drawing.Color.Empty;
            this.txt_sexoCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_sexoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_sexoCliente.FormattingEnabled = true;
            this.txt_sexoCliente.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txt_sexoCliente.Location = new System.Drawing.Point(535, 168);
            this.txt_sexoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sexoCliente.Name = "txt_sexoCliente";
            this.txt_sexoCliente.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.txt_sexoCliente.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_sexoCliente.Size = new System.Drawing.Size(136, 31);
            this.txt_sexoCliente.TabIndex = 20;
            // 
            // gunaLabel22
            // 
            this.gunaLabel22.AutoSize = true;
            this.gunaLabel22.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel22.Location = new System.Drawing.Point(112, 368);
            this.gunaLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel22.Name = "gunaLabel22";
            this.gunaLabel22.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel22.TabIndex = 18;
            this.gunaLabel22.Text = "Cidade:";
            // 
            // txt_CidadeCliente
            // 
            this.txt_CidadeCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CidadeCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_CidadeCliente.BorderSize = 0;
            this.txt_CidadeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CidadeCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CidadeCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CidadeCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CidadeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CidadeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CidadeCliente.Location = new System.Drawing.Point(206, 359);
            this.txt_CidadeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CidadeCliente.Name = "txt_CidadeCliente";
            this.txt_CidadeCliente.PasswordChar = '\0';
            this.txt_CidadeCliente.Size = new System.Drawing.Size(252, 41);
            this.txt_CidadeCliente.TabIndex = 17;
            // 
            // gunaLabel23
            // 
            this.gunaLabel23.AutoSize = true;
            this.gunaLabel23.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel23.Location = new System.Drawing.Point(473, 314);
            this.gunaLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel23.Name = "gunaLabel23";
            this.gunaLabel23.Size = new System.Drawing.Size(44, 23);
            this.gunaLabel23.TabIndex = 16;
            this.gunaLabel23.Text = "CEP:";
            // 
            // txt_CepCliente
            // 
            this.txt_CepCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CepCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_CepCliente.BorderSize = 0;
            this.txt_CepCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CepCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CepCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CepCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CepCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CepCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CepCliente.Location = new System.Drawing.Point(525, 305);
            this.txt_CepCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CepCliente.Name = "txt_CepCliente";
            this.txt_CepCliente.PasswordChar = '\0';
            this.txt_CepCliente.Size = new System.Drawing.Size(146, 41);
            this.txt_CepCliente.TabIndex = 15;
            // 
            // gunaLabel24
            // 
            this.gunaLabel24.AutoSize = true;
            this.gunaLabel24.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel24.Location = new System.Drawing.Point(112, 314);
            this.gunaLabel24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel24.Name = "gunaLabel24";
            this.gunaLabel24.Size = new System.Drawing.Size(82, 23);
            this.gunaLabel24.TabIndex = 14;
            this.gunaLabel24.Text = "Esdereco:";
            // 
            // txt_EnderecoCliente
            // 
            this.txt_EnderecoCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_EnderecoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_EnderecoCliente.BorderSize = 0;
            this.txt_EnderecoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EnderecoCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_EnderecoCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_EnderecoCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_EnderecoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_EnderecoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_EnderecoCliente.Location = new System.Drawing.Point(206, 305);
            this.txt_EnderecoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EnderecoCliente.Name = "txt_EnderecoCliente";
            this.txt_EnderecoCliente.PasswordChar = '\0';
            this.txt_EnderecoCliente.Size = new System.Drawing.Size(252, 41);
            this.txt_EnderecoCliente.TabIndex = 13;
            // 
            // gunaLabel25
            // 
            this.gunaLabel25.AutoSize = true;
            this.gunaLabel25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel25.Location = new System.Drawing.Point(376, 265);
            this.gunaLabel25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel25.Name = "gunaLabel25";
            this.gunaLabel25.Size = new System.Drawing.Size(44, 23);
            this.gunaLabel25.TabIndex = 12;
            this.gunaLabel25.Text = "CPF:";
            // 
            // txt_CpfCliente
            // 
            this.txt_CpfCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CpfCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_CpfCliente.BorderSize = 0;
            this.txt_CpfCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CpfCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CpfCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CpfCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CpfCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CpfCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CpfCliente.Location = new System.Drawing.Point(428, 256);
            this.txt_CpfCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CpfCliente.Name = "txt_CpfCliente";
            this.txt_CpfCliente.PasswordChar = '\0';
            this.txt_CpfCliente.Size = new System.Drawing.Size(243, 41);
            this.txt_CpfCliente.TabIndex = 11;
            // 
            // gunaLabel26
            // 
            this.gunaLabel26.AutoSize = true;
            this.gunaLabel26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel26.Location = new System.Drawing.Point(112, 265);
            this.gunaLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel26.Name = "gunaLabel26";
            this.gunaLabel26.Size = new System.Drawing.Size(37, 23);
            this.gunaLabel26.TabIndex = 10;
            this.gunaLabel26.Text = "RG:";
            // 
            // txt_RgCliente
            // 
            this.txt_RgCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_RgCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_RgCliente.BorderSize = 0;
            this.txt_RgCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RgCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_RgCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_RgCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_RgCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_RgCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_RgCliente.Location = new System.Drawing.Point(157, 256);
            this.txt_RgCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RgCliente.Name = "txt_RgCliente";
            this.txt_RgCliente.PasswordChar = '\0';
            this.txt_RgCliente.Size = new System.Drawing.Size(211, 41);
            this.txt_RgCliente.TabIndex = 9;
            // 
            // gunaLabel27
            // 
            this.gunaLabel27.AutoSize = true;
            this.gunaLabel27.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel27.Location = new System.Drawing.Point(107, 218);
            this.gunaLabel27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel27.Name = "gunaLabel27";
            this.gunaLabel27.Size = new System.Drawing.Size(102, 23);
            this.gunaLabel27.TabIndex = 8;
            this.gunaLabel27.Text = "Estado Civil:";
            // 
            // gunaLabel28
            // 
            this.gunaLabel28.AutoSize = true;
            this.gunaLabel28.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel28.Location = new System.Drawing.Point(476, 172);
            this.gunaLabel28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel28.Name = "gunaLabel28";
            this.gunaLabel28.Size = new System.Drawing.Size(51, 23);
            this.gunaLabel28.TabIndex = 6;
            this.gunaLabel28.Text = "Sexo:";
            this.gunaLabel28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_DtNascimentoCliente
            // 
            this.txt_DtNascimentoCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_DtNascimentoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_DtNascimentoCliente.BorderSize = 0;
            this.txt_DtNascimentoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DtNascimentoCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_DtNascimentoCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DtNascimentoCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_DtNascimentoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_DtNascimentoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_DtNascimentoCliente.Location = new System.Drawing.Point(245, 163);
            this.txt_DtNascimentoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DtNascimentoCliente.Name = "txt_DtNascimentoCliente";
            this.txt_DtNascimentoCliente.PasswordChar = '\0';
            this.txt_DtNascimentoCliente.Size = new System.Drawing.Size(213, 41);
            this.txt_DtNascimentoCliente.TabIndex = 5;
            // 
            // gunaLabel29
            // 
            this.gunaLabel29.AutoSize = true;
            this.gunaLabel29.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel29.Location = new System.Drawing.Point(105, 172);
            this.gunaLabel29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel29.Name = "gunaLabel29";
            this.gunaLabel29.Size = new System.Drawing.Size(132, 23);
            this.gunaLabel29.TabIndex = 4;
            this.gunaLabel29.Text = "Dt. Nascimento:";
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodigoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_CodigoCliente.BorderSize = 0;
            this.txt_CodigoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CodigoCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodigoCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CodigoCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodigoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodigoCliente.Location = new System.Drawing.Point(759, 113);
            this.txt_CodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.PasswordChar = '\0';
            this.txt_CodigoCliente.Size = new System.Drawing.Size(79, 41);
            this.txt_CodigoCliente.TabIndex = 3;
            // 
            // gunaLabel30
            // 
            this.gunaLabel30.AutoSize = true;
            this.gunaLabel30.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel30.Location = new System.Drawing.Point(720, 122);
            this.gunaLabel30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel30.Name = "gunaLabel30";
            this.gunaLabel30.Size = new System.Drawing.Size(31, 23);
            this.gunaLabel30.TabIndex = 2;
            this.gunaLabel30.Text = "ID:";
            // 
            // txt_nomeCliente
            // 
            this.txt_nomeCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_nomeCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_nomeCliente.BorderSize = 0;
            this.txt_nomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nomeCliente.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_nomeCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_nomeCliente.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_nomeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_nomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_nomeCliente.Location = new System.Drawing.Point(174, 113);
            this.txt_nomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeCliente.Name = "txt_nomeCliente";
            this.txt_nomeCliente.PasswordChar = '\0';
            this.txt_nomeCliente.Size = new System.Drawing.Size(497, 41);
            this.txt_nomeCliente.TabIndex = 1;
            // 
            // gunaLabel31
            // 
            this.gunaLabel31.AutoSize = true;
            this.gunaLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel31.Location = new System.Drawing.Point(105, 122);
            this.gunaLabel31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel31.Name = "gunaLabel31";
            this.gunaLabel31.Size = new System.Drawing.Size(61, 23);
            this.gunaLabel31.TabIndex = 0;
            this.gunaLabel31.Text = "Nome:";
            // 
            // frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Cliente";
            this.Text = "frm_Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaComboBox txt_statusCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel17;
        private Guna.UI.WinForms.GunaButton btn_BuscarCliente;
        private Guna.UI.WinForms.GunaButton btn_excluirCliente;
        private Guna.UI.WinForms.GunaButton btn_AtualizarCliente;
        private Guna.UI.WinForms.GunaButton btn_InserirCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaTextBox txt_CelularCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel19;
        private Guna.UI.WinForms.GunaTextBox txt_emailCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel20;
        private Guna.UI.WinForms.GunaTextBox txt_telefoneCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel21;
        private Guna.UI.WinForms.GunaComboBox txt_sexoCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel22;
        private Guna.UI.WinForms.GunaTextBox txt_CidadeCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel23;
        private Guna.UI.WinForms.GunaTextBox txt_CepCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel24;
        private Guna.UI.WinForms.GunaTextBox txt_EnderecoCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel25;
        private Guna.UI.WinForms.GunaTextBox txt_CpfCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel26;
        private Guna.UI.WinForms.GunaTextBox txt_RgCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel27;
        private Guna.UI.WinForms.GunaLabel gunaLabel28;
        private Guna.UI.WinForms.GunaTextBox txt_DtNascimentoCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel29;
        private Guna.UI.WinForms.GunaTextBox txt_CodigoCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel30;
        private Guna.UI.WinForms.GunaTextBox txt_nomeCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel31;
        private Guna.UI.WinForms.GunaButton btn_BuscarPorCpf;
        private System.Windows.Forms.DataGridView gvCliente;
        private Guna.UI.WinForms.GunaComboBox txt_EstadoCivil;
        private Guna.UI.WinForms.GunaComboBox txt_Estado;
        private System.Windows.Forms.DataGridView dgvLocacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}