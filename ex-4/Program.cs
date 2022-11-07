Console.Clear();
int maiores=0, i=1, idade=0;
while (i <= 10)
{
    Console.WriteLine($"Informe a idade da pessoa {i}: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade > 18){
        maiores = maiores +1;
    }
    i++;
}

Console.WriteLine($"Tem {maiores} pessoas maiores que 18 anos.");



