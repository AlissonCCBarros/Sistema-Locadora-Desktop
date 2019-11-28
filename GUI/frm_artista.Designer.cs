namespace GUI
{
    partial class frm_artista
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
            this.Ep_artista = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnpesquisanome = new Guna.UI.WinForms.GunaButton();
            this.dgvArtistas = new System.Windows.Forms.DataGridView();
            this.IDFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmPersonagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_atualizar = new Guna.UI.WinForms.GunaButton();
            this.btn_excluir = new Guna.UI.WinForms.GunaButton();
            this.btn_inserir = new Guna.UI.WinForms.GunaButton();
            this.txt_dtNascimento = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btn_BuscarArtista = new Guna.UI.WinForms.GunaButton();
            this.txt_PaisArtista = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel44 = new Guna.UI.WinForms.GunaLabel();
            this.txt_idArtista = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel45 = new Guna.UI.WinForms.GunaLabel();
            this.txt_NomeArtista = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel46 = new Guna.UI.WinForms.GunaLabel();
            this.btn_ProcurarImagemArtista = new Guna.UI.WinForms.GunaButton();
            this.txt_diretorio_img = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Ep_artista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).BeginInit();
            this.SuspendLayout();
            // 
            // Ep_artista
            // 
            this.Ep_artista.BackColor = System.Drawing.Color.Transparent;
            this.Ep_artista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.Ep_artista.Controls.Add(this.btnpesquisanome);
            this.Ep_artista.Controls.Add(this.dgvArtistas);
            this.Ep_artista.Controls.Add(this.btn_atualizar);
            this.Ep_artista.Controls.Add(this.btn_excluir);
            this.Ep_artista.Controls.Add(this.btn_inserir);
            this.Ep_artista.Controls.Add(this.txt_dtNascimento);
            this.Ep_artista.Controls.Add(this.gunaLabel2);
            this.Ep_artista.Controls.Add(this.btn_BuscarArtista);
            this.Ep_artista.Controls.Add(this.txt_PaisArtista);
            this.Ep_artista.Controls.Add(this.gunaLabel44);
            this.Ep_artista.Controls.Add(this.txt_idArtista);
            this.Ep_artista.Controls.Add(this.gunaLabel45);
            this.Ep_artista.Controls.Add(this.txt_NomeArtista);
            this.Ep_artista.Controls.Add(this.gunaLabel46);
            this.Ep_artista.Controls.Add(this.btn_ProcurarImagemArtista);
            this.Ep_artista.Controls.Add(this.txt_diretorio_img);
            this.Ep_artista.Controls.Add(this.gunaLabel1);
            this.Ep_artista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ep_artista.Location = new System.Drawing.Point(0, 0);
            this.Ep_artista.Margin = new System.Windows.Forms.Padding(4);
            this.Ep_artista.Name = "Ep_artista";
            this.Ep_artista.Size = new System.Drawing.Size(1396, 1085);
            this.Ep_artista.TabIndex = 40;
            // 
            // btnpesquisanome
            // 
            this.btnpesquisanome.AnimationHoverSpeed = 0.07F;
            this.btnpesquisanome.AnimationSpeed = 0.03F;
            this.btnpesquisanome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnpesquisanome.BorderColor = System.Drawing.Color.Black;
            this.btnpesquisanome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnpesquisanome.FocusedColor = System.Drawing.Color.Empty;
            this.btnpesquisanome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnpesquisanome.ForeColor = System.Drawing.Color.White;
            this.btnpesquisanome.Image = null;
            this.btnpesquisanome.ImageSize = new System.Drawing.Size(20, 20);
            this.btnpesquisanome.Location = new System.Drawing.Point(594, 123);
            this.btnpesquisanome.Margin = new System.Windows.Forms.Padding(4);
            this.btnpesquisanome.Name = "btnpesquisanome";
            this.btnpesquisanome.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnpesquisanome.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnpesquisanome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnpesquisanome.OnHoverImage = null;
            this.btnpesquisanome.OnPressedColor = System.Drawing.Color.Black;
            this.btnpesquisanome.Size = new System.Drawing.Size(100, 42);
            this.btnpesquisanome.TabIndex = 55;
            this.btnpesquisanome.Text = "Buscar";
            this.btnpesquisanome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnpesquisanome.Click += new System.EventHandler(this.btnpesquisanome_Click);
            // 
            // dgvArtistas
            // 
            this.dgvArtistas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFilme,
            this.Titulo,
            this.NmPersonagem});
            this.dgvArtistas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArtistas.Location = new System.Drawing.Point(209, 441);
            this.dgvArtistas.Name = "dgvArtistas";
            this.dgvArtistas.RowHeadersWidth = 51;
            this.dgvArtistas.RowTemplate.Height = 24;
            this.dgvArtistas.Size = new System.Drawing.Size(728, 150);
            this.dgvArtistas.TabIndex = 54;
            // 
            // IDFilme
            // 
            this.IDFilme.DataPropertyName = "Id";
            this.IDFilme.HeaderText = "ID Filme";
            this.IDFilme.MinimumWidth = 6;
            this.IDFilme.Name = "IDFilme";
            this.IDFilme.Width = 90;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 200;
            // 
            // NmPersonagem
            // 
            this.NmPersonagem.DataPropertyName = "NmPersonagem";
            this.NmPersonagem.HeaderText = "Personagem";
            this.NmPersonagem.MinimumWidth = 6;
            this.NmPersonagem.Name = "NmPersonagem";
            this.NmPersonagem.Width = 200;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.AnimationHoverSpeed = 0.07F;
            this.btn_atualizar.AnimationSpeed = 0.03F;
            this.btn_atualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_atualizar.BorderColor = System.Drawing.Color.Black;
            this.btn_atualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_atualizar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_atualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = null;
            this.btn_atualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_atualizar.Location = new System.Drawing.Point(728, 377);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_atualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_atualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_atualizar.OnHoverImage = null;
            this.btn_atualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_atualizar.Size = new System.Drawing.Size(137, 42);
            this.btn_atualizar.TabIndex = 53;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
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
            this.btn_excluir.Location = new System.Drawing.Point(519, 377);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_excluir.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_excluir.OnHoverImage = null;
            this.btn_excluir.OnPressedColor = System.Drawing.Color.Black;
            this.btn_excluir.Size = new System.Drawing.Size(137, 42);
            this.btn_excluir.TabIndex = 52;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.AnimationHoverSpeed = 0.07F;
            this.btn_inserir.AnimationSpeed = 0.03F;
            this.btn_inserir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_inserir.BorderColor = System.Drawing.Color.Black;
            this.btn_inserir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_inserir.FocusedColor = System.Drawing.Color.Empty;
            this.btn_inserir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Image = null;
            this.btn_inserir.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_inserir.Location = new System.Drawing.Point(303, 377);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_inserir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_inserir.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_inserir.OnHoverImage = null;
            this.btn_inserir.OnPressedColor = System.Drawing.Color.Black;
            this.btn_inserir.Size = new System.Drawing.Size(137, 42);
            this.btn_inserir.TabIndex = 51;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_dtNascimento
            // 
            this.txt_dtNascimento.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_dtNascimento.BorderColor = System.Drawing.Color.Silver;
            this.txt_dtNascimento.BorderSize = 0;
            this.txt_dtNascimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dtNascimento.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_dtNascimento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dtNascimento.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_dtNascimento.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_dtNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_dtNascimento.Location = new System.Drawing.Point(344, 222);
            this.txt_dtNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dtNascimento.Name = "txt_dtNascimento";
            this.txt_dtNascimento.PasswordChar = '\0';
            this.txt_dtNascimento.Size = new System.Drawing.Size(350, 41);
            this.txt_dtNascimento.TabIndex = 50;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel2.Location = new System.Drawing.Point(205, 231);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(127, 23);
            this.gunaLabel2.TabIndex = 49;
            this.gunaLabel2.Text = "Dt.Nascimento:";
            // 
            // btn_BuscarArtista
            // 
            this.btn_BuscarArtista.AnimationHoverSpeed = 0.07F;
            this.btn_BuscarArtista.AnimationSpeed = 0.03F;
            this.btn_BuscarArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarArtista.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarArtista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BuscarArtista.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BuscarArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_BuscarArtista.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarArtista.Image = null;
            this.btn_BuscarArtista.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BuscarArtista.Location = new System.Drawing.Point(867, 123);
            this.btn_BuscarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarArtista.Name = "btn_BuscarArtista";
            this.btn_BuscarArtista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarArtista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarArtista.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarArtista.OnHoverImage = null;
            this.btn_BuscarArtista.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarArtista.Size = new System.Drawing.Size(100, 42);
            this.btn_BuscarArtista.TabIndex = 48;
            this.btn_BuscarArtista.Text = "Buscar";
            this.btn_BuscarArtista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarArtista.Click += new System.EventHandler(this.btn_BuscarArtista_Click);
            // 
            // txt_PaisArtista
            // 
            this.txt_PaisArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_PaisArtista.BorderColor = System.Drawing.Color.Silver;
            this.txt_PaisArtista.BorderSize = 0;
            this.txt_PaisArtista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PaisArtista.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_PaisArtista.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PaisArtista.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_PaisArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_PaisArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_PaisArtista.Location = new System.Drawing.Point(274, 173);
            this.txt_PaisArtista.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PaisArtista.Name = "txt_PaisArtista";
            this.txt_PaisArtista.PasswordChar = '\0';
            this.txt_PaisArtista.Size = new System.Drawing.Size(420, 41);
            this.txt_PaisArtista.TabIndex = 47;
            // 
            // gunaLabel44
            // 
            this.gunaLabel44.AutoSize = true;
            this.gunaLabel44.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel44.Location = new System.Drawing.Point(205, 182);
            this.gunaLabel44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel44.Name = "gunaLabel44";
            this.gunaLabel44.Size = new System.Drawing.Size(44, 23);
            this.gunaLabel44.TabIndex = 46;
            this.gunaLabel44.Text = "Pais:";
            // 
            // txt_idArtista
            // 
            this.txt_idArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_idArtista.BorderColor = System.Drawing.Color.Silver;
            this.txt_idArtista.BorderSize = 0;
            this.txt_idArtista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idArtista.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_idArtista.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_idArtista.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_idArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_idArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_idArtista.Location = new System.Drawing.Point(755, 124);
            this.txt_idArtista.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idArtista.Name = "txt_idArtista";
            this.txt_idArtista.PasswordChar = '\0';
            this.txt_idArtista.Size = new System.Drawing.Size(79, 41);
            this.txt_idArtista.TabIndex = 45;
            // 
            // gunaLabel45
            // 
            this.gunaLabel45.AutoSize = true;
            this.gunaLabel45.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel45.Location = new System.Drawing.Point(716, 133);
            this.gunaLabel45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel45.Name = "gunaLabel45";
            this.gunaLabel45.Size = new System.Drawing.Size(31, 23);
            this.gunaLabel45.TabIndex = 44;
            this.gunaLabel45.Text = "ID:";
            // 
            // txt_NomeArtista
            // 
            this.txt_NomeArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_NomeArtista.BorderColor = System.Drawing.Color.Silver;
            this.txt_NomeArtista.BorderSize = 0;
            this.txt_NomeArtista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeArtista.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_NomeArtista.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_NomeArtista.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_NomeArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_NomeArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_NomeArtista.Location = new System.Drawing.Point(274, 124);
            this.txt_NomeArtista.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeArtista.Name = "txt_NomeArtista";
            this.txt_NomeArtista.PasswordChar = '\0';
            this.txt_NomeArtista.Size = new System.Drawing.Size(312, 41);
            this.txt_NomeArtista.TabIndex = 43;
            // 
            // gunaLabel46
            // 
            this.gunaLabel46.AutoSize = true;
            this.gunaLabel46.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel46.Location = new System.Drawing.Point(205, 133);
            this.gunaLabel46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel46.Name = "gunaLabel46";
            this.gunaLabel46.Size = new System.Drawing.Size(61, 23);
            this.gunaLabel46.TabIndex = 42;
            this.gunaLabel46.Text = "Nome:";
            // 
            // btn_ProcurarImagemArtista
            // 
            this.btn_ProcurarImagemArtista.AnimationHoverSpeed = 0.07F;
            this.btn_ProcurarImagemArtista.AnimationSpeed = 0.03F;
            this.btn_ProcurarImagemArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_ProcurarImagemArtista.BorderColor = System.Drawing.Color.Black;
            this.btn_ProcurarImagemArtista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ProcurarImagemArtista.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ProcurarImagemArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_ProcurarImagemArtista.ForeColor = System.Drawing.Color.White;
            this.btn_ProcurarImagemArtista.Image = null;
            this.btn_ProcurarImagemArtista.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ProcurarImagemArtista.Location = new System.Drawing.Point(734, 270);
            this.btn_ProcurarImagemArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ProcurarImagemArtista.Name = "btn_ProcurarImagemArtista";
            this.btn_ProcurarImagemArtista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_ProcurarImagemArtista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ProcurarImagemArtista.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ProcurarImagemArtista.OnHoverImage = null;
            this.btn_ProcurarImagemArtista.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ProcurarImagemArtista.Size = new System.Drawing.Size(100, 42);
            this.btn_ProcurarImagemArtista.TabIndex = 41;
            this.btn_ProcurarImagemArtista.Text = "Procurar";
            this.btn_ProcurarImagemArtista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ProcurarImagemArtista.Click += new System.EventHandler(this.btn_ProcurarImagemArtista_Click);
            // 
            // txt_diretorio_img
            // 
            this.txt_diretorio_img.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_diretorio_img.BorderColor = System.Drawing.Color.Silver;
            this.txt_diretorio_img.BorderSize = 0;
            this.txt_diretorio_img.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diretorio_img.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_diretorio_img.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_diretorio_img.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_diretorio_img.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_diretorio_img.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_diretorio_img.Location = new System.Drawing.Point(344, 271);
            this.txt_diretorio_img.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diretorio_img.Name = "txt_diretorio_img";
            this.txt_diretorio_img.PasswordChar = '\0';
            this.txt_diretorio_img.Size = new System.Drawing.Size(342, 41);
            this.txt_diretorio_img.TabIndex = 40;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel1.Location = new System.Drawing.Point(205, 280);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(131, 23);
            this.gunaLabel1.TabIndex = 39;
            this.gunaLabel1.Text = "Imagem Artista:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd_artista";
            // 
            // frm_artista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1085);
            this.Controls.Add(this.Ep_artista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_artista";
            this.Text = "frm_artista";
            this.Ep_artista.ResumeLayout(false);
            this.Ep_artista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel Ep_artista;
        private Guna.UI.WinForms.GunaButton btn_ProcurarImagemArtista;
        private Guna.UI.WinForms.GunaTextBox txt_diretorio_img;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btn_BuscarArtista;
        private Guna.UI.WinForms.GunaTextBox txt_PaisArtista;
        private Guna.UI.WinForms.GunaLabel gunaLabel44;
        private Guna.UI.WinForms.GunaTextBox txt_idArtista;
        private Guna.UI.WinForms.GunaLabel gunaLabel45;
        private Guna.UI.WinForms.GunaTextBox txt_NomeArtista;
        private Guna.UI.WinForms.GunaLabel gunaLabel46;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI.WinForms.GunaButton btn_atualizar;
        private Guna.UI.WinForms.GunaButton btn_excluir;
        private Guna.UI.WinForms.GunaButton btn_inserir;
        private Guna.UI.WinForms.GunaTextBox txt_dtNascimento;
        private System.Windows.Forms.DataGridView dgvArtistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmPersonagem;
        private Guna.UI.WinForms.GunaButton btnpesquisanome;
    }
}