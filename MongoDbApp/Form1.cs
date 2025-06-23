using MongoDB.Driver;
using MongoDbApp.Models;

namespace MongoDbApp
{
    public partial class Form1 : Form
    {
        private IMongoCollection<Produto> _colecaoProdutos;
        public Form1()
        {
            InitializeComponent();
            var produto = new MongoClient("mongodb://localhost:27017");
            var database = produto.GetDatabase("Cadastro");
            _colecaoProdutos = database.GetCollection<Produto>("produtos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                NomeProduto = txtNomeProduto.Text,
                Descricao = txtDescricao.Text,
                Marca = txtMarca.Text,
                Quantidade = txtQuantidade.Text
            };
            _colecaoProdutos.InsertOne(produto);
            MessageBox.Show("Produto adicionado com sucesso");
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtQuantidade.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstProduto.Items.Clear();
            var produtos = _colecaoProdutos.Find(_ => true).ToList();
            foreach (var produto in produtos)
            {
                lstProduto.Items.Add($"{produto.NomeProduto} - {produto.Marca} - {produto.Quantidade} - {produto.Descricao}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFormulario();
        }
        private void ExcluirFormulario()
        {
            lstProduto.dr
        }
    }
}
