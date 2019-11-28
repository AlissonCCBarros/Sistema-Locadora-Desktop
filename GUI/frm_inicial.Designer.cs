namespace GUI
{
    partial class frm_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicial));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.txt_devolucao = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_artista = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Funcionario = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1117, 62);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaVSeparator1);
            this.gunaPanel2.Controls.Add(this.gunaImageButton2);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1117, 62);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel1.Location = new System.Drawing.Point(419, 15);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(216, 25);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Super Sistema Locadora";
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaVSeparator1.Location = new System.Drawing.Point(945, 15);
            this.gunaVSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(13, 36);
            this.gunaVSeparator1.TabIndex = 3;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton2.Location = new System.Drawing.Point(1059, 7);
            this.gunaImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.gunaImageButton2.Size = new System.Drawing.Size(55, 50);
            this.gunaImageButton2.TabIndex = 1;
            this.gunaImageButton2.Click += new System.EventHandler(this.GunaImageButton2_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel3.Controls.Add(this.gunaElipsePanel1);
            this.gunaPanel3.Controls.Add(this.gunaPanel5);
            this.gunaPanel3.Location = new System.Drawing.Point(0, 62);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1117, 62);
            this.gunaPanel3.TabIndex = 2;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 69);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(343, 161);
            this.gunaElipsePanel1.TabIndex = 4;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.Controls.Add(this.txt_devolucao);
            this.gunaPanel5.Controls.Add(this.btn_artista);
            this.gunaPanel5.Controls.Add(this.gunaAdvenceButton4);
            this.gunaPanel5.Controls.Add(this.gunaAdvenceButton3);
            this.gunaPanel5.Controls.Add(this.gunaAdvenceButton2);
            this.gunaPanel5.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel5.Controls.Add(this.btn_Funcionario);
            this.gunaPanel5.Location = new System.Drawing.Point(85, 4);
            this.gunaPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(944, 58);
            this.gunaPanel5.TabIndex = 0;
            this.gunaPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel5_Paint);
            // 
            // txt_devolucao
            // 
            this.txt_devolucao.AnimationHoverSpeed = 0.07F;
            this.txt_devolucao.AnimationSpeed = 0.03F;
            this.txt_devolucao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txt_devolucao.BorderColor = System.Drawing.Color.Black;
            this.txt_devolucao.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.txt_devolucao.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txt_devolucao.CheckedBorderColor = System.Drawing.Color.Black;
            this.txt_devolucao.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.txt_devolucao.CheckedImage = null;
            this.txt_devolucao.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.txt_devolucao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txt_devolucao.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_devolucao.FocusedColor = System.Drawing.Color.Empty;
            this.txt_devolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txt_devolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_devolucao.Image = null;
            this.txt_devolucao.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_devolucao.LineBottom = 5;
            this.txt_devolucao.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txt_devolucao.Location = new System.Drawing.Point(798, 0);
            this.txt_devolucao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_devolucao.Name = "txt_devolucao";
            this.txt_devolucao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.txt_devolucao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txt_devolucao.OnHoverForeColor = System.Drawing.Color.White;
            this.txt_devolucao.OnHoverImage = null;
            this.txt_devolucao.OnHoverLineColor = System.Drawing.Color.White;
            this.txt_devolucao.OnPressedColor = System.Drawing.Color.Black;
            this.txt_devolucao.OnPressedDepth = 0;
            this.txt_devolucao.Size = new System.Drawing.Size(142, 58);
            this.txt_devolucao.TabIndex = 6;
            this.txt_devolucao.Text = "Devolução";
            this.txt_devolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_devolucao.Click += new System.EventHandler(this.txt_devolucao_Click);
            // 
            // btn_artista
            // 
            this.btn_artista.AnimationHoverSpeed = 0.07F;
            this.btn_artista.AnimationSpeed = 0.03F;
            this.btn_artista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_artista.BorderColor = System.Drawing.Color.Black;
            this.btn_artista.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_artista.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_artista.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_artista.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btn_artista.CheckedImage = null;
            this.btn_artista.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btn_artista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_artista.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_artista.FocusedColor = System.Drawing.Color.Empty;
            this.btn_artista.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_artista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btn_artista.Image = null;
            this.btn_artista.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_artista.LineBottom = 5;
            this.btn_artista.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_artista.Location = new System.Drawing.Point(665, 0);
            this.btn_artista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_artista.Name = "btn_artista";
            this.btn_artista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btn_artista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_artista.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_artista.OnHoverImage = null;
            this.btn_artista.OnHoverLineColor = System.Drawing.Color.White;
            this.btn_artista.OnPressedColor = System.Drawing.Color.Black;
            this.btn_artista.OnPressedDepth = 0;
            this.btn_artista.Size = new System.Drawing.Size(133, 58);
            this.btn_artista.TabIndex = 5;
            this.btn_artista.Text = "Locação";
            this.btn_artista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_artista.Click += new System.EventHandler(this.btn_artista_Click);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton4.CheckedImage = null;
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton4.Image = null;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineBottom = 5;
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(532, 0);
            this.gunaAdvenceButton4.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnPressedDepth = 0;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(133, 58);
            this.gunaAdvenceButton4.TabIndex = 4;
            this.gunaAdvenceButton4.Text = "Filmes";
            this.gunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton3.CheckedImage = null;
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton3.Image = null;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineBottom = 5;
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(399, 0);
            this.gunaAdvenceButton3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnPressedDepth = 0;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(133, 58);
            this.gunaAdvenceButton3.TabIndex = 3;
            this.gunaAdvenceButton3.Text = "Funcionário";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineBottom = 5;
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(266, 0);
            this.gunaAdvenceButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnPressedDepth = 0;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(133, 58);
            this.gunaAdvenceButton2.TabIndex = 2;
            this.gunaAdvenceButton2.Text = "Cliente";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineBottom = 5;
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(133, 0);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnPressedDepth = 0;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(133, 58);
            this.gunaAdvenceButton1.TabIndex = 1;
            this.gunaAdvenceButton1.Text = "Artista";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btn_Funcionario
            // 
            this.btn_Funcionario.AnimationHoverSpeed = 0.07F;
            this.btn_Funcionario.AnimationSpeed = 0.03F;
            this.btn_Funcionario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_Funcionario.BorderColor = System.Drawing.Color.Black;
            this.btn_Funcionario.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_Funcionario.Checked = true;
            this.btn_Funcionario.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_Funcionario.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Funcionario.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btn_Funcionario.CheckedImage = null;
            this.btn_Funcionario.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btn_Funcionario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Funcionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Funcionario.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_Funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btn_Funcionario.Image = null;
            this.btn_Funcionario.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Funcionario.LineBottom = 5;
            this.btn_Funcionario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_Funcionario.Location = new System.Drawing.Point(0, 0);
            this.btn_Funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Funcionario.Name = "btn_Funcionario";
            this.btn_Funcionario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btn_Funcionario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Funcionario.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Funcionario.OnHoverImage = null;
            this.btn_Funcionario.OnHoverLineColor = System.Drawing.Color.White;
            this.btn_Funcionario.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Funcionario.OnPressedDepth = 0;
            this.btn_Funcionario.Size = new System.Drawing.Size(133, 58);
            this.btn_Funcionario.TabIndex = 0;
            this.btn_Funcionario.Text = "Genero";
            this.btn_Funcionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Funcionario.Click += new System.EventHandler(this.btn_Funcionario_Click);
            // 
            // frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1117, 868);
            this.ControlBox = false;
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Funcionario;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaAdvenceButton btn_artista;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton txt_devolucao;
    }
}

