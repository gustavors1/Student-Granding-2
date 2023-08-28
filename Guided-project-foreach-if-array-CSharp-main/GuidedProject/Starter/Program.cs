/* 
La instrucción using permite escribir código que implementa miembros del espacio 
de nombres System sin necesidad de especificar System. Por ejemplo, el código puede usar 
el método Console.WriteLine() sin tener que especificar System.Console.WriteLine().
*/
using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

// Creamos las matrices para las puntuaciones.

int[] sopiaScores = new int [] {90, 86, 87, 98, 100 };
int[] andrewScores = new int[] {92, 89, 81, 96, 90 };
int[] emmaScores = new int[] {90, 85, 87, 98, 68 };
int[] loganScores = new int[] {90, 95, 87, 88, 96 };

int sophiaSum = 0;

decimal sophiaScore;

/*
Creamos una instancia de una variable entera denominada "score" como parte 
de la instrucción foreach. Usaremos score dentro del bloque de código de foreach 
para acceder a los valores de la matriz sophiaScores.
*/

foreach (int score in sophiaScore)
{
    // add the exam score to the sum
    sophiaSum += score; // usamos el operador += para agregar el valor de score 
                        // a sophiaSum dentro del bucle foreach. Equivale a sophiaSum = sophiaSum + score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine(); // detiene la aplicación para que el usuario pueda examinar la salida.
