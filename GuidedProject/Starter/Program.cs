using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScoers = [90, 95, 87, 88, 96];

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

// calculating total marks for every student
for (int i = 0; i < currentAssignments; i++)
{
    sophiaSum += sophiaScores[i];
    andrewSum += andrewScores[i];
    emmaSum += emmaScores[i];
    loganSum += loganScoers[i];
}

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames)
{
    int currentStudentSum = 0;
    decimal currentScore = 0;
    string currentGrade = "";

    if (name == "Sophia")
    {
        currentStudentSum = sophiaSum;
    }
    else if (name == "Andrew")
    {
        currentStudentSum = andrewSum;
    }
    else if (name == "Emma")
    {
        currentStudentSum = emmaSum;
    }
    else
    {
        currentStudentSum = loganSum;
    }

    currentScore = (decimal)currentStudentSum / currentAssignments;

    // Grade Calculation
    if (currentScore <= 58.9m)
    {
        currentGrade = "F";
    }
    else if (currentScore <= 62.9m)
    {
        currentGrade = "D-";
    }
    else if (currentScore <= 66.9m)
    {
        currentGrade = "D";
    }
    else if (currentScore <= 69.9m)
    {
        currentGrade = "D+";
    }
    else if (currentScore <= 72.9m)
    {
        currentGrade = "C-";
    }
    else if (currentScore <= 76.9m)
    {
        currentGrade = "C";
    }
    else if (currentScore <= 79.9m)
    {
        currentGrade = "C+";
    }
    else if (currentScore <= 82.9m)
    {
        currentGrade = "B-";
    }
    else if (currentScore <= 86.9m)
    {
        currentGrade = "B";
    }
    else if (currentScore <= 89.9m)
    {
        currentGrade = "B+";
    }
    else if (currentScore <= 92.9m)
    {
        currentGrade = "A-";
    }
    else if (currentScore <= 96.9m)
    {
        currentGrade = "A";
    }
    else if (currentScore <= 100)
    {
        currentGrade = "A+";
    }

    Console.WriteLine($"{name}:\t\t" + currentScore + $"\t{currentGrade}");
}
