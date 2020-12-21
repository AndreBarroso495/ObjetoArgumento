using System;
using ObjetoArgumento.classes;

namespace ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
           
         Produto p1 = new Produto(1, "Iphone 12", 6000f);
         Produto p2 = new Produto(2, "Samsung Galaxy S20", 3500f);
         Produto p3 = new Produto(3, "Motorola Moto G9 Plus", 2000f);

         Carrinho carrinho = new Carrinho();
         carrinho.AdicionarProduto(p1);
         carrinho.AdicionarProduto(p2);
         carrinho.AdicionarProduto(p3);

         carrinho.MostrarProdutos();
            
        }
    }
}
