// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


*/
Console.WriteLine("Ingrese un número");
float num1= (float) Convert.ToDouble(Console.ReadLine());
Console.WriteLine("eliga una opcion:");
Console.WriteLine("1: valor absoluto");
Console.WriteLine("2: cuadrado");
Console.WriteLine("3: raiz cuadrada");
Console.WriteLine("4: seno");
Console.WriteLine("5: coseno");
Console.WriteLine("6: parte entera");
Console.WriteLine("7: maximo de dos numeros");
Console.WriteLine("8: minimo de dos numeros");
int opcion = Convert.ToInt32(Console.ReadLine());

float resultado;
int calcula=1;
while(calcula==1){
if (num1>0){
    switch(opcion){
    case 1:
        resultado=Math.Abs(num);
        Console.WriteLine(resultado);
        break;
    case 2:
        resultado=(float)Math.Pow(num, 2);
        Console.WriteLine(resultado);
        break;
    case 3:
        resultado=(float)Math.Sqrt(num);
        Console.WriteLine(resultado);
        break;
    case 4:
        resultado=(float)Math.Sin(num);
        Console.WriteLine(resultado);
        break;
    case 5:
        resultado=(float)Math.Cos(num);
        Console.WriteLine(resultado);
        break;
    case 6:
        int entera=(int)num;
        Console.WriteLine(entera);
        break;
    case 7:
        float numero2 = (float) Convert.ToDouble(Console.ReadLine());
        if(num>numero2){
            Console.WriteLine(num);
        }else{
            Console.WriteLine(numero2);
        }
        break;
    case 8:
        float numero = (float) Convert.ToDouble(Console.ReadLine());
        if(num<numero){
            Console.WriteLine(num);
        }else{
            Console.WriteLine(numero);
        }
        break;
    default:
        Console.WriteLine("No se eligio una opcion valida");
        break;
    }
}else{
    Console.WriteLine("No se puede operar con un numero negativo");
}

int res;


    Console.WriteLine("Seleccione una operacion");
    Console.WriteLine("1: suma, 2: resta, 3:multiplicar, 4:dividir");
    int operacion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese un numero");
    int num1= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese otro numero");
    int num2= Convert.ToInt32(Console.ReadLine());

    switch (operacion)
    {
        case 1:
            res=num1+num2;
            Console.WriteLine("El resultado es: "+ res);
            break;
        case 2:
            res=num1-num2;
            Console.WriteLine("El resultado es: "+ res);
            break;
        case 3:
            res=num1*num2;
            Console.WriteLine("El resultado es: "+ res);
            break;
        case 4:
            res=num1/num2;
            Console.WriteLine("El resultado es: "+ res);
            break;
        default:
            Console.WriteLine("No se ingreso operacion valida");
            break;
    }
    Console.WriteLine("Quiere realziar otro calculo? (1: si, 2: no)");
    calcula=Convert.ToInt32(Console.ReadLine());
}