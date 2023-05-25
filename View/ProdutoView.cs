using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        //método para exibir os dados da lista de produtos
        public void Listar(List<Produto> produto)
        {
            Console.Clear();
            //foreach para ler a lista passada como parâmetro do método
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:c}");
            }
        }

        public Produto cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nInforme o nome: ");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"\nInforme o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }
    }
}