/* 
La instrucción using permite escribir código que implementa miembros del espacio 
de nombres System sin necesidad de especificar System. Por ejemplo, el código puede usar 
el método Console.WriteLine() sin tener que especificar System.Console.WriteLine().
*/
using System;

// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
       studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;
    
    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

/* 
Tengamos en cuenta que la aplicación se organiza de forma muy lógica de arriba abajo:

Inicializará variables y creará las matrices que sirven como origen de datos para la aplicación. Tiene matrices que proporcionan las puntuaciones de los alumnos, así como una matriz que proporciona los nombres de los alumnos. También tiene una matriz independiente de los alumnos denominada studentScores que puede usar para que contenga las puntuaciones de cualquier alumno cuando llegue el momento de calcular las calificaciones.

Tiene una instrucción Console.WriteLine() que escribe las etiquetas de columna para el informe de calificaciones en la consola.

Tiene un bucle externo foreach que recorre en iteración la matriz studentNames, lo que le proporciona un bloque de código que se repite para cada alumno.

Va a seguir organizando el código mediante un enfoque de arriba abajo dentro del bloque de código del bucle externo foreach:

Tiene una instrucción if para evaluar el nombre del alumno actual, por ejemplo if (currentStudent == "Sophia"). Cuando la expresión se evalúa como true, se asigna la matriz de puntuaciones del alumno a la matriz independiente de los alumnos, por ejemplo, studentScores = sophiaScores;.

Va a declarar las dos variables necesarias para calcular las calificaciones de los alumnos. La primera variable, sumAssignmentScores, se usa para calcular la suma de las puntuaciones de tareas. La segunda variable, currentStudentGrade, se usa para calcular la calificación numérica final. Va a inicializar las variables con un valor de 0.

Tiene un bucle foreach que recorre en iteración studentScores para calcular el valor de sumAssignmentScores.

Va a calcular currentStudentGrade dividiendo sumAssignmentScores por el número de tareas en el libro de calificaciones. El número de tareas calificadas se mantiene en una variable denominada examAssignments.

Tiene una construcción if-elseif-else que asigna calificaciones con letra en función del valor de currentStudentGrade.

Tiene una instrucción Console.WriteLine() que escribe los nombres y calificaciones de los alumnos en la consola para completar el informe de calificaciones.
*/