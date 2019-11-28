namespace GUI
{
    partial class frm_Filme
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
            this.Ep_Filme = new Guna.UI.WinForms.GunaElipsePanel();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.dgvLocado = new System.Windows.Forms.DataGridView();
            this.btnSalvarArtista = new Guna.UI.WinForms.GunaButton();
            this.txtPersonagem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cboxArtista = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtIdfilmeArtista = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnSalvarGe = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cboxGenero = new Guna.UI.WinForms.GunaComboBox();
            this.txt_dtAquisicao = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tipo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_descricao = new Guna.UI.WinForms.GunaTextBox();
            this.btn_ProcurarImagem = new Guna.UI.WinForms.GunaButton();
            this.txt_diretorio_img = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cb_SituacaoFilme = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel32 = new Guna.UI.WinForms.GunaLabel();
            this.btn_BuscarFilme = new Guna.UI.WinForms.GunaButton();
            this.btn_excluirFilme = new Guna.UI.WinForms.GunaButton();
            this.btn_AtualizarFilme = new Guna.UI.WinForms.GunaButton();
            this.btn_inserirFIlme = new Guna.UI.WinForms.GunaButton();
            this.txt_GeneroFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel35 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DiretorFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel37 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CustoFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel39 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel41 = new Guna.UI.WinForms.GunaLabel();
            this.txt_precoFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel42 = new Guna.UI.WinForms.GunaLabel();
            this.txt_AnoFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel43 = new Guna.UI.WinForms.GunaLabel();
            this.txt_TituloFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel44 = new Guna.UI.WinForms.GunaLabel();
            this.txt_idFilme = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel45 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CodigoDeBarras = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel46 = new Guna.UI.WinForms.GunaLabel();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.Ep_Filme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocado)).BeginInit();
            this.SuspendLayout();
            // 
            // Ep_Filme
            // 
            this.Ep_Filme.BackColor = System.Drawing.Color.Transparent;
            this.Ep_Filme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.Ep_Filme.Controls.Add(this.dgvFilmes);
            this.Ep_Filme.Controls.Add(this.dgvHistorico);
            this.Ep_Filme.Controls.Add(this.dgvLocado);
            this.Ep_Filme.Controls.Add(this.btnSalvarArtista);
            this.Ep_Filme.Controls.Add(this.txtPersonagem);
            this.Ep_Filme.Controls.Add(this.gunaLabel8);
            this.Ep_Filme.Controls.Add(this.cboxArtista);
            this.Ep_Filme.Controls.Add(this.gunaLabel7);
            this.Ep_Filme.Controls.Add(this.txtIdfilmeArtista);
            this.Ep_Filme.Controls.Add(this.gunaLabel6);
            this.Ep_Filme.Controls.Add(this.btnSalvarGe);
            this.Ep_Filme.Controls.Add(this.gunaLabel5);
            this.Ep_Filme.Controls.Add(this.gunaLabel4);
            this.Ep_Filme.Controls.Add(this.cboxGenero);
            this.Ep_Filme.Controls.Add(this.txt_dtAquisicao);
            this.Ep_Filme.Controls.Add(this.txt_tipo);
            this.Ep_Filme.Controls.Add(this.gunaLabel3);
            this.Ep_Filme.Controls.Add(this.gunaLabel2);
            this.Ep_Filme.Controls.Add(this.txt_descricao);
            this.Ep_Filme.Controls.Add(this.btn_ProcurarImagem);
            this.Ep_Filme.Controls.Add(this.txt_diretorio_img);
            this.Ep_Filme.Controls.Add(this.gunaLabel1);
            this.Ep_Filme.Controls.Add(this.cb_SituacaoFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel32);
            this.Ep_Filme.Controls.Add(this.btn_BuscarFilme);
            this.Ep_Filme.Controls.Add(this.btn_excluirFilme);
            this.Ep_Filme.Controls.Add(this.btn_AtualizarFilme);
            this.Ep_Filme.Controls.Add(this.btn_inserirFIlme);
            this.Ep_Filme.Controls.Add(this.txt_GeneroFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel35);
            this.Ep_Filme.Controls.Add(this.txt_DiretorFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel37);
            this.Ep_Filme.Controls.Add(this.txt_CustoFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel39);
            this.Ep_Filme.Controls.Add(this.gunaLabel41);
            this.Ep_Filme.Controls.Add(this.txt_precoFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel42);
            this.Ep_Filme.Controls.Add(this.txt_AnoFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel43);
            this.Ep_Filme.Controls.Add(this.txt_TituloFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel44);
            this.Ep_Filme.Controls.Add(this.txt_idFilme);
            this.Ep_Filme.Controls.Add(this.gunaLabel45);
            this.Ep_Filme.Controls.Add(this.txt_CodigoDeBarras);
            this.Ep_Filme.Controls.Add(this.gunaLabel46);
            this.Ep_Filme.Location = new System.Drawing.Point(0, -4);
            this.Ep_Filme.Margin = new System.Windows.Forms.Padding(4);
            this.Ep_Filme.Name = "Ep_Filme";
            this.Ep_Filme.Size = new System.Drawing.Size(1117, 1002);
            this.Ep_Filme.TabIndex = 38;
            this.Ep_Filme.Paint += new System.Windows.Forms.PaintEventHandler(this.Ep_Filme_Paint);
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFilmes.Location = new System.Drawing.Point(568, 697);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.RowHeadersWidth = 51;
            this.dgvFilmes.RowTemplate.Height = 24;
            this.dgvFilmes.Size = new System.Drawing.Size(450, 112);
            this.dgvFilmes.TabIndex = 60;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHistorico.Location = new System.Drawing.Point(103, 697);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 24;
            this.dgvHistorico.Size = new System.Drawing.Size(450, 112);
            this.dgvHistorico.TabIndex = 59;
            // 
            // dgvLocado
            // 
            this.dgvLocado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocado.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLocado.Location = new System.Drawing.Point(669, 213);
            this.dgvLocado.Name = "dgvLocado";
            this.dgvLocado.RowHeadersWidth = 51;
            this.dgvLocado.RowTemplate.Height = 24;
            this.dgvLocado.Size = new System.Drawing.Size(348, 267);
            this.dgvLocado.TabIndex = 58;
            // 
            // btnSalvarArtista
            // 
            this.btnSalvarArtista.AnimationHoverSpeed = 0.07F;
            this.btnSalvarArtista.AnimationSpeed = 0.03F;
            this.btnSalvarArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSalvarArtista.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarArtista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvarArtista.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalvarArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSalvarArtista.ForeColor = System.Drawing.Color.White;
            this.btnSalvarArtista.Image = null;
            this.btnSalvarArtista.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalvarArtista.Location = new System.Drawing.Point(888, 603);
            this.btnSalvarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarArtista.Name = "btnSalvarArtista";
            this.btnSalvarArtista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSalvarArtista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalvarArtista.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalvarArtista.OnHoverImage = null;
            this.btnSalvarArtista.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalvarArtista.Size = new System.Drawing.Size(130, 33);
            this.btnSalvarArtista.TabIndex = 57;
            this.btnSalvarArtista.Text = "Salvar Artista";
            this.btnSalvarArtista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalvarArtista.Click += new System.EventHandler(this.btnSalvarArtista_Click);
            // 
            // txtPersonagem
            // 
            this.txtPersonagem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtPersonagem.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonagem.BorderSize = 0;
            this.txtPersonagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonagem.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtPersonagem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPersonagem.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txtPersonagem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtPersonagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txtPersonagem.Location = new System.Drawing.Point(785, 644);
            this.txtPersonagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonagem.Name = "txtPersonagem";
            this.txtPersonagem.PasswordChar = '\0';
            this.txtPersonagem.Size = new System.Drawing.Size(232, 33);
            this.txtPersonagem.TabIndex = 56;
            this.txtPersonagem.Text = "Personagem";
            this.txtPersonagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel8.Location = new System.Drawing.Point(435, 649);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(70, 23);
            this.gunaLabel8.TabIndex = 54;
            this.gunaLabel8.Text = "Artistas:";
            // 
            // cboxArtista
            // 
            this.cboxArtista.BackColor = System.Drawing.Color.Transparent;
            this.cboxArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cboxArtista.BorderColor = System.Drawing.Color.Silver;
            this.cboxArtista.BorderSize = 0;
            this.cboxArtista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxArtista.FocusedColor = System.Drawing.Color.Empty;
            this.cboxArtista.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.cboxArtista.FormattingEnabled = true;
            this.cboxArtista.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboxArtista.Location = new System.Drawing.Point(522, 645);
            this.cboxArtista.Margin = new System.Windows.Forms.Padding(4);
            this.cboxArtista.Name = "cboxArtista";
            this.cboxArtista.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.cboxArtista.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cboxArtista.Size = new System.Drawing.Size(255, 31);
            this.cboxArtista.TabIndex = 53;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel7.Location = new System.Drawing.Point(273, 649);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel7.TabIndex = 52;
            this.gunaLabel7.Text = "ID Filme:";
            // 
            // txtIdfilmeArtista
            // 
            this.txtIdfilmeArtista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtIdfilmeArtista.BorderColor = System.Drawing.Color.Silver;
            this.txtIdfilmeArtista.BorderSize = 0;
            this.txtIdfilmeArtista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdfilmeArtista.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtIdfilmeArtista.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdfilmeArtista.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txtIdfilmeArtista.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtIdfilmeArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txtIdfilmeArtista.Location = new System.Drawing.Point(360, 644);
            this.txtIdfilmeArtista.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdfilmeArtista.Name = "txtIdfilmeArtista";
            this.txtIdfilmeArtista.PasswordChar = '\0';
            this.txtIdfilmeArtista.Size = new System.Drawing.Size(60, 33);
            this.txtIdfilmeArtista.TabIndex = 51;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel6.Location = new System.Drawing.Point(98, 649);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(167, 23);
            this.gunaLabel6.TabIndex = 50;
            this.gunaLabel6.Text = "Cadastro de Artistas:";
            // 
            // btnSalvarGe
            // 
            this.btnSalvarGe.AnimationHoverSpeed = 0.07F;
            this.btnSalvarGe.AnimationSpeed = 0.03F;
            this.btnSalvarGe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSalvarGe.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarGe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvarGe.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalvarGe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSalvarGe.ForeColor = System.Drawing.Color.White;
            this.btnSalvarGe.Image = null;
            this.btnSalvarGe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalvarGe.Location = new System.Drawing.Point(730, 603);
            this.btnSalvarGe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarGe.Name = "btnSalvarGe";
            this.btnSalvarGe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSalvarGe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalvarGe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalvarGe.OnHoverImage = null;
            this.btnSalvarGe.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalvarGe.Size = new System.Drawing.Size(130, 33);
            this.btnSalvarGe.TabIndex = 47;
            this.btnSalvarGe.Text = "Salvar Genero";
            this.btnSalvarGe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalvarGe.Click += new System.EventHandler(this.btnSalvarGe_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel5.Location = new System.Drawing.Point(435, 608);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel5.TabIndex = 46;
            this.gunaLabel5.Text = "Gêneros:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel4.Location = new System.Drawing.Point(273, 608);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel4.TabIndex = 45;
            this.gunaLabel4.Text = "ID Filme:";
            // 
            // cboxGenero
            // 
            this.cboxGenero.BackColor = System.Drawing.Color.Transparent;
            this.cboxGenero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cboxGenero.BorderColor = System.Drawing.Color.Silver;
            this.cboxGenero.BorderSize = 0;
            this.cboxGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FocusedColor = System.Drawing.Color.Empty;
            this.cboxGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboxGenero.Location = new System.Drawing.Point(522, 604);
            this.cboxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.cboxGenero.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cboxGenero.Size = new System.Drawing.Size(200, 31);
            this.cboxGenero.TabIndex = 44;
            this.cboxGenero.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // txt_dtAquisicao
            // 
            this.txt_dtAquisicao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_dtAquisicao.BorderColor = System.Drawing.Color.Silver;
            this.txt_dtAquisicao.BorderSize = 0;
            this.txt_dtAquisicao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dtAquisicao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_dtAquisicao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dtAquisicao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_dtAquisicao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_dtAquisicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_dtAquisicao.Location = new System.Drawing.Point(515, 213);
            this.txt_dtAquisicao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dtAquisicao.Name = "txt_dtAquisicao";
            this.txt_dtAquisicao.PasswordChar = '\0';
            this.txt_dtAquisicao.Size = new System.Drawing.Size(133, 33);
            this.txt_dtAquisicao.TabIndex = 43;
            // 
            // txt_tipo
            // 
            this.txt_tipo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_tipo.BorderColor = System.Drawing.Color.Silver;
            this.txt_tipo.BorderSize = 0;
            this.txt_tipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tipo.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_tipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tipo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_tipo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_tipo.Location = new System.Drawing.Point(475, 325);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.PasswordChar = '\0';
            this.txt_tipo.Size = new System.Drawing.Size(173, 33);
            this.txt_tipo.TabIndex = 42;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel3.Location = new System.Drawing.Point(402, 330);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(47, 23);
            this.gunaLabel3.TabIndex = 41;
            this.gunaLabel3.Text = "Tipo:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel2.Location = new System.Drawing.Point(93, 416);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(87, 23);
            this.gunaLabel2.TabIndex = 40;
            this.gunaLabel2.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_descricao.BorderColor = System.Drawing.Color.Silver;
            this.txt_descricao.BorderSize = 0;
            this.txt_descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_descricao.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_descricao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_descricao.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_descricao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_descricao.Location = new System.Drawing.Point(191, 374);
            this.txt_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descricao.MultiLine = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.PasswordChar = '\0';
            this.txt_descricao.Size = new System.Drawing.Size(457, 106);
            this.txt_descricao.TabIndex = 39;
            // 
            // btn_ProcurarImagem
            // 
            this.btn_ProcurarImagem.AnimationHoverSpeed = 0.07F;
            this.btn_ProcurarImagem.AnimationSpeed = 0.03F;
            this.btn_ProcurarImagem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_ProcurarImagem.BorderColor = System.Drawing.Color.Black;
            this.btn_ProcurarImagem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ProcurarImagem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ProcurarImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_ProcurarImagem.ForeColor = System.Drawing.Color.White;
            this.btn_ProcurarImagem.Image = null;
            this.btn_ProcurarImagem.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ProcurarImagem.Location = new System.Drawing.Point(917, 511);
            this.btn_ProcurarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ProcurarImagem.Name = "btn_ProcurarImagem";
            this.btn_ProcurarImagem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_ProcurarImagem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ProcurarImagem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ProcurarImagem.OnHoverImage = null;
            this.btn_ProcurarImagem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ProcurarImagem.Size = new System.Drawing.Size(100, 33);
            this.btn_ProcurarImagem.TabIndex = 38;
            this.btn_ProcurarImagem.Text = "Procurar";
            this.btn_ProcurarImagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ProcurarImagem.Click += new System.EventHandler(this.btn_ProcurarImagem_Click);
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
            this.txt_diretorio_img.Location = new System.Drawing.Point(260, 511);
            this.txt_diretorio_img.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diretorio_img.Name = "txt_diretorio_img";
            this.txt_diretorio_img.PasswordChar = '\0';
            this.txt_diretorio_img.Size = new System.Drawing.Size(634, 33);
            this.txt_diretorio_img.TabIndex = 37;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel1.Location = new System.Drawing.Point(98, 516);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(142, 23);
            this.gunaLabel1.TabIndex = 36;
            this.gunaLabel1.Text = "Imagem de capa:";
            // 
            // cb_SituacaoFilme
            // 
            this.cb_SituacaoFilme.BackColor = System.Drawing.Color.Transparent;
            this.cb_SituacaoFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cb_SituacaoFilme.BorderColor = System.Drawing.Color.Silver;
            this.cb_SituacaoFilme.BorderSize = 0;
            this.cb_SituacaoFilme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SituacaoFilme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SituacaoFilme.FocusedColor = System.Drawing.Color.Empty;
            this.cb_SituacaoFilme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_SituacaoFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.cb_SituacaoFilme.FormattingEnabled = true;
            this.cb_SituacaoFilme.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cb_SituacaoFilme.Location = new System.Drawing.Point(803, 155);
            this.cb_SituacaoFilme.Margin = new System.Windows.Forms.Padding(4);
            this.cb_SituacaoFilme.Name = "cb_SituacaoFilme";
            this.cb_SituacaoFilme.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cb_SituacaoFilme.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cb_SituacaoFilme.Size = new System.Drawing.Size(160, 31);
            this.cb_SituacaoFilme.TabIndex = 35;
            this.cb_SituacaoFilme.SelectedIndexChanged += new System.EventHandler(this.Cb_SituacaoFilme_SelectedIndexChanged);
            // 
            // gunaLabel32
            // 
            this.gunaLabel32.AutoSize = true;
            this.gunaLabel32.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel32.Location = new System.Drawing.Point(98, 330);
            this.gunaLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel32.Name = "gunaLabel32";
            this.gunaLabel32.Size = new System.Drawing.Size(68, 23);
            this.gunaLabel32.TabIndex = 34;
            this.gunaLabel32.Text = "Diretor:";
            // 
            // btn_BuscarFilme
            // 
            this.btn_BuscarFilme.AnimationHoverSpeed = 0.07F;
            this.btn_BuscarFilme.AnimationSpeed = 0.03F;
            this.btn_BuscarFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarFilme.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarFilme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BuscarFilme.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BuscarFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_BuscarFilme.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarFilme.Image = null;
            this.btn_BuscarFilme.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BuscarFilme.Location = new System.Drawing.Point(866, 107);
            this.btn_BuscarFilme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarFilme.Name = "btn_BuscarFilme";
            this.btn_BuscarFilme.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarFilme.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarFilme.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarFilme.OnHoverImage = null;
            this.btn_BuscarFilme.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarFilme.Size = new System.Drawing.Size(100, 33);
            this.btn_BuscarFilme.TabIndex = 32;
            this.btn_BuscarFilme.Text = "Buscar";
            this.btn_BuscarFilme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarFilme.Click += new System.EventHandler(this.btn_BuscarFilme_Click);
            // 
            // btn_excluirFilme
            // 
            this.btn_excluirFilme.AnimationHoverSpeed = 0.07F;
            this.btn_excluirFilme.AnimationSpeed = 0.03F;
            this.btn_excluirFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluirFilme.BorderColor = System.Drawing.Color.Black;
            this.btn_excluirFilme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_excluirFilme.FocusedColor = System.Drawing.Color.Empty;
            this.btn_excluirFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_excluirFilme.ForeColor = System.Drawing.Color.White;
            this.btn_excluirFilme.Image = null;
            this.btn_excluirFilme.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_excluirFilme.Location = new System.Drawing.Point(427, 553);
            this.btn_excluirFilme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluirFilme.Name = "btn_excluirFilme";
            this.btn_excluirFilme.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_excluirFilme.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_excluirFilme.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_excluirFilme.OnHoverImage = null;
            this.btn_excluirFilme.OnPressedColor = System.Drawing.Color.Black;
            this.btn_excluirFilme.Size = new System.Drawing.Size(220, 33);
            this.btn_excluirFilme.TabIndex = 30;
            this.btn_excluirFilme.Text = "Excluir";
            this.btn_excluirFilme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_excluirFilme.Click += new System.EventHandler(this.Btn_excluirFilme_Click);
            // 
            // btn_AtualizarFilme
            // 
            this.btn_AtualizarFilme.AnimationHoverSpeed = 0.07F;
            this.btn_AtualizarFilme.AnimationSpeed = 0.03F;
            this.btn_AtualizarFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_AtualizarFilme.BorderColor = System.Drawing.Color.Black;
            this.btn_AtualizarFilme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AtualizarFilme.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AtualizarFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_AtualizarFilme.ForeColor = System.Drawing.Color.White;
            this.btn_AtualizarFilme.Image = null;
            this.btn_AtualizarFilme.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AtualizarFilme.Location = new System.Drawing.Point(695, 553);
            this.btn_AtualizarFilme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AtualizarFilme.Name = "btn_AtualizarFilme";
            this.btn_AtualizarFilme.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_AtualizarFilme.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_AtualizarFilme.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AtualizarFilme.OnHoverImage = null;
            this.btn_AtualizarFilme.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AtualizarFilme.Size = new System.Drawing.Size(220, 33);
            this.btn_AtualizarFilme.TabIndex = 29;
            this.btn_AtualizarFilme.Text = "Atualizar";
            this.btn_AtualizarFilme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AtualizarFilme.Click += new System.EventHandler(this.btn_AtualizarFilme_Click);
            // 
            // btn_inserirFIlme
            // 
            this.btn_inserirFIlme.AnimationHoverSpeed = 0.07F;
            this.btn_inserirFIlme.AnimationSpeed = 0.03F;
            this.btn_inserirFIlme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_inserirFIlme.BorderColor = System.Drawing.Color.Black;
            this.btn_inserirFIlme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_inserirFIlme.FocusedColor = System.Drawing.Color.Empty;
            this.btn_inserirFIlme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_inserirFIlme.ForeColor = System.Drawing.Color.White;
            this.btn_inserirFIlme.Image = null;
            this.btn_inserirFIlme.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_inserirFIlme.Location = new System.Drawing.Point(167, 553);
            this.btn_inserirFIlme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserirFIlme.Name = "btn_inserirFIlme";
            this.btn_inserirFIlme.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_inserirFIlme.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_inserirFIlme.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_inserirFIlme.OnHoverImage = null;
            this.btn_inserirFIlme.OnPressedColor = System.Drawing.Color.Black;
            this.btn_inserirFIlme.Size = new System.Drawing.Size(220, 33);
            this.btn_inserirFIlme.TabIndex = 28;
            this.btn_inserirFIlme.Text = "Inserir";
            this.btn_inserirFIlme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_inserirFIlme.Click += new System.EventHandler(this.btn_inserirFIlme_Click);
            // 
            // txt_GeneroFilme
            // 
            this.txt_GeneroFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_GeneroFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_GeneroFilme.BorderSize = 0;
            this.txt_GeneroFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GeneroFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_GeneroFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_GeneroFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_GeneroFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_GeneroFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_GeneroFilme.Location = new System.Drawing.Point(360, 603);
            this.txt_GeneroFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GeneroFilme.Name = "txt_GeneroFilme";
            this.txt_GeneroFilme.PasswordChar = '\0';
            this.txt_GeneroFilme.Size = new System.Drawing.Size(60, 33);
            this.txt_GeneroFilme.TabIndex = 26;
            // 
            // gunaLabel35
            // 
            this.gunaLabel35.AutoSize = true;
            this.gunaLabel35.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel35.Location = new System.Drawing.Point(716, 159);
            this.gunaLabel35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel35.Name = "gunaLabel35";
            this.gunaLabel35.Size = new System.Drawing.Size(79, 23);
            this.gunaLabel35.TabIndex = 23;
            this.gunaLabel35.Text = "Situacao:";
            // 
            // txt_DiretorFilme
            // 
            this.txt_DiretorFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_DiretorFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_DiretorFilme.BorderSize = 0;
            this.txt_DiretorFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiretorFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_DiretorFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DiretorFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_DiretorFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_DiretorFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_DiretorFilme.Location = new System.Drawing.Point(191, 325);
            this.txt_DiretorFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiretorFilme.Name = "txt_DiretorFilme";
            this.txt_DiretorFilme.PasswordChar = '\0';
            this.txt_DiretorFilme.Size = new System.Drawing.Size(192, 33);
            this.txt_DiretorFilme.TabIndex = 22;
            // 
            // gunaLabel37
            // 
            this.gunaLabel37.AutoSize = true;
            this.gunaLabel37.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel37.Location = new System.Drawing.Point(398, 273);
            this.gunaLabel37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel37.Name = "gunaLabel37";
            this.gunaLabel37.Size = new System.Drawing.Size(58, 23);
            this.gunaLabel37.TabIndex = 18;
            this.gunaLabel37.Text = "Custo:";
            // 
            // txt_CustoFilme
            // 
            this.txt_CustoFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CustoFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_CustoFilme.BorderSize = 0;
            this.txt_CustoFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CustoFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CustoFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CustoFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CustoFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CustoFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CustoFilme.Location = new System.Drawing.Point(475, 268);
            this.txt_CustoFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CustoFilme.Name = "txt_CustoFilme";
            this.txt_CustoFilme.PasswordChar = '\0';
            this.txt_CustoFilme.Size = new System.Drawing.Size(173, 33);
            this.txt_CustoFilme.TabIndex = 17;
            // 
            // gunaLabel39
            // 
            this.gunaLabel39.AutoSize = true;
            this.gunaLabel39.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel39.Location = new System.Drawing.Point(398, 218);
            this.gunaLabel39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel39.Name = "gunaLabel39";
            this.gunaLabel39.Size = new System.Drawing.Size(114, 23);
            this.gunaLabel39.TabIndex = 14;
            this.gunaLabel39.Text = "Dt. Aquisicao:";
            // 
            // gunaLabel41
            // 
            this.gunaLabel41.AutoSize = true;
            this.gunaLabel41.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel41.Location = new System.Drawing.Point(98, 273);
            this.gunaLabel41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel41.Name = "gunaLabel41";
            this.gunaLabel41.Size = new System.Drawing.Size(57, 23);
            this.gunaLabel41.TabIndex = 10;
            this.gunaLabel41.Text = "Preço:";
            // 
            // txt_precoFilme
            // 
            this.txt_precoFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_precoFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_precoFilme.BorderSize = 0;
            this.txt_precoFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_precoFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_precoFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_precoFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_precoFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_precoFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_precoFilme.Location = new System.Drawing.Point(170, 268);
            this.txt_precoFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precoFilme.Name = "txt_precoFilme";
            this.txt_precoFilme.PasswordChar = '\0';
            this.txt_precoFilme.Size = new System.Drawing.Size(213, 33);
            this.txt_precoFilme.TabIndex = 9;
            // 
            // gunaLabel42
            // 
            this.gunaLabel42.AutoSize = true;
            this.gunaLabel42.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel42.Location = new System.Drawing.Point(98, 608);
            this.gunaLabel42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel42.Name = "gunaLabel42";
            this.gunaLabel42.Size = new System.Drawing.Size(167, 23);
            this.gunaLabel42.TabIndex = 8;
            this.gunaLabel42.Text = "Cadastro de Gênero:";
            // 
            // txt_AnoFilme
            // 
            this.txt_AnoFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_AnoFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_AnoFilme.BorderSize = 0;
            this.txt_AnoFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AnoFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_AnoFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_AnoFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_AnoFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_AnoFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_AnoFilme.Location = new System.Drawing.Point(274, 213);
            this.txt_AnoFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AnoFilme.Name = "txt_AnoFilme";
            this.txt_AnoFilme.PasswordChar = '\0';
            this.txt_AnoFilme.Size = new System.Drawing.Size(109, 33);
            this.txt_AnoFilme.TabIndex = 7;
            // 
            // gunaLabel43
            // 
            this.gunaLabel43.AutoSize = true;
            this.gunaLabel43.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel43.Location = new System.Drawing.Point(98, 218);
            this.gunaLabel43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel43.Name = "gunaLabel43";
            this.gunaLabel43.Size = new System.Drawing.Size(164, 23);
            this.gunaLabel43.TabIndex = 6;
            this.gunaLabel43.Text = "Ano de lançamento:";
            this.gunaLabel43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_TituloFilme
            // 
            this.txt_TituloFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_TituloFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_TituloFilme.BorderSize = 0;
            this.txt_TituloFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TituloFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_TituloFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TituloFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_TituloFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_TituloFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_TituloFilme.Location = new System.Drawing.Point(157, 154);
            this.txt_TituloFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TituloFilme.Name = "txt_TituloFilme";
            this.txt_TituloFilme.PasswordChar = '\0';
            this.txt_TituloFilme.Size = new System.Drawing.Size(490, 33);
            this.txt_TituloFilme.TabIndex = 5;
            // 
            // gunaLabel44
            // 
            this.gunaLabel44.AutoSize = true;
            this.gunaLabel44.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel44.Location = new System.Drawing.Point(98, 159);
            this.gunaLabel44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel44.Name = "gunaLabel44";
            this.gunaLabel44.Size = new System.Drawing.Size(57, 23);
            this.gunaLabel44.TabIndex = 4;
            this.gunaLabel44.Text = "Titulo:";
            // 
            // txt_idFilme
            // 
            this.txt_idFilme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_idFilme.BorderColor = System.Drawing.Color.Silver;
            this.txt_idFilme.BorderSize = 0;
            this.txt_idFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idFilme.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_idFilme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_idFilme.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_idFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_idFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_idFilme.Location = new System.Drawing.Point(758, 107);
            this.txt_idFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idFilme.Name = "txt_idFilme";
            this.txt_idFilme.PasswordChar = '\0';
            this.txt_idFilme.Size = new System.Drawing.Size(79, 33);
            this.txt_idFilme.TabIndex = 3;
            // 
            // gunaLabel45
            // 
            this.gunaLabel45.AutoSize = true;
            this.gunaLabel45.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel45.Location = new System.Drawing.Point(719, 112);
            this.gunaLabel45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel45.Name = "gunaLabel45";
            this.gunaLabel45.Size = new System.Drawing.Size(31, 23);
            this.gunaLabel45.TabIndex = 2;
            this.gunaLabel45.Text = "ID:";
            // 
            // txt_CodigoDeBarras
            // 
            this.txt_CodigoDeBarras.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodigoDeBarras.BorderColor = System.Drawing.Color.Silver;
            this.txt_CodigoDeBarras.BorderSize = 0;
            this.txt_CodigoDeBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CodigoDeBarras.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_CodigoDeBarras.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CodigoDeBarras.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodigoDeBarras.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_CodigoDeBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_CodigoDeBarras.Location = new System.Drawing.Point(159, 107);
            this.txt_CodigoDeBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoDeBarras.Name = "txt_CodigoDeBarras";
            this.txt_CodigoDeBarras.PasswordChar = '\0';
            this.txt_CodigoDeBarras.Size = new System.Drawing.Size(490, 33);
            this.txt_CodigoDeBarras.TabIndex = 1;
            // 
            // gunaLabel46
            // 
            this.gunaLabel46.AutoSize = true;
            this.gunaLabel46.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel46.Location = new System.Drawing.Point(99, 112);
            this.gunaLabel46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel46.Name = "gunaLabel46";
            this.gunaLabel46.Size = new System.Drawing.Size(45, 23);
            this.gunaLabel46.TabIndex = 0;
            this.gunaLabel46.Text = "Cod.";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // frm_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 1031);
            this.Controls.Add(this.Ep_Filme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Filme";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_Filme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Ep_Filme.ResumeLayout(false);
            this.Ep_Filme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel Ep_Filme;
        private Guna.UI.WinForms.GunaComboBox cb_SituacaoFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel32;
        private Guna.UI.WinForms.GunaButton btn_BuscarFilme;
        private Guna.UI.WinForms.GunaButton btn_excluirFilme;
        private Guna.UI.WinForms.GunaButton btn_AtualizarFilme;
        private Guna.UI.WinForms.GunaButton btn_inserirFIlme;
        private Guna.UI.WinForms.GunaTextBox txt_GeneroFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel35;
        private Guna.UI.WinForms.GunaTextBox txt_DiretorFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel37;
        private Guna.UI.WinForms.GunaTextBox txt_CustoFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel39;
        private Guna.UI.WinForms.GunaLabel gunaLabel41;
        private Guna.UI.WinForms.GunaTextBox txt_precoFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel42;
        private Guna.UI.WinForms.GunaTextBox txt_AnoFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel43;
        private Guna.UI.WinForms.GunaTextBox txt_TituloFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel44;
        private Guna.UI.WinForms.GunaTextBox txt_idFilme;
        private Guna.UI.WinForms.GunaLabel gunaLabel45;
        private Guna.UI.WinForms.GunaTextBox txt_CodigoDeBarras;
        private Guna.UI.WinForms.GunaLabel gunaLabel46;
        private Guna.UI.WinForms.GunaButton btn_ProcurarImagem;
        private Guna.UI.WinForms.GunaTextBox txt_diretorio_img;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_descricao;
        private Guna.UI.WinForms.GunaTextBox txt_tipo;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_dtAquisicao;
        private Guna.UI.WinForms.GunaButton btnSalvarGe;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cboxGenero;
        private Guna.UI.WinForms.GunaTextBox txtPersonagem;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaComboBox cboxArtista;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtIdfilmeArtista;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton btnSalvarArtista;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.DataGridView dgvLocado;
        private System.Windows.Forms.DataGridView dgvFilmes;
    }
}