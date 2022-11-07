Console.Clear();
bool i = false;
double valor, soma = 0;
do{
    Console.Write("Informe uma valor: ");
    valor = Convert.ToDouble(Console.ReadLine());

    if(valor == 0){
        Console.WriteLine($"Valor total: {soma}");
        Console.WriteLine("Pressione qualquer teclar par finlizar o programa!");
        Console.ReadKey();
        Console.Clear();
        i = true;
    }else{
        soma = soma + valor;
    }

}while(i == false);