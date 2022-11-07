Console.Clear();
int negativos=0, i=1, valor=0;

while (i <= 10)
{
    Console.WriteLine($"Informe o  valor {i}: ");
    valor = Convert.ToInt32(Console.ReadLine());

    if(valor < 0){
        negativos = negativos +1;
    }
    i++;
}

Console.WriteLine($"Tem {negativos} negativos.");