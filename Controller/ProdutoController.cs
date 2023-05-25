using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoView
        //o controller precisa conhecer a model e a view de produto

        //produto Model
        Produto produto = new Produto();

        //produto View
        ProdutoView produtoView = new ProdutoView();
        
        //método controlador para acessar a listagem de produto
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model
            List<Produto> produtos = produto.Ler();

            //chamada do método de exibição(VIEW) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }
    
        //método controlador para acessar o cadastro de produto
        public void cadastrarProduto()
        {
            Produto novoProduto = produtoView.cadastrar();

            produto.Inserir(novoProduto);
        }
    
    
    }
}