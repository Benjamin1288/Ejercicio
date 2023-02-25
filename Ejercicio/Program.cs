/*Ejercicio 1 de tarea*/
string nom,gen;
int año, edad, dia;
string año_n = DateTime.Now.ToString("yyyy");
Console.Write("Cual es su nombre?: ");
nom = Console.ReadLine();
try
{
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("En que día de la semana nacio?");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("1. Domingo");
    Console.WriteLine("2. Lunes");
    Console.WriteLine("3. Martes");
    Console.WriteLine("4. Miercoles");
    Console.WriteLine("5. Jueves");
    Console.WriteLine("6. Viernes");
    Console.WriteLine("7. Sabado");
    Console.WriteLine("---------------------------------------");
    dia = int.Parse(Console.ReadLine());
    Console.WriteLine("---------------------------------------");
}
catch (Exception error)
{
    Console.WriteLine("Ha ocurrido un error "+error.Message);
    Console.WriteLine("---------------------------------------");
}
Console.Write("En que año nacio?: ");
año = int.Parse(Console.ReadLine());
if (año%2==0)
{
    Console.WriteLine("----------------------------------------------------------------------");
    Console.WriteLine("Tu año de nacimiento es par, eres una persona interesante y talentosa");
    Console.WriteLine("----------------------------------------------------------------------");
}
else
{
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Tu año es impar");
    Console.WriteLine("---------------------------------------");
}
if (año<=1964)
{
    gen = "Generación Baby Boomers";
}
else if (año<=1981)
{
    gen = "Generación X";
}
else if (año<=1997)
{
    gen = "Generacion Y o Millennials";
}
else if (año<=2010)
{
    gen = "Generación Centennials o Generación Z";
}
else
{
    gen = "¿Que?";
}
edad = System.Int32.Parse(año_n) - año;
if (edad <= 17)
{
    Console.WriteLine("Tu edad es: " + edad);
    Console.WriteLine("Perteneces a la " + gen);
    Console.WriteLine("Sos patojo frega todo lo que podas, deja recuerdos de todas tus travesuras");
}
else if (edad <= 19)
{
    Console.WriteLine("Tu edad es: " + edad);
    Console.WriteLine("Perteneces a la " + gen);
    Console.WriteLine("Sos patojo con DPI, pero céntrate en tus metas");
}
else if (edad <= 29)
{
    Console.WriteLine("Tu edad es: " + edad);
    Console.WriteLine("Perteneces a la " + gen);
    Console.WriteLine("Sos joven disfrútalo y aprovecha tu juventud, no metas la pata y se vale equivocarse");
}
else if (edad <= 60)
{
    Console.WriteLine("Tu edad es: " + edad);
    Console.WriteLine("Perteneces a la " + gen);
    Console.WriteLine("Sos adulto disfruta tu vida profesional y tu vida personal");
}
else if (edad >= 60)
{
    Console.WriteLine("Tu edad es: " + edad);
    Console.WriteLine("Perteneces a la " + gen);
    Console.WriteLine("Sos adulto mayor cosecha lo que sembraste no hay vuelta atras");
}
else if (edad < 0)
{
    Console.WriteLine("Tu edad es: " + edad);
    Console.WriteLine("¿Que?");
}
Console.ReadLine();

/* Ejercicio 2 de tarea*/

int edad2_1;
Boolean perm = true;
Console.WriteLine("Cual es tu edad?: ");
edad2_1= int.Parse(Console.ReadLine());
if (edad2_1 > 21)
{
    Console.WriteLine("Puedes aplicar para una licencia");
}
else if (edad2_1 <= 21 && edad2_1 >= 16 && perm == true)
{
    Console.WriteLine("Puedes aplicar para licencia con el permiso de tus padres");
}
else
{
    Console.WriteLine("No tienes permetido tener licencia, ni con el permiso de tus padres");
}
Console.ReadLine();

/*Ejercicios realizados en clase*/
/*Ejercicio 1*/

int edad1 = 25;
if (edad1 == 15)
{
    Console.WriteLine("Parranda");
}
else if (edad1 == 18)
{
    Console.WriteLine("cuarteli");
}
else if (edad1 == 21)
{
    Console.WriteLine("Mayor");
}

/*Ejercicio 2*/

Boolean Permiso = true;
int edad2 = 15;
if (edad2 >= 18 || edad2 >= 16 && Permiso)
{
    Console.WriteLine("Puede licencia");
}
else
{
    Console.WriteLine("Nel");
    Console.WriteLine();/*Esta linea de codigo existe para hacer separar el siguiente programa, como un punto y aparte*/
}

/*Ejercicio 3*/

int edad3;
int año3;
string año_nac = DateTime.Now.ToString("yyyy");
Console.Write("Ingrese tu año de nacimiento: ");
año3= int.Parse(Console.ReadLine());
edad3 = int.Parse(año_nac) - año3;
Console.WriteLine("La fecha de año es: "+año_nac);
Console.WriteLine("La edad es: "+edad3);
Console.ReadLine();
