Console.Clear();
int menor = 0, maior = 0,valor;

for(int i = 1; i <= 20; i++){

    Console.WriteLine($"Informe o {i} valor: ");
    valor = Convert.ToInt32(Console.ReadLine());


    if(i == 1){
        menor = valor;
        maior = valor;
    }else{
        
        if(valor <= menor){
            menor = valor;
        }

        if(valor > maior){
            maior = valor;
        }

    }

}

Console.WriteLine($"Menor valor digitado foi: {menor}");
Console.WriteLine($"Maior valor digitado foi: {maior}");