Console.Clear();
bool i = false;
double valor;
do{
    Console.Write("Informe uma valor:");
    valor = Convert.ToDouble(Console.ReadLine());

    if(valor <=1){
        i = true;
        Console.WriteLine("Pressione qualquer teclar par finlizar o programa!");
        Console.ReadKey();
    }

}while(i == false);
