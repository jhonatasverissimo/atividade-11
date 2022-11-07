
Console.Clear();
int resultado = 0, valor;
for(int i = 1; i <=10; i++){

    Console.WriteLine($"Informe o {i} valor: ");
    valor = Convert.ToInt32(Console.ReadLine());

    if(valor > 10){
        resultado = resultado + valor;
    }
        
}

Console.WriteLine($"Resultado final é: {resultado}");

