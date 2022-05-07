

// de una sola linea
/*
 * mas de una sola linea*/




using Clases;
/**
* Clases
* Objetos
* Metodos
* Herencia
* Encapsulamiento
* Abstraccion
* Polimorfismo
* override
* */

/**
 * if else if if anidado switch
 * loops for foreach, while, do while, while do
 * list y arreglos
 * **/


//ClasePublica persona = new ClasePublica();

//persona.CrearAlumnos();

RecibirDatos recibirDatos = new RecibirDatos();
ClasesDeRetorno retorno = new ClasesDeRetorno();

var asignarNombre = retorno.AsignarNombre();
var valor = retorno.Valor();
var fechaDeHoy = retorno.FechaDeHoy();
var asignarArray = retorno.AsignarArray();

recibirDatos.MostrarNombre(asignarNombre);
recibirDatos.MostrarValor(valor);
recibirDatos.MostrarFechaDeHoy(fechaDeHoy);
recibirDatos.MostrarAsignarArray(asignarArray);


//ClasePublica clase = new ClasePublica();
//clase.FormarVehiculo();
//string ObtenerSaludo = clase.SaludoAmigo("Saul");
//Console.WriteLine(ObtenerSaludo);

//ClaseDos claseD = new ClaseDos();
//claseD.CrearAlumnos();

//ClasePublica clase1= new ClasePublica();
//ClasePublica clase2= new ClasePublica();
//ClasePublica clase3= new ClasePublica();
//ClasePublica clase4= new ClasePublica();

//clase.numeroUno = 10;
//Console.WriteLine(clase1.numeroUno);

//clase = new ClasePublica(20);
//Console.WriteLine(clase.numeroUno);
//clase.LLamarVariablePublica();

