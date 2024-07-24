// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


*/
Console.WriteLine("eliga una opcion:");
Console.WriteLine("1: valor absoluto");
Console.WriteLine("2: cuadrado");
Console.WriteLine("3: raiz cuadrada");
Console.WriteLine("4: seno");
Console.WriteLine("5: coseno");
Console.WriteLine("6: parte entera");
Console.WriteLine("7: maximo de dos numeros");
Console.WriteLine("8: minimo de dos numeros");
Console.WriteLine("9: Suma");
Console.WriteLine("10: resta");
Console.WriteLine("11: multiplicacion");
Console.WriteLine("12: divison");

int opcion = Convert.ToInt32(Console.ReadLine());

float resultado;
int calcula=1;
while(calcula==1){
    Console.WriteLine("Ingrese un número");
    float num1= (float) Convert.ToDouble(Console.ReadLine());
    if (num1>0){
        float Num2 = 0;
        if(opcion>=7){
            Console.WriteLine("Escriba otro numero");
            Num2= (float) Convert.ToDouble(Console.ReadLine());
        }
        switch (opcion){
            case 1:
                resultado=Math.Abs(num1);
                Console.WriteLine(resultado);
                break;
            case 2:
                resultado=(float)Math.Pow(num1, 2);
                Console.WriteLine(resultado);
                break;
            case 3:
                resultado=(float)Math.Sqrt(num1);
                Console.WriteLine(resultado);
                break;
            case 4:
                resultado=(float)Math.Sin(num1);
                Console.WriteLine(resultado);
                break;
            case 5:
                resultado=(float)Math.Cos(num1);
                Console.WriteLine(resultado);
                break;
            case 6:
                int entera=(int)num1;
                Console.WriteLine(entera);
                break;
            case 7:
                if(num1>Num2){
                    Console.WriteLine(num1);
                }else{
                    Console.WriteLine(Num2);
                }
                break;
            case 8:
                if(num1<Num2){
                    Console.WriteLine(num1);
                }else{
                    Console.WriteLine(Num2);
                }
                break;
            case 9:
                resultado=num1+Num2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            case 10:
                resultado=num1-Num2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            case 11:
                resultado=num1*Num2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            case 12:
                resultado=num1/Num2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            default:
                Console.WriteLine("No se eligio una opcion valida");
                break;
        }
    }else{
        Console.WriteLine("No se puede operar con un numero negativo");
    }
        Console.WriteLine("Quiere realziar otro calculo? (1: si, 2: no)");
        calcula=Convert.ToInt32(Console.ReadLine());
}