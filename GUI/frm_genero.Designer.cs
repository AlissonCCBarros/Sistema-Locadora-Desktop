namespace GUI
{
    partial class frm_genero
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
            this.dgvGen = new System.Windows.Forms.DataGridView();
            this.IDGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_atualizar = new Guna.UI.WinForms.GunaButton();
            this.btn_ExcluirGenero = new Guna.UI.WinForms.GunaButton();
            this.btn_BuscarGenero = new Guna.UI.WinForms.GunaButton();
            this.btn_BuscarArtista = new Guna.UI.WinForms.GunaButton();
            this.txt_idGenero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel45 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Genero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel46 = new Guna.UI.WinForms.GunaLabel();
            this.Ep_Filme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).BeginInit();
            this.SuspendLayout();
            // 
            // Ep_Filme
            // 
            this.Ep_Filme.BackColor = System.Drawing.Color.Transparent;
            this.Ep_Filme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.Ep_Filme.Controls.Add(this.dgvGen);
            this.Ep_Filme.Controls.Add(this.btn_atualizar);
            this.Ep_Filme.Controls.Add(this.btn_ExcluirGenero);
            this.Ep_Filme.Controls.Add(this.btn_BuscarGenero);
            this.Ep_Filme.Controls.Add(this.btn_BuscarArtista);
            this.Ep_Filme.Controls.Add(this.txt_idGenero);
            this.Ep_Filme.Controls.Add(this.gunaLabel45);
            this.Ep_Filme.Controls.Add(this.txt_Genero);
            this.Ep_Filme.Controls.Add(this.gunaLabel46);
            this.Ep_Filme.Location = new System.Drawing.Point(-1, -1);
            this.Ep_Filme.Margin = new System.Windows.Forms.Padding(0);
            this.Ep_Filme.Name = "Ep_Filme";
            this.Ep_Filme.Size = new System.Drawing.Size(1400, 992);
            this.Ep_Filme.TabIndex = 39;
            this.Ep_Filme.Paint += new System.Windows.Forms.PaintEventHandler(this.Ep_Filme_Paint);
            // 
            // dgvGen
            // 
            this.dgvGen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGenero,
            this.Titulo});
            this.dgvGen.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGen.Location = new System.Drawing.Point(375, 337);
            this.dgvGen.Name = "dgvGen";
            this.dgvGen.RowHeadersWidth = 51;
            this.dgvGen.RowTemplate.Height = 24;
            this.dgvGen.Size = new System.Drawing.Size(360, 290);
            this.dgvGen.TabIndex = 67;
            // 
            // IDGenero
            // 
            this.IDGenero.DataPropertyName = "Codigo";
            this.IDGenero.HeaderText = "ID Gênero";
            this.IDGenero.MinimumWidth = 6;
            this.IDGenero.Name = "IDGenero";
            this.IDGenero.Width = 90;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Nome";
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
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
            this.btn_atualizar.Location = new System.Drawing.Point(686, 223);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_atualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_atualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_atualizar.OnHoverImage = null;
            this.btn_atualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_atualizar.Size = new System.Drawing.Size(181, 42);
            this.btn_atualizar.TabIndex = 66;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_ExcluirGenero
            // 
            this.btn_ExcluirGenero.AnimationHoverSpeed = 0.07F;
            this.btn_ExcluirGenero.AnimationSpeed = 0.03F;
            this.btn_ExcluirGenero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_ExcluirGenero.BorderColor = System.Drawing.Color.Black;
            this.btn_ExcluirGenero.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ExcluirGenero.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ExcluirGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_ExcluirGenero.ForeColor = System.Drawing.Color.White;
            this.btn_ExcluirGenero.Image = null;
            this.btn_ExcluirGenero.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ExcluirGenero.Location = new System.Drawing.Point(461, 223);
            this.btn_ExcluirGenero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExcluirGenero.Name = "btn_ExcluirGenero";
            this.btn_ExcluirGenero.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_ExcluirGenero.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ExcluirGenero.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ExcluirGenero.OnHoverImage = null;
            this.btn_ExcluirGenero.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ExcluirGenero.Size = new System.Drawing.Size(177, 42);
            this.btn_ExcluirGenero.TabIndex = 65;
            this.btn_ExcluirGenero.Text = "Excluir";
            this.btn_ExcluirGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ExcluirGenero.Click += new System.EventHandler(this.btn_ExcluirGenero_Click);
            // 
            // btn_BuscarGenero
            // 
            this.btn_BuscarGenero.AnimationHoverSpeed = 0.07F;
            this.btn_BuscarGenero.AnimationSpeed = 0.03F;
            this.btn_BuscarGenero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarGenero.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarGenero.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BuscarGenero.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BuscarGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_BuscarGenero.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarGenero.Image = null;
            this.btn_BuscarGenero.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BuscarGenero.Location = new System.Drawing.Point(243, 223);
            this.btn_BuscarGenero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarGenero.Name = "btn_BuscarGenero";
            this.btn_BuscarGenero.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarGenero.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarGenero.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarGenero.OnHoverImage = null;
            this.btn_BuscarGenero.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarGenero.Size = new System.Drawing.Size(160, 42);
            this.btn_BuscarGenero.TabIndex = 64;
            this.btn_BuscarGenero.Text = "Inserir";
            this.btn_BuscarGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarGenero.Click += new System.EventHandler(this.btn_BuscarGenero_Click);
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
            this.btn_BuscarArtista.Location = new System.Drawing.Point(878, 132);
            this.btn_BuscarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarArtista.Name = "btn_BuscarArtista";
            this.btn_BuscarArtista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_BuscarArtista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BuscarArtista.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BuscarArtista.OnHoverImage = null;
            this.btn_BuscarArtista.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BuscarArtista.Size = new System.Drawing.Size(100, 42);
            this.btn_BuscarArtista.TabIndex = 63;
            this.btn_BuscarArtista.Text = "Buscar";
            this.btn_BuscarArtista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BuscarArtista.Click += new System.EventHandler(this.btn_BuscarArtista_Click);
            // 
            // txt_idGenero
            // 
            this.txt_idGenero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_idGenero.BorderColor = System.Drawing.Color.Silver;
            this.txt_idGenero.BorderSize = 0;
            this.txt_idGenero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idGenero.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_idGenero.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_idGenero.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_idGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_idGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_idGenero.Location = new System.Drawing.Point(776, 133);
            this.txt_idGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idGenero.Name = "txt_idGenero";
            this.txt_idGenero.PasswordChar = '\0';
            this.txt_idGenero.Size = new System.Drawing.Size(79, 41);
            this.txt_idGenero.TabIndex = 60;
            // 
            // gunaLabel45
            // 
            this.gunaLabel45.AutoSize = true;
            this.gunaLabel45.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel45.Location = new System.Drawing.Point(733, 142);
            this.gunaLabel45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel45.Name = "gunaLabel45";
            this.gunaLabel45.Size = new System.Drawing.Size(31, 23);
            this.gunaLabel45.TabIndex = 59;
            this.gunaLabel45.Text = "ID:";
            // 
            // txt_Genero
            // 
            this.txt_Genero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_Genero.BorderColor = System.Drawing.Color.Silver;
            this.txt_Genero.BorderSize = 0;
            this.txt_Genero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Genero.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txt_Genero.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Genero.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_Genero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_Genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.txt_Genero.Location = new System.Drawing.Point(212, 133);
            this.txt_Genero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.PasswordChar = '\0';
            this.txt_Genero.Size = new System.Drawing.Size(463, 41);
            this.txt_Genero.TabIndex = 58;
            // 
            // gunaLabel46
            // 
            this.gunaLabel46.AutoSize = true;
            this.gunaLabel46.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaLabel46.Location = new System.Drawing.Point(111, 142);
            this.gunaLabel46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel46.Name = "gunaLabel46";
            this.gunaLabel46.Size = new System.Drawing.Size(70, 23);
            this.gunaLabel46.TabIndex = 57;
            this.gunaLabel46.Text = "Genero:";
            // 
            // frm_genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 767);
            this.Controls.Add(this.Ep_Filme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_genero";
            this.Text = "frm_incial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Ep_Filme.ResumeLayout(false);
            this.Ep_Filme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel Ep_Filme;
        private Guna.UI.WinForms.GunaButton btn_atualizar;
        private Guna.UI.WinForms.GunaButton btn_ExcluirGenero;
        private Guna.UI.WinForms.GunaButton btn_BuscarGenero;
        private Guna.UI.WinForms.GunaButton btn_BuscarArtista;
        private Guna.UI.WinForms.GunaTextBox txt_idGenero;
        private Guna.UI.WinForms.GunaLabel gunaLabel45;
        private Guna.UI.WinForms.GunaTextBox txt_Genero;
        private Guna.UI.WinForms.GunaLabel gunaLabel46;
        private System.Windows.Forms.DataGridView dgvGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
    }
}