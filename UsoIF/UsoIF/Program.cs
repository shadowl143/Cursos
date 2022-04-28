// See https://aka.ms/new-console-template for more information



using UsoIF;
/**
* Operaciones Logicas
* == igual
* === identicos
* != diferente cualquier tipo de dato
* <> de preferencia con tipos dato enteros
* < menorque 
* > mayor que
* <= menor igual que 
* >=mayor igual que 
*/
IfSimple simple = new IfSimple();
Console.WriteLine("Escribar Sexo y edad");
string sexo = Console.ReadLine();
int edad = Convert.ToInt32(Console.ReadLine());
simple.IfAnidado(sexo,edad);