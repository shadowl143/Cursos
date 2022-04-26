//que es una variable 
int numero=0;

//constante
const decimal PI = 3.1416M;
const decimal VALORPI = 3.1416M;

/// <summary>
/// este metodo se utiliza para obtener una consulat anidad
/// Autor: Julián Lara
/// Fecha: 20/04/2022
/// </summary>

//tipos de datos exiten Integer
int numeroEjemplo=123456;  //guarda numeros int16 int32 int64  long ilong camelCase

string telefonoCelular ="6142234667";
string texto = "Hola";
decimal pi2 = 3.1416333333333333M;
float pi3 = 3.1416339999999999F;
double pi4 = 3.14D;
char letras ='a';
DateTime tiempo = DateTime.Now;
DateTime date1 = new DateTime(2008, 5, 1, 8, 30, 52);

// se obliga a inicializar en el momento 1 + 2=3 1+2=12
var soyUnTexto="";
var soyUnEntero = 0;

// que si se obligue a cambiar el tipo
dynamic dynamic = "";
Console.WriteLine(dynamic);
dynamic = 1;
Console.WriteLine(dynamic);
dynamic = 3.1416M;


var concatenar = telefonoCelular + texto;
var concatenarNumerico=pi2.ToString()+telefonoCelular;
var resultado = pi2 + numeroEjemplo;


//numero = 2; concaenacion
//Array, list, IQueryble,IEnumerable 121212 12 12 121212121212112121212121/**



Console.WriteLine(numero);
Console.WriteLine("Ingrese un dato");
var dato = Console.ReadLine();
Console.WriteLine("El dato recibido fue: " + dato);
Console.WriteLine(PI);
Console.WriteLine(numeroEjemplo);
Console.WriteLine(texto);
Console.WriteLine(pi2.ToString());
Console.WriteLine(pi3);
Console.WriteLine(letras);
Console.WriteLine(tiempo);
Console.WriteLine(date1);
Console.WriteLine(soyUnTexto);
Console.WriteLine(soyUnEntero);
Console.WriteLine(dynamic);
