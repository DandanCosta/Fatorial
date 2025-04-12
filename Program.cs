double n, fatorial, i ;

Console.Write("Insira o numero para ser fatorado: ");
n = double.Parse(Console.ReadLine()!);

fatorial = n;

if (n == 0){
    fatorial = 1;
    Console.WriteLine($"Fatorial de {n} é igual a {fatorial}");
} 
else if (n < 0){
    Console.WriteLine("Este numro é negativo e não pode ssr fatorado");
}
else{
    for (i = n - 1;i >= 1; i--){
    fatorial = fatorial * i;
    }
    Console.WriteLine($"Fatorial de {n} é igual a {fatorial}");
}

    


