
using System.Globalization;



static void BarraCarregamento (string texto, int quantidadePontinhos, int tempo)

        {
            Console.Write(texto);
            
        

        for (var i= 0; i < quantidadePontinhos; i++)

        {
            Console.Write($".");
            Thread.Sleep(tempo);
        
        }

        }


        BarraCarregamento ("Carregando", 15,400);


Console.Clear();



static float CalculaTotal( float qtd, float uni)
{
      if ( qtd <= 5)
        {
        return (qtd * uni) * 0.98f ;
        }

        else if ( qtd > 5 && qtd <=10 )

        {
         return (qtd * uni) * 0.97f ;   
        }

        else
        {  
        return (qtd * uni) * 0.95f ;  
        }  
    
}

Console.Write($"Olá, digite o nome do produto adquirido: ");
string produto =  (Console.ReadLine()) .ToUpper ();

Console.WriteLine();

Console.Write($"Digite a quantidade, quanto maior a quantidade adquirida, melhor o preço !: ");
float quantidade = float.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write($"Digite o preço unitário do produto: ");
float preco_unitario = float.Parse(Console.ReadLine());

Console.WriteLine();

float imprime_total = CalculaTotal (quantidade, preco_unitario);

Console.Clear();

Console.WriteLine (@$"
|----------------------------------------------|
|              LOJA ???????                    |
|----------------------------------------------|
     PRODUTO: {produto}                              
     QUANTIDADE: {quantidade} unidades                        
     PREÇO UNITÁRIO: {Math.Round(preco_unitario, 2).ToString("C", new CultureInfo("pt-BR"))}  
     TOTAL:{Math.Round(imprime_total, 2).ToString("C", new CultureInfo("pt-BR"))} reais                       
                               
 
");

Console.Write("Processo concluido, pressione [ENTER] para sair.");

while (Console.ReadKey().Key != ConsoleKey.Enter) {}