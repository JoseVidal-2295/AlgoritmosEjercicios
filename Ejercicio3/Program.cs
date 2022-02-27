// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Declaramos las variable y las inicializamos en 0
int monto = 0; 

//Mostramos mensaje en pantalla
Console.WriteLine("Ejercicio No. 3\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Favor de digitar el monto, y luego presione la tecla Enter\r");
monto = Convert.ToInt32(Console.ReadLine());


//Variables
int dosMill = 0; int Mill =0; int quiniento = 0; int dociento = 0; int cien = 0;
int cincuenta = 0; int veinteCinco =0; int cinco = 0; int uno = 0;
string resultado="";

if (monto >= 2000)
{
    dosMill = monto / 2000;
    //restamos
    monto = monto - (dosMill * 2000);
    resultado = dosMill+" x 2000 = "+dosMill*2000+ "\n";
}
if (monto >= 1000 && monto<2000)
{
    Mill = monto / 1000;
    //restamos
    monto = monto - (Mill * 1000);
    resultado =resultado+ Mill + " x 1000 = " + Mill * 1000 + "\n";
}
if (monto >= 500 && monto < 1000)
{
    quiniento = monto / 500;
    //restamos
    monto = monto - (quiniento * 500);
    resultado = resultado + quiniento + " x 500 = " + quiniento * 500 + "\n";
}
if (monto >= 200 && monto < 500)
{
    dociento = monto / 200;
    //restamos
    monto = monto - (dociento * 200);
    resultado = resultado + dociento + " x 200 = " + dociento * 200 + "\n";
}
if (monto >= 100 && monto < 200)
{
    cien = monto / 100;
    //restamos
    monto = monto - (cien * 100);
    resultado = resultado + cien + " x 100 = " + cien * 100 + "\n";
}
if (monto >= 50 && monto < 100)
{
    cincuenta = monto / 50;
    //restamos
    monto = monto - (cincuenta * 50);
    resultado = resultado + cincuenta + " x 50 = " + cincuenta * 50 + "\n";
}
if (monto >= 25 && monto < 50)
{
    veinteCinco = monto / 25;
    //restamos
    monto = monto - (veinteCinco * 25);
    resultado = resultado + veinteCinco + " x 25 = " + veinteCinco * 25 + "\n";
}
if (monto >= 5 && monto < 25)
{
    cinco = monto / 5;
    //restamos
    monto = monto - (cinco * 5);
    resultado = resultado + cinco + " x 5 = " + cinco * 5 + "\n";
}
if (monto >= 1 && monto < 5)
{
    //cinco = monto / 5;
    ////restamos
    //monto = monto - (uno * 1);
    uno=monto;
    resultado = resultado + uno + " x 1 = " + uno * 1;
}
    Console.WriteLine(resultado);

