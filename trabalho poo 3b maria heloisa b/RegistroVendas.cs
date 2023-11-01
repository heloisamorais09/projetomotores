public class RegistroVendas{
    private List<Venda> vendas{
        get{return this.vendas;}
    }
     public  RegistroVendas(){
        this.vendas= new List<Venda>();
    }
    public void  AdicionarVenda(Venda venda){
        vendas.Add(venda);
    }        
    public void  RemoverVenda(Venda venda){
        vendas.Remove(venda);
    } 
    public void VerificarVendas(){
        foreach (ver venda in vendas){
            Console.WriteLine($" Data:{venda.Data} , ID:{venda.idProduto}, Quantidade: {venda.Quantidade}, Valor Total:{venda.ValorTotal}");
    }    }
        
   public double CalcularLucro()
    {
        double lucro = 0.0;
        foreach (var venda in vendas)
        {
            lucro += venda.ValorTotal;
        }
        return lucro;
    }    
}