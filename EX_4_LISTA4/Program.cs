
using System;
using System.Linq;


const int numeroQtd = 2;
int[] numeros = new int[numeroQtd];


Console.WriteLine( "Informe 10 números inteiros:" );

for( int i = 0; i < numeroQtd; i++ )
{

    Console.Write( ( i + 1 ) + "º número:" );
    numeros[i] = Convert.ToInt32( Console.ReadLine() );

}

Console.WriteLine("===================================");
foreach(int num in numeros)
            {
                Console.Write(num+"  ");
            }
Console.WriteLine();
Console.WriteLine("===================================");

Console.WriteLine("O menor número é: "  + numeros.Min());
Console.WriteLine("O maior número é: "  + numeros.Max());




