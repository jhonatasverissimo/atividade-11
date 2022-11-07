int n, i=1;

inicio:
Console.Clear();
Console.Write("Informe um valor positivo e MAIOR que 1: ");
n = Convert.ToInt32(Console.ReadLine());

if(n > i){
    for(i = 1; i<= n; i++){
        Console.WriteLine(i);
    }

}else{
    Console.WriteLine("Valor inválido!");
    Console.WriteLine("Pressione qualquer tecla!");
    Console.ReadKey();
    goto inicio;    
}




