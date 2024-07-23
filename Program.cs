// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

// EJERCICIO 1

int invertir, aux, res=0;
Console.WriteLine("Ingrese un número: ");
if (int.TryParse(Console.ReadLine(), out invertir)){
    if(invertir>0){
        aux=invertir;
        while(aux>0){
            res=res*10+(aux%10);
            aux = aux/10;
        }
        Console.WriteLine($"El número que quiere invertir es {invertir}");
        Console.WriteLine($"El número invertido es {res}");
    }else{
        Console.WriteLine("El numero ingresado es negativo");
    }
}else{
    Console.WriteLine("No se ingreso un numero");
}

