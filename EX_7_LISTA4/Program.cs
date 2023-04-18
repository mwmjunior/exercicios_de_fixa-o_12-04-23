
using System;
using System.Linq;


float[] numeros = new float [2];
float[] inverso = new float [2];


for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"Informe o {i + 1} º numero: ");
    numeros[i] = float.Parse(Console.ReadLine()) ;

    inverso = Enumerable.Reverse(numeros).ToArray();
   
    

}

Console.WriteLine();
Console.WriteLine(String.Join(',', numeros));
Console.WriteLine();
Console.WriteLine(String.Join(',', inverso));
Console.WriteLine(str);



