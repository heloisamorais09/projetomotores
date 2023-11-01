public class program{
    static void Main(){
    Console.WriteLine("Menu:");
    Console.WriteLine("1- Adicionar produto físico ao estoque");
    Console.WriteLine("2- Adicionar  produto digital ao estoque");
    Console.WriteLine("3- Remover produto do estoque");
    Console.WriteLine("4- Verificar estoque geral");
    Console.WriteLine("5- Realizar venda");
    Console.WriteLine("6- Verificar vendas");
    Console.WriteLine("7- Verificar lucros");
    Console.WriteLine("8-Sair");
    Console.WriteLine(" Por favor, escolha uma opção:");
    int op= int.Parse(Console.ReadLine());
    

    if(op==1){
        Console.WriteLine("Adicione produto fisico ao estoque");
        Console.Write("Digite o  id do produto:");
        int idProdutoFisico = int.Parse(Console.ReadLine());
        console.Write("dIgite o nome do prooduto:");
        string nomeProdutoFisico = Console.ReadLine();
        Console.Write("Digite o preço doproduto:");
        double precoProdutofisico = double.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade do produto:");
        int quantidadeProdutoFisico = int.Parse(Console.ReadLine());

        ProdutoFisico ProdutoFisico = new ProdutoFisico(idProdutoFisico , nomeProdutoFisico , precoProdutoFisico ,quantidadeProdutoFisico);
        estoque.AdicionarProduto(ProdutoFisico);

        Console.WriteLine("Produto adicionado ao estoque com sucesso");
        Console.WriteLine();
        break;

    }
    else if(op==2){
        Console.WriteLine("Adicionar produto digital ao estoque");
        Console.Write(" Digite o id do produto:");
        int idProdutoDigital = int.Parse(Console.ReadLine());
        console.Write("dIgite o nome do prooduto:");
        string nomeProdutoDigite = Console.ReadLine();
        Console.Write("Digite o preço doproduto:");
        double precoProdutoDigital = double.Parse(Console.ReadLine());
        

        ProdutoDigital produtoDigital = new ProdutoDigital(idPd , nomePd , precoPd ,quantidadePd );
        estoque.AdicionarProduto(produtoDigital);

        Console.WriteLine("Produto digital adicionado ao estoque com sucesso");
        Console.WriteLine();
        break;
    }
    else if (op==3){
        Console.WriteLine("Remover produto do estoque");
        Console.Write("Digite o id do produto a ser removido:");
        int produtoRemover = int.Parse(Console.ReadLine());
        estoque.RemoverProduto(idProdutoRemover);
        Console.WriteLine("Produto removido com sucesso");
        Console.WriteLine();
        break;
    }
    else if(op==4){
        Console.WriteLine("Verificar estoque geral");
        estoque.VerificarEstoqueGeral();
        Console.WriteLine();
        break;
    }
    else if(op==5){
        estoque.VerificarEstoque();
        Console.Write("id do produto a ser vendido:");
        int Iddoproduto = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade vendida:");
        int QuantidadeVenda = int.Parse(Console.ReadLine());
        Estoque nIddoproduto = new Estoque(Iddoproduto);
        estoque.AdicionarProduto(nIddoproduto);
        RegistroVenda nQuantidade = new RegistroVenda(QuantidadeVenda);
        registrovenda.AdicionarVenda(nQuantidade);
        estoque.AdicionarProduto(nIddoproduto);
        Console.WriteLine("venda realizada");
        Console.WriteLine();
        break;
        }
    else if(op==6){
        Console.WriteLine(" Verificar vendas ");
        RegistroVendas.VerificarVendas();
        Console.WriteLine();
    }
    else if(op==7){
        Console.WriteLine(" Verificar lucro");
        double lucroTotal = RegistroVendas.CalcularLucro();
        Console.WriteLine($" o lucro total é:{lucroTotal}");
        Console.WriteLine();
        break;
    }
    else if(op==8){
        sair = true;
    }
    else{
        Console.WriteLine("Opção invalida!");
        Console.WriteLine();
        break;
    }
    }
    
}    
