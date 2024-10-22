Console.WriteLine("C# Tarea Inicial");

//Primera parte.
int integerValue = 10;
Console.WriteLine("Numero entero = " + integerValue);

double doubleValue = 3.14159265358979d;
Console.WriteLine("Valor Double = " + doubleValue);

float floatValue = 3.14f;
Console.WriteLine("Valor float " + floatValue);

decimal decimalValue = 12345.6789m;
Console.WriteLine("Valor decimal = " + decimalValue);

string stringValue = "'Este es el texto'";
Console.WriteLine("Variable texto: " + stringValue);

char charValue = 'a';
Console.WriteLine("Variable Letra: " + charValue);

bool boolValueTrue = true;
Console.WriteLine("Verdadero = " + boolValueTrue);

bool boolValueFalse = false;
Console.WriteLine("Falso = " + boolValueFalse);

//Segunda parte.
const int CONST_VALUE = 1;
Console.WriteLine("Valor constante = " + CONST_VALUE);

//Tercera parte.
int integerIncrementAndDecrement = 100;
Console.WriteLine("Numero original = " + integerIncrementAndDecrement);

integerIncrementAndDecrement++;
Console.WriteLine("Incrementacion = " + integerIncrementAndDecrement);
integerIncrementAndDecrement--;
integerIncrementAndDecrement--;
Console.WriteLine("Decrementacion = " + integerIncrementAndDecrement);

int integerOperations = 100;

integerOperations += 48;
Console.WriteLine("Sumado 48 = " + integerOperations);
integerOperations -= 33;
Console.WriteLine("Restado 33 = " + integerOperations);
integerOperations *= 4;
Console.WriteLine("Multiplicado 4 = " + integerOperations);
integerOperations /= 9;
Console.WriteLine("Dividido 9 = " + integerOperations);

//Cuarta parte.
float valorFloat = 10152466.25f;
Console.WriteLine("El valor float es = " + valorFloat);

byte byte5 = (byte)(5 + valorFloat);
Console.WriteLine("El byte valor 5 mas el float = " + byte5);

//Quinta parte.
DateTime dateAndHour = DateTime.Now;
Console.WriteLine("Fecha y hora actual" + dateAndHour);

//Realizado por Imanol Rodriguez. Mat:2024-0256.
/* Con este comentario
 finalizo esta tarea. Para la realizacion de 
dicha tarea se tomaron un cuenta las grabaciones 2 y 5
correspondientes a las fechas del 16 y 30 de septiembre, 
ademas de algunas funtes externas para reforzar conocimientos.
*/

Console.ReadKey();