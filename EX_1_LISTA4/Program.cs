static string ValidaIdade ( int a )
{
    if( a < 15 )
    {
        return (" Não, você não poderá votar ");
    } 

     else if( a >= 16 && a <= 17 ) 
    {
        return (" Sim, você poderá votar! [VOTO FACULTATIVO]");
    } 

     else if( a >= 18 && a < 70 ) 
    {
        return (" Sim, você poderá votar ! [VOTO OBRIGATÓRIO]");
    } 
  
    else 
    {
       return ("Sim, você poderá votar! [VOTO FACULTATIVO]"); ;
    }
    
}

Console.Write($"Olá, digite sua idade para saber se você poderá votar neste ano: ");
int idade = int.Parse(Console.ReadLine() ) ;

string exibir_resultado = ValidaIdade(idade);

Console.WriteLine();
Console.WriteLine(exibir_resultado);

