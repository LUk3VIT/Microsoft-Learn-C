int currentAssignments = 5;

int[] sophiaNotas =  [90, 86, 87, 98, 100];
int[] andrewNotas = [92, 89, 81, 96, 90];
int[] emmaNotas = [90, 85, 87, 98, 68];
int[] loganNotas = [90, 95, 87, 88, 96];

string[] alunosNomes = ["Sophia", "Andrew", "Emma", "Logan"];
int[] alunosNotas = [10];

string alunoAtualGradeLetra = "";

Console.WriteLine("Student\t\tGrade\n");

foreach ( string nome in alunosNomes)
{
    string alunoAtual = nome;
    
    if(alunoAtual == "Sophia")
        alunosNotas = sophiaNotas;

    else if (alunoAtual == "Andrew")
        alunosNotas = andrewNotas;
    
    else if (alunoAtual == "Emma")
        alunosNotas = emmaNotas;

    else if (alunoAtual == "Logan")
        alunosNotas = loganNotas;


    int sumNotasGrades = 0;

    decimal alunoAtualGrade;

    foreach (int nota in alunosNotas)
    {
        sumNotasGrades += nota;
    }

    alunoAtualGrade = (decimal)sumNotasGrades / currentAssignments;

    if (alunoAtualGrade >= 97)
        alunoAtualGradeLetra = "A+";

    else if (alunoAtualGrade >= 93)
        alunoAtualGradeLetra = "A";

    else if (alunoAtualGrade >= 90)
        alunoAtualGradeLetra = "A-";

    else if (alunoAtualGrade >= 87)
        alunoAtualGradeLetra = "B+";

    else if (alunoAtualGrade >= 83)
        alunoAtualGradeLetra = "B";

    else if (alunoAtualGrade >= 80)
        alunoAtualGradeLetra = "B-";

    else if (alunoAtualGrade >= 77)
        alunoAtualGradeLetra = "C+";

    else if (alunoAtualGrade >= 73)
        alunoAtualGradeLetra = "C";

    else if (alunoAtualGrade >= 70)
        alunoAtualGradeLetra = "C-";

    else if (alunoAtualGrade >= 67)
        alunoAtualGradeLetra = "D+";

    else if (alunoAtualGrade >= 63)
        alunoAtualGradeLetra = "D";

    else if (alunoAtualGrade >= 60)
        alunoAtualGradeLetra = "D-";

    else
        alunoAtualGradeLetra = "F";



    Console.WriteLine($"{alunoAtual}\t\t{alunoAtualGrade}\t{alunoAtualGradeLetra}"); 
    
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
