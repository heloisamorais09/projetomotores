public class ProdutoDigital: Produto{
    public ProdutoDigital(int id, string nome, double preco, int quantidade): base (id, nome, preco, quantidade){

    }
    public  void AtualizarEstoque(int quantidade){
        Quantidade-= quantidade;
    }
    public  void VerificarEstoque(){
        Console.WriteLine("Atualizar estoque");
    }
    
}    
