using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using System.IO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frm_Filme : Form
    {
        public frm_Filme()
        {
            InitializeComponent();

            carregaCombo();

            carregaComboArtista();

            CarregarDGVHis();

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private void btn_ProcurarImagem_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    txt_diretorio_img.Text += arquivo;
                }
            }
        }

        private void btn_inserirFIlme_Click(object sender, EventArgs e)
        {
            Image imagem = Image.FromFile(txt_diretorio_img.Text);
            var ms = new MemoryStream();
            imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            var bytes = ms.ToArray();

            var ImageMemoryStream = new MemoryStream(bytes);

            Image.FromStream(ImageMemoryStream);


            Filme objFilme = new Filme();
            objFilme.CodigoDeBarras = txt_CodigoDeBarras.Text;
           
            objFilme.Titulo = txt_TituloFilme.Text;
            objFilme.Ano = Convert.ToInt32(txt_AnoFilme.Text);
            objFilme.Tipo = txt_tipo.Text;
            
            objFilme.Preco = Convert.ToDecimal(txt_precoFilme.Text);
            objFilme.DataAdiquirida = Convert.ToDateTime(txt_dtAquisicao.Text);
            objFilme.ValorDeCusto = Convert.ToDecimal(txt_CustoFilme.Text);
            objFilme.Situacao = cb_SituacaoFilme.Text;
            objFilme.Diretor = txt_DiretorFilme.Text;
            objFilme.Descricao = txt_descricao.Text;
            objFilme.Img_Filme = bytes;

            FilmeDAL fDal = new FilmeDAL();
            fDal.InserirFilme(objFilme);
            MessageBox.Show("Cadastrado com sucesso!!");
        }

        private void btn_BuscarFilme_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_idFilme.Text);

            FilmeDAL fDAL = new FilmeDAL();

            Filme objFilme = fDAL.PesquisarFilmes(codigo);

            if (objFilme != null)
            {
                txt_TituloFilme.Text = objFilme.Titulo;
                txt_AnoFilme.Text = Convert.ToString(objFilme.Ano);
                txt_dtAquisicao.Text = Convert.ToString(objFilme.DataAdiquirida);
                txt_DiretorFilme.Text = objFilme.Diretor;
                txt_tipo.Text = objFilme.Tipo;
                txt_CustoFilme.Text = Convert.ToString(objFilme.ValorDeCusto);
                txt_precoFilme.Text = Convert.ToString(objFilme.Preco);
                txt_diretorio_img.Text = Convert.ToString(objFilme.Img_Filme);
                txt_descricao.Text = objFilme.Descricao;
                txt_CodigoDeBarras.Text = Convert.ToString(objFilme.CodigoDeBarras);
                cb_SituacaoFilme.Text = Convert.ToString(objFilme.Situacao);

                dgvFilmes.DataSource = objFilme.ListFilmesGen;
                dgvLocado.DataSource = objFilme.ListFilmeCli;
            }
            else
            {
                MessageBox.Show("Filme não foi encontrado!");

            }

            
        }

        private void Cb_SituacaoFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_excluirFilme_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_idFilme.Text);

            FilmeDAL pDAL = new FilmeDAL();

            pDAL.ExcluirFilme(codigo);
        }

        private void btn_AtualizarFilme_Click(object sender, EventArgs e)
        {
            Image imagem = Image.FromFile(txt_diretorio_img.Text);
            var ms = new MemoryStream();
            imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            var bytes = ms.ToArray();

            var ImageMemoryStream = new MemoryStream(bytes);

            Image.FromStream(ImageMemoryStream);
            Filme objFilme = new Filme();

            objFilme.Codigo = Convert.ToInt32(txt_idFilme.Text);
            objFilme.CodigoDeBarras = txt_CodigoDeBarras.Text;
            objFilme.Titulo = txt_TituloFilme.Text;
            objFilme.Ano = Convert.ToInt32(txt_AnoFilme.Text);
            objFilme.Tipo = txt_tipo.Text;
            objFilme.Preco = Convert.ToDecimal(txt_precoFilme.Text);
            objFilme.DataAdiquirida = Convert.ToDateTime(txt_dtAquisicao.Text);
            objFilme.ValorDeCusto = Convert.ToDecimal(txt_CustoFilme.Text);
            objFilme.Situacao = cb_SituacaoFilme.Text;
            objFilme.Diretor = txt_DiretorFilme.Text;
            objFilme.Descricao = txt_descricao.Text;
            objFilme.Img_Filme = bytes;


            FilmeDAL fDAL = new FilmeDAL();
            fDAL.AtualizarFilme(objFilme);

            MessageBox.Show("Filme atualizado com sucesso!");

            
        }

        private void Ep_Filme_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carregaCombo()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";

            DataTable dtTabelas = new DataTable();

            
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Generos ORDER BY Nome ASC", conn);

            //preenche o DataTable
            da.Fill(dtTabelas);

            conn.Close();

            //carrega as informacoes no combo
            cboxGenero.DataSource = dtTabelas;
            cboxGenero.DisplayMember = "Nome";
            cboxGenero.ValueMember = "Id_genero";

        }

        private void btnSalvarGe_Click(object sender, EventArgs e)
        {
            GeneroFilme objGeneroFilme = new GeneroFilme();
            objGeneroFilme.IdGenero = Convert.ToInt32(cboxGenero.SelectedValue);
            objGeneroFilme.IdFilme = Convert.ToInt32(txt_GeneroFilme.Text);

            FilmeDAL fDal = new FilmeDAL();
            fDal.InserirFilmeGenero(objGeneroFilme);
            MessageBox.Show("Cadastrado com sucesso!!");
        }

        private void carregaComboArtista()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";

            DataTable dtTabelas = new DataTable();


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Artistas ORDER BY Nome ASC", conn);

            //preenche o DataTable
            da.Fill(dtTabelas);

            conn.Close();

            //carrega as informacoes no combo
            cboxArtista.DataSource = dtTabelas;
            cboxArtista.DisplayMember = "Nome";
            cboxArtista.ValueMember = "Id_Artista";

        }

        private void btnSalvarArtista_Click(object sender, EventArgs e)
        {
            ArtistaFilme objArtistaFilme = new ArtistaFilme();
            objArtistaFilme.IdArtista = Convert.ToInt32(cboxArtista.SelectedValue);
            objArtistaFilme.IdFilme = Convert.ToInt32(txtIdfilmeArtista.Text);
            objArtistaFilme.Personagem = txtPersonagem.Text.ToString();

            ArtistaDAL aDal = new ArtistaDAL();
            aDal.InserirArtistaFilme(objArtistaFilme);
            MessageBox.Show("Cadastrado com sucesso!!");
        }

        private void CarregarDGVHis()
        {
            FilmeDAL fDAL = new FilmeDAL();

            dgvHistorico.DataSource = fDAL.ListarFilmesTop();
        }
    }
}
