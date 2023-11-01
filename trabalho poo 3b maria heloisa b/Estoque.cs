public class Estoque{
    private List<Produto> produtos;
    public List<Produto> Produtos{
        get{return this.produtos;}
    }
    public  Estoque(){
        this.produtos = new List<Produto>();
    }
    public void  AdicionarProduto(Produto produto){
        produtos.Add(produto);
    }
    public void RemoverProduto(int idProduto){
        for( int i = 0; produtos.Count; i++){
            if(Produtos[i].id==idProduto) {
                Produtos.Remover(i);
                break;
            }
        }
    }
    public void VerificarEstoqueGeral(){
        Console.WriteLine("Estoque geral:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID:{produto.id}, Nome: {produto.nome} , preco:{produto.preco:C}, Quantidade: {produto.VerificarEstoque()}");
        }   
    } 

}  