// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using APLICACION.Entidades;
using APLICACION.Negocio;

ClsAlmacenamiento clsalmacenamiento = new ClsAlmacenamiento ( );

Almacenamiento almacenamiento = new Almacenamiento ();
Console.WriteLine("Ingrese una palabra: ");
almacenamiento.letras = Console.ReadLine();
Console.WriteLine( " La cantidad de letras es: "+ almacenamiento.letras?.Length);
