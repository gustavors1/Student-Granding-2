/* 
La instrucción using permite escribir código que implementa miembros del espacio 
de nombres System sin necesidad de especificar System. Por ejemplo, el código puede usar 
el método Console.WriteLine() sin tener que especificar System.Console.WriteLine().
*/
using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

//  enteros que se usan para mantener la suma de las puntuaciones del examen.

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

// decimales que se usan para mantener la puntuación media calculada.

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

// calcular la suma de las puntuaciones de tareas de cada alumno

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// calcula la puntuación media.

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine(); // detiene la aplicación para que el usuario pueda examinar la salida.
 