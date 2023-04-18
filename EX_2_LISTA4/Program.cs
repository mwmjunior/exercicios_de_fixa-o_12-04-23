
using System.Globalization;

static float CalculaTotal( string C, float L)
{
    switch (C)
           
            {
            case "G" :
                
                if (L < 20)
                {
                    return (L * 5.30f) * 0.96f ;
                }

                else
                {
                    return (L * 5.30f) * 0.94f ;
                }


            case "E" :
                
                if (L < 20)
                {
                    return (L * 4.90f) * 0.97f ;
                }

                else
                {
                    return (L * 4.90f) * 0.95f ;
                }


            default:
                return 0;
            }    
    
}

Console.Write($"Olá, digite o combustivel[ G=Gasolina ou E=Etanol ]: ");
string combustivel =  (Console.ReadLine()) .ToUpper ();

Console.WriteLine();

Console.Write($"Digite a quantidade de litros abastecidas: ");
float litros = float.Parse(Console.ReadLine());

Console.WriteLine();

float imprime_total = CalculaTotal (combustivel, litros);
Console.Write( $"O valor total do abastecimento {Math.Round(imprime_total, 2).ToString("C", new CultureInfo("pt-BR"))}" );



Console.WriteLine();
Console.Write("Processo concluido, pressione [ENTER] para sair.");

while (Console.ReadKey().Key != ConsoleKey.Enter) {}