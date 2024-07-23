// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
int res;

int calcula=1;
while(calcula==1){
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