namespace GUI
{
    partial class frm_Funcionario
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
            this.Ep_Funcionarios = new Guna.UI.WinForms.GunaElipsePanel();
            this.dgvLocPen = new System.Windows.Forms.DataGridView();
            this.NomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFunc = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Estado = new Guna.UI.WinForms.GunaComboBox();
            this.txt_estadocivil = new Guna.UI.WinForms.GunaComboBox();
            this.btn_BuscarCPF = new Guna.UI.WinForms.GunaButton();
            this.txt_status = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.btn_excluir = new Guna.UI.WinForms.GunaButton();
            this.btn_atualiarFuncionario = new Guna.UI.WinForms.GunaButton();
            this.btn_InserirFuncionario = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CelularFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.txt_emailFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txt_TelefoneFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.cb_sexoFuncionario = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CidadeFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CepFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txt_EnderecoFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CpfFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_RgFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_dataNascimento = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CodigoFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_NomeFuncionario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.Ep_Funcionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // Ep_Funcionarios
            // 
            this.Ep_Funcionarios.BackColor = System.Drawing.Color.Transparent;
            this.Ep_Funcionarios.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.Ep_Funcionarios.Controls.Add(this.dgvLocPen);
            this.Ep_Funcionarios.Controls.Add(this.gvFunc);
            this.Ep_Funcionarios.Controls.Add(this.txt_Estado);
            this.Ep_Funcionarios.Controls.Add(this.txt_estadocivil);
            this.Ep_Funcionarios.Controls.Add(this.btn_BuscarCPF);
            this.Ep_Funcionarios.Controls.Add(this.txt_status);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel16);
            this.Ep_Funcionarios.Controls.Add(this.gunaButton5);
            this.Ep_Funcionarios.Controls.Add(this.btn_excluir);
            this.Ep_Funcionarios.Controls.Add(this.btn_atualiarFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.btn_InserirFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel15);
            this.Ep_Funcionarios.Controls.Add(this.txt_CelularFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel14);
            this.Ep_Funcionarios.Controls.Add(this.txt_emailFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel13);
            this.Ep_Funcionarios.Controls.Add(this.txt_TelefoneFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel12);
            this.Ep_Funcionarios.Controls.Add(this.cb_sexoFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel11);
            this.Ep_Funcionarios.Controls.Add(this.txt_CidadeFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel10);
            this.Ep_Funcionarios.Controls.Add(this.txt_CepFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel9);
            this.Ep_Funcionarios.Controls.Add(this.txt_EnderecoFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel8);
            this.Ep_Funcionarios.Controls.Add(this.txt_CpfFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel7);
            this.Ep_Funcionarios.Controls.Add(this.txt_RgFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel6);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel5);
            this.Ep_Funcionarios.Controls.Add(this.txt_dataNascimento);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel4);
            this.Ep_Funcionarios.Controls.Add(this.txt_CodigoFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel3);
            this.Ep_Funcionarios.Controls.Add(this.txt_NomeFuncionario);
            this.Ep_Funcionarios.Controls.Add(this.gunaLabel2);
            this.Ep_Funcionarios.Location = new System.Drawing.Point(-1, -1);
            this.Ep_Funcionarios.Margin = new System.Windows.Forms.Padding(4);
            this.Ep_Funcionarios.Name = "Ep_Funcionarios";
            this.Ep_Funcionarios.Size = new System.Drawing.Size(1404, 868);
            this.Ep_Funcionarios.TabIndex = 2;
            this.Ep_Funcionarios.Paint += new System.Windows.Forms.PaintEventHandler(this.Ep_Funcionarios_Paint);
            // 
            // dgvLocPen
            // 
            this.dgvLocPen.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLocPen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocPen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCli,
            this.Titulo,
            this.Preco,
            this.Dt_Prev,
            this.DiasAtraso});
            this.dgvLocPen.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLocPen.Location = new System.Drawing.Point(561, 626);
            this.dgvLocPen.Name = "dgvLocPen";
            this.dgvLocPen.RowHeadersWidth = 51;
            this.dgvLocPen.RowTemplate.Height = 24;
            this.dgvLocPen.Size = new System.Drawing.Size(479, 154);
            this.dgvLocPen.TabIndex = 43;
            // 
            // NomeCli
            // 
            this.NomeCli.DataPropertyName = "NomeCli";
            this.NomeCli.HeaderText = "Nome do Cliente";
            this.NomeCli.MinimumWidth = 6;
            this.NomeCli.Name = "NomeCli";
            this.NomeCli.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.MinimumWidth = 6;
            this.Preco.Name = "Preco";
            this.Preco.Width = 125;
            // 
            // Dt_Prev
            // 
            this.Dt_Prev.DataPropertyName = "Dt_Prev";
            this.Dt_Prev.HeaderText = "Dt. Devolução Prevista";
            this.Dt_Prev.MinimumWidth = 6;
            this.Dt_Prev.Name = "Dt_Prev";
            this.Dt_Prev.Width = 125;
            // 
            // DiasAtraso
            // 
            this.DiasAtraso.DataPropertyName = "DiasAtraso";
            this.DiasAtraso.HeaderText = "Dias em Atraso";
            this.DiasAtraso.MinimumWidth = 6;
            this.DiasAtraso.Name = "DiasAtraso";
            this.DiasAtraso.Width = 125;
            // 
            // gvFunc
            // 
            this.gvFunc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Status});
            this.gvFunc.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvFunc.Location = new System.Drawing.Point(60, 626);
            this.gvFunc.Name = "gvFunc";
            this.gvFunc.RowHeadersWidth = 51;
            this.gvFunc.RowTemplate.Height = 24;
            this.gvFunc.Size = new System.Drawing.Size(479, 154);
            this.gvFunc.TabIndex = 42;
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
            this.Nome.HeaderText = "Nome do Funcionário";
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
            this.txt_Estado.Location = new System.Drawing.Point(546, 374);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.txt_Estado.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_Estado.Size = new System.Drawing.Size(130, 31);
            this.txt_Estado.TabIndex = 41;
            // 
            // txt_estadocivil
            // 
            this.txt_estadocivil.BackColor = System.Drawing.Color.Transparent;
            this.txt_estadocivil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_estadocivil.BorderColor = System.Drawing.Color.Silver;
            this.txt_estadocivil.BorderSize = 0;
            this.txt_estadocivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_estadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_estadocivil.FocusedColor = System.Drawing.Color.Empty;
            this.txt_estadocivil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_estadocivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_estadocivil.FormattingEnabled = true;
            this.txt_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)"});
            this.txt_estadocivil.Location = new System.Drawing.Point(247, 217);
            this.txt_estadocivil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estadocivil.Name = "txt_estadocivil";
            this.txt_estadocivil.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.txt_estadocivil.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_estadocivil.Size = new System.Drawing.Size(213, 31);
            this.txt_estadocivil.TabIndex = 40;
            // 
            // btn_BuscarCPF
            // 
            this.btn_BuscarCPF.AnimationHoverSpeed = 0.07F;
            this.btn_BuscarCPF.AnimationSpeed = 0.03F;
            this.btn_BuscarCPF.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarCPF.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarCPF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BuscarCPF.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BuscarCPF.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_BuscarCPF.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarCPF.Image = null;
            this.btn_BuscarCPF.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BuscarCPF.Location = new System.Drawing.Point(694, 262);
            this.btn_BuscarCPF.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarCPF.Name = "btn_BuscarCPF";
            this.btn_BuscarCPF.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarCPF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarCPF.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarCPF.OnHoverImage = null;
            this.btn_BuscarCPF.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarCPF.Size = new System.Drawing.Size(155, 42);
            this.btn_BuscarCPF.TabIndex = 37;
            this.btn_BuscarCPF.Text = "Buscar Por CPF";
            this.btn_BuscarCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarCPF.Click += new System.EventHandler(this.btn_BuscarCPF_Click);
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.Transparent;
            this.txt_status.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_status.BorderColor = System.Drawing.Color.Silver;
            this.txt_status.BorderSize = 0;
            this.txt_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_status.FocusedColor = System.Drawing.Color.Empty;
            this.txt_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txt_status.Location = new System.Drawing.Point(628, 484);
            this.txt_status.Margin = new System.Windows.Forms.Padding(4);
            this.txt_status.Name = "txt_status";
            this.txt_status.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_status.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_status.Size = new System.Drawing.Size(99, 31);
            this.txt_status.TabIndex = 35;
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel16.Location = new System.Drawing.Point(559, 488);
            this.gunaLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(61, 23);
            this.gunaLabel16.TabIndex = 34;
            this.gunaLabel16.Text = "Status:";
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(876, 109);
            this.gunaButton5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(100, 42);
            this.gunaButton5.TabIndex = 32;
            this.gunaButton5.Text = "Buscar";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.AnimationHoverSpeed = 0.07F;
            this.btn_excluir.AnimationSpeed = 0.03F;
            this.btn_excluir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluir.BorderColor = System.Drawing.Color.Black;
            this.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_excluir.FocusedColor = System.Drawing.Color.Empty;
            this.btn_excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Image = null;
            this.btn_excluir.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_excluir.Location = new System.Drawing.Point(428, 549);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_excluir.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_excluir.OnHoverImage = null;
            this.btn_excluir.OnPressedColor = System.Drawing.Color.Black;
            this.btn_excluir.Size = new System.Drawing.Size(235, 42);
            this.btn_excluir.TabIndex = 30;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_atualiarFuncionario
            // 
            this.btn_atualiarFuncionario.AnimationHoverSpeed = 0.07F;
            this.btn_atualiarFuncionario.AnimationSpeed = 0.03F;
            this.btn_atualiarFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_atualiarFuncionario.BorderColor = System.Drawing.Color.Black;
            this.btn_atualiarFuncionario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_atualiarFuncionario.FocusedColor = System.Drawing.Color.Empty;
            this.btn_atualiarFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_atualiarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btn_atualiarFuncionario.Image = null;
            this.btn_atualiarFuncionario.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_atualiarFuncionario.Location = new System.Drawing.Point(696, 549);
            this.btn_atualiarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualiarFuncionario.Name = "btn_atualiarFuncionario";
            this.btn_atualiarFuncionario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_atualiarFuncionario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_atualiarFuncionario.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_atualiarFuncionario.OnHoverImage = null;
            this.btn_atualiarFuncionario.OnPressedColor = System.Drawing.Color.Black;
            this.btn_atualiarFuncionario.Size = new System.Drawing.Size(221, 42);
            this.btn_atualiarFuncionario.TabIndex = 29;
            this.btn_atualiarFuncionario.Text = "Atualizar";
            this.btn_atualiarFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_atualiarFuncionario.Click += new System.EventHandler(this.btn_atualiarFuncionario_Click);
            // 
            // btn_InserirFuncionario
            // 
            this.btn_InserirFuncionario.AnimationHoverSpeed = 0.07F;
            this.btn_InserirFuncionario.AnimationSpeed = 0.03F;
            this.btn_InserirFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_InserirFuncionario.BorderColor = System.Drawing.Color.Black;
            this.btn_InserirFuncionario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_InserirFuncionario.FocusedColor = System.Drawing.Color.Empty;
            this.btn_InserirFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_InserirFuncionario.ForeColor = System.Drawing.Color.White;
            this.btn_InserirFuncionario.Image = null;
            this.btn_InserirFuncionario.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_InserirFuncionario.Location = new System.Drawing.Point(184, 549);
            this.btn_InserirFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_InserirFuncionario.Name = "btn_InserirFuncionario";
            this.btn_InserirFuncionario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_InserirFuncionario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_InserirFuncionario.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_InserirFuncionario.OnHoverImage = null;
            this.btn_InserirFuncionario.OnPressedColor = System.Drawing.Color.Black;
            this.btn_InserirFuncionario.Size = new System.Drawing.Size(221, 42);
            this.btn_InserirFuncionario.TabIndex = 28;
            this.btn_InserirFuncionario.Text = "Inserir";
            this.btn_InserirFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_InserirFuncionario.Click += new System.EventHandler(this.btn_InserirFuncionario_Click);
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel15.Location = new System.Drawing.Point(473, 428);
            this.gunaLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(68, 23);
            this.gunaLabel15.TabIndex = 27;
            this.gunaLabel15.Text = "Celular:";
            // 
            // txt_CelularFuncionario
            // 
            this.txt_CelularFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CelularFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_CelularFuncionario.BorderSize = 0;
            this.txt_CelularFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CelularFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CelularFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CelularFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CelularFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CelularFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CelularFuncionario.Location = new System.Drawing.Point(549, 419);
            this.txt_CelularFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CelularFuncionario.Name = "txt_CelularFuncionario";
            this.txt_CelularFuncionario.PasswordChar = '\0';
            this.txt_CelularFuncionario.Size = new System.Drawing.Size(178, 41);
            this.txt_CelularFuncionario.TabIndex = 26;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel14.Location = new System.Drawing.Point(110, 488);
            this.gunaLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(62, 23);
            this.gunaLabel14.TabIndex = 25;
            this.gunaLabel14.Text = "E-mail:";
            // 
            // txt_emailFuncionario
            // 
            this.txt_emailFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_emailFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_emailFuncionario.BorderSize = 0;
            this.txt_emailFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emailFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_emailFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_emailFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_emailFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_emailFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_emailFuncionario.Location = new System.Drawing.Point(204, 479);
            this.txt_emailFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emailFuncionario.Name = "txt_emailFuncionario";
            this.txt_emailFuncionario.PasswordChar = '\0';
            this.txt_emailFuncionario.Size = new System.Drawing.Size(347, 41);
            this.txt_emailFuncionario.TabIndex = 24;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel13.Location = new System.Drawing.Point(110, 428);
            this.gunaLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(78, 23);
            this.gunaLabel13.TabIndex = 23;
            this.gunaLabel13.Text = "Telefone:";
            // 
            // txt_TelefoneFuncionario
            // 
            this.txt_TelefoneFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_TelefoneFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_TelefoneFuncionario.BorderSize = 0;
            this.txt_TelefoneFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TelefoneFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_TelefoneFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TelefoneFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_TelefoneFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_TelefoneFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_TelefoneFuncionario.Location = new System.Drawing.Point(204, 419);
            this.txt_TelefoneFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TelefoneFuncionario.Name = "txt_TelefoneFuncionario";
            this.txt_TelefoneFuncionario.PasswordChar = '\0';
            this.txt_TelefoneFuncionario.Size = new System.Drawing.Size(256, 41);
            this.txt_TelefoneFuncionario.TabIndex = 22;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel12.Location = new System.Drawing.Point(473, 377);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(65, 23);
            this.gunaLabel12.TabIndex = 21;
            this.gunaLabel12.Text = "Estado:";
            // 
            // cb_sexoFuncionario
            // 
            this.cb_sexoFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.cb_sexoFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cb_sexoFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.cb_sexoFuncionario.BorderSize = 0;
            this.cb_sexoFuncionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_sexoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexoFuncionario.FocusedColor = System.Drawing.Color.Empty;
            this.cb_sexoFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_sexoFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.cb_sexoFuncionario.FormattingEnabled = true;
            this.cb_sexoFuncionario.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexoFuncionario.Location = new System.Drawing.Point(544, 165);
            this.cb_sexoFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sexoFuncionario.Name = "cb_sexoFuncionario";
            this.cb_sexoFuncionario.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.cb_sexoFuncionario.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cb_sexoFuncionario.Size = new System.Drawing.Size(132, 31);
            this.cb_sexoFuncionario.TabIndex = 20;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel11.Location = new System.Drawing.Point(109, 377);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel11.TabIndex = 18;
            this.gunaLabel11.Text = "Cidade:";
            // 
            // txt_CidadeFuncionario
            // 
            this.txt_CidadeFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CidadeFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_CidadeFuncionario.BorderSize = 0;
            this.txt_CidadeFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CidadeFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CidadeFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CidadeFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CidadeFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CidadeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CidadeFuncionario.Location = new System.Drawing.Point(204, 368);
            this.txt_CidadeFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CidadeFuncionario.Name = "txt_CidadeFuncionario";
            this.txt_CidadeFuncionario.PasswordChar = '\0';
            this.txt_CidadeFuncionario.Size = new System.Drawing.Size(256, 41);
            this.txt_CidadeFuncionario.TabIndex = 17;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel10.Location = new System.Drawing.Point(473, 321);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(44, 23);
            this.gunaLabel10.TabIndex = 16;
            this.gunaLabel10.Text = "CEP:";
            // 
            // txt_CepFuncionario
            // 
            this.txt_CepFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CepFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_CepFuncionario.BorderSize = 0;
            this.txt_CepFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CepFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CepFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CepFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CepFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CepFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CepFuncionario.Location = new System.Drawing.Point(525, 312);
            this.txt_CepFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CepFuncionario.Name = "txt_CepFuncionario";
            this.txt_CepFuncionario.PasswordChar = '\0';
            this.txt_CepFuncionario.Size = new System.Drawing.Size(151, 41);
            this.txt_CepFuncionario.TabIndex = 15;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel9.Location = new System.Drawing.Point(107, 321);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(82, 23);
            this.gunaLabel9.TabIndex = 14;
            this.gunaLabel9.Text = "Esdereco:";
            // 
            // txt_EnderecoFuncionario
            // 
            this.txt_EnderecoFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_EnderecoFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_EnderecoFuncionario.BorderSize = 0;
            this.txt_EnderecoFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EnderecoFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_EnderecoFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_EnderecoFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_EnderecoFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_EnderecoFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_EnderecoFuncionario.Location = new System.Drawing.Point(204, 312);
            this.txt_EnderecoFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EnderecoFuncionario.Name = "txt_EnderecoFuncionario";
            this.txt_EnderecoFuncionario.PasswordChar = '\0';
            this.txt_EnderecoFuncionario.Size = new System.Drawing.Size(256, 41);
            this.txt_EnderecoFuncionario.TabIndex = 13;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel8.Location = new System.Drawing.Point(405, 272);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(44, 23);
            this.gunaLabel8.TabIndex = 12;
            this.gunaLabel8.Text = "CPF:";
            // 
            // txt_CpfFuncionario
            // 
            this.txt_CpfFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CpfFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_CpfFuncionario.BorderSize = 0;
            this.txt_CpfFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CpfFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CpfFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CpfFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CpfFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CpfFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CpfFuncionario.Location = new System.Drawing.Point(457, 263);
            this.txt_CpfFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CpfFuncionario.Name = "txt_CpfFuncionario";
            this.txt_CpfFuncionario.PasswordChar = '\0';
            this.txt_CpfFuncionario.Size = new System.Drawing.Size(219, 41);
            this.txt_CpfFuncionario.TabIndex = 11;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel7.Location = new System.Drawing.Point(107, 272);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(37, 23);
            this.gunaLabel7.TabIndex = 10;
            this.gunaLabel7.Text = "RG:";
            // 
            // txt_RgFuncionario
            // 
            this.txt_RgFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_RgFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_RgFuncionario.BorderSize = 0;
            this.txt_RgFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RgFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_RgFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_RgFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_RgFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_RgFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_RgFuncionario.Location = new System.Drawing.Point(171, 263);
            this.txt_RgFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RgFuncionario.Name = "txt_RgFuncionario";
            this.txt_RgFuncionario.PasswordChar = '\0';
            this.txt_RgFuncionario.Size = new System.Drawing.Size(226, 41);
            this.txt_RgFuncionario.TabIndex = 9;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel6.Location = new System.Drawing.Point(107, 220);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(102, 23);
            this.gunaLabel6.TabIndex = 8;
            this.gunaLabel6.Text = "Estado Civil:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel5.Location = new System.Drawing.Point(485, 169);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(51, 23);
            this.gunaLabel5.TabIndex = 6;
            this.gunaLabel5.Text = "Sexo:";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_dataNascimento
            // 
            this.txt_dataNascimento.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_dataNascimento.BorderColor = System.Drawing.Color.Silver;
            this.txt_dataNascimento.BorderSize = 0;
            this.txt_dataNascimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dataNascimento.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_dataNascimento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dataNascimento.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_dataNascimento.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_dataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_dataNascimento.Location = new System.Drawing.Point(247, 160);
            this.txt_dataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dataNascimento.Name = "txt_dataNascimento";
            this.txt_dataNascimento.PasswordChar = '\0';
            this.txt_dataNascimento.Size = new System.Drawing.Size(213, 41);
            this.txt_dataNascimento.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel4.Location = new System.Drawing.Point(107, 169);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(132, 23);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Dt. Nascimento:";
            // 
            // txt_CodigoFuncionario
            // 
            this.txt_CodigoFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodigoFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_CodigoFuncionario.BorderSize = 0;
            this.txt_CodigoFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CodigoFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodigoFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CodigoFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodigoFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CodigoFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodigoFuncionario.Location = new System.Drawing.Point(770, 110);
            this.txt_CodigoFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoFuncionario.Name = "txt_CodigoFuncionario";
            this.txt_CodigoFuncionario.PasswordChar = '\0';
            this.txt_CodigoFuncionario.Size = new System.Drawing.Size(79, 41);
            this.txt_CodigoFuncionario.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel3.Location = new System.Drawing.Point(727, 119);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(31, 23);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "ID:";
            // 
            // txt_NomeFuncionario
            // 
            this.txt_NomeFuncionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_NomeFuncionario.BorderColor = System.Drawing.Color.Silver;
            this.txt_NomeFuncionario.BorderSize = 0;
            this.txt_NomeFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeFuncionario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_NomeFuncionario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_NomeFuncionario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_NomeFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_NomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_NomeFuncionario.Location = new System.Drawing.Point(179, 110);
            this.txt_NomeFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeFuncionario.Name = "txt_NomeFuncionario";
            this.txt_NomeFuncionario.PasswordChar = '\0';
            this.txt_NomeFuncionario.Size = new System.Drawing.Size(497, 41);
            this.txt_NomeFuncionario.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel2.Location = new System.Drawing.Point(107, 119);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(61, 23);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Nome:";
            // 
            // frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 864);
            this.Controls.Add(this.Ep_Funcionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Funcionario";
            this.Text = "frm_Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Ep_Funcionarios.ResumeLayout(false);
            this.Ep_Funcionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel Ep_Funcionarios;
        private Guna.UI.WinForms.GunaComboBox txt_status;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton btn_excluir;
        private Guna.UI.WinForms.GunaButton btn_atualiarFuncionario;
        private Guna.UI.WinForms.GunaButton btn_InserirFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaTextBox txt_CelularFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaTextBox txt_emailFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaTextBox txt_TelefoneFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaComboBox cb_sexoFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox txt_CidadeFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox txt_CepFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txt_EnderecoFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txt_CpfFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txt_RgFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txt_dataNascimento;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txt_CodigoFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_NomeFuncionario;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btn_BuscarCPF;
        private Guna.UI.WinForms.GunaComboBox txt_estadocivil;
        private Guna.UI.WinForms.GunaComboBox txt_Estado;
        private System.Windows.Forms.DataGridView gvFunc;
        private System.Windows.Forms.DataGridView dgvLocPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasAtraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}