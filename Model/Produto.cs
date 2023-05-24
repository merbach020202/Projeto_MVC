namespace Console_MVC.Model
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo definido    
        private const string PATH = "Database/Produto.csv";         //constante é um valor que não varia, ou seja, não é uma variável
    
        //criar um construtor
        public Produto()
        {
            //obter o caminhio da pasta
            string pasta = PATH.Split("/")[0]; //Database

            //se não existir uma pasta Database, então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
    
        public List<Produto> Ler()
        {
            //instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            //para a leitura das linhas
            foreach (var item in linhas)
            {
                //antes do split
                //001;Coca;6,50

                //array que recebe os itens da linha separando por ";"
                string[] atributos = item.Split(";");

                //após o split 
                //atributo[0] = "001"
                //atributo[1] = "Coca"
                //atributo[2] = "6,50"

                //instancia de objeto de produto
                Produto p = new Produto();

                //atribuir os dados dentro de um objeto
                p.Codigo = int.Parse(atributos[0]);//001
                p.Nome = atributos[1];//Coca
                p.Preco = float.Parse(atributos[2]);//6.50F

                //adicionaos objetos dentro da lista
                produtos.Add(p);
            }
            
            return produtos;
        }    
    }
}
