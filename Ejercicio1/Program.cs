
Console.WriteLine("Ejercicio No. 1\r");
Console.WriteLine("------------------------\n");


void ejercicio1()
{
    // Declaramos las variable y las inicializamos 
    int cantidad = 0;
    
    Console.WriteLine("Favor de digitar la cantidad de arreglos que se van a ingresar\r");
    cantidad = Convert.ToInt32(Console.ReadLine());

    List<string>[] listaArray = new List<string>[cantidad];

    for (int i = 0; i < cantidad; i++)
    {
        Console.WriteLine("Favor de digitar el arreglo  "+(i+1)+"\r");
        listaArray[i] = new List<string> { Convert.ToString(Console.ReadLine()) };
    }

    Console.WriteLine("El numero mayor digitado es: "+ listaArray);
    Console.WriteLine("La cantidad total de elementos es: " + listaArray.Count() + "\r");

    foreach (var list in listaArray)
    {
        foreach (var element in list)
        {
            Console.WriteLine(element);
        }
    }

    //switch (listaArray)
    //{
    //    case 1:
    //        Console.WriteLine("lunes"); break;
    //    case 2:
    //        Console.WriteLine("martes"); break;
    //    case 3:
    //        Console.WriteLine("miercoles"); break;
    //}
}

//llamamos el metodo
ejercicio1();