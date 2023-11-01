public class Venda{
    public int Data{get; set;}
    public int IdProduto{get; set;}
    public int QuantidadeVendida{get; set;}
    public double ValorTotal{get; set;}

    public Venda(int data, int IdProduto, int QuantidadeVendida, double ValorTotal){
        Data= data;
        IdProduto = idProduto;
        QuantidadeVendida = quantidadeVendida;
        ValorTotal = valorTotal;
    }
}