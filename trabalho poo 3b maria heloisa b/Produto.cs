//Atributos
public abstract class Produto{
    public int Id{get;set;}
    public string Nome{get;set;}
    public double Preco{get;set;}
    public int Quantidade{get;set;}

 //Construtores
 public Produto(int id, string nome, double preco, int quantidade){
  Id = id;
  Nome = nome;
  Preco = preco;
  Quantidade = quantidade;
}
//Métodos
  public  void AtualizarEstoque(int quantidade){
    Quantidade -= quantidade;
  }
  public  void VerificarEstoque(){
    Console.WriteLine("unidades");
  }
 
}

