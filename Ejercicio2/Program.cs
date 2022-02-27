


//Mostramos mensaje en pantalla
Console.WriteLine("Ejercicio No. 2\r");
Console.WriteLine("------------------------\n");
// Declaramos las variable y las inicializamos 
int numeroActual = 0; int numeroAnterior = 0; int numeroSiguiente = 0;
string resultado = "";
try
{
    Console.WriteLine("Favor de digitar el primer finbonacci, y luego presione la tecla Enter\r");
    numeroActual = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    //Obtenemos el valor adsoluto del numero digitado
    numeroAnterior = Math.Abs(numeroActual - 1);

    for (int i = 0; i <= 5; i++)
    {
        numeroSiguiente = numeroAnterior + numeroActual;
        //actualizamos los valores para crear la sucesi[on
        numeroAnterior = numeroActual;
        numeroActual = numeroSiguiente;
        //imprimimos resultado por pantalla
        Console.WriteLine(numeroSiguiente + "\n");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Favor de registrar solo valores numericos");
}


