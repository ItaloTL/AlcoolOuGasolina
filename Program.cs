//atividade AlcoolOuGasolina, Italo Trancoso Lopes

using System;
class Program
{
    static void Main()
    {
     Console.Clear();
     Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("--- Etanol ou Gasolina? ---\n");
        Console.ResetColor();

     Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@"Eae meu patrão, vai do que hoje? alcool ou gasolina?
    Aqui é sem desperdício, vamos decidir qual conpensa mais.👍");
        Thread.Sleep(3000);
        Console.WriteLine("bom, agora vamos calcular, insira os valores abaixo e não tome prejuízo.");
        Console.ResetColor();

        decimal precoEtanol = LerPreco("Digite o preço do etanol (R$).....: ");
        decimal precoGasolina = LerPreco("Digite o preço da gasolina (R$)...: ");
        decimal razao = CalcularRazao(precoEtanol, precoGasolina);
        bool valeGasolina = ValePenaGasolina(razao);


        ExibirResultados(razao, valeGasolina);
    }
    static decimal LerPreco(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToDecimal(Console.ReadLine());
    }
    static decimal CalcularRazao(decimal etanol, decimal gasolina)
    {
        return (etanol / gasolina) * 100;
    }
    static bool ValePenaGasolina(decimal razao)
    {
        return razao > 73;
    }


    static void ExibirResultados(decimal razao, bool valeGasolina)
    {
        Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
        Console.WriteLine($"\nRecomendação: É meu chefe ta salgado mesmo em, vai na  {(valeGasolina ? "GASOLINA" : "ETANOL")} que ta compensando.");
    }
}