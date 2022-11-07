Console.Clear();

int i=1;
double nota=0, valor=0,media =0;
int resposta=0;

do{
inserir:
Console.WriteLine($"Informe a {i}: ");
nota = Convert.ToDouble(Console.ReadLine()); 

if(nota>0 && nota<=10){
    manter:
    Console.WriteLine("Deseja Manter essa nota?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    resposta = Convert.ToInt32(Console.ReadLine());

    if(resposta == 1 ){
        valor+= nota;
    }else if(resposta == 2){
        goto inserir;
        Console.Clear();
    }else{
        Console.Clear();
        goto manter;
    }

}else{
    Console.WriteLine("Nota inválida");
    Console.ReadKey();

    goto inserir;
}


i++;
}while(i<=4);

media = valor /4;
Console.WriteLine($"Médi Final: {media}");