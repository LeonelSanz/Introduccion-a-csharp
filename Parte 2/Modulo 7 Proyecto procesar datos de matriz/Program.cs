﻿
// int examAssignments = 5;

// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // display the header row for scores/grades
// Console.Clear();
// Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

// /*
// The outer foreach loop is used to:
// - iterate through student names 
// - assign a student's grades to the studentScores array
// - sum assignment scores (inner foreach loop)
// - calculate numeric and letter grade
// - write the score report information
// */
// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//         studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         studentScores = loganScores;

//     int gradedAssignments = 0;
//     int gradedExtraCreditAssignments = 0;

//     int sumExamScores = 0;
//     int sumExtraCreditScores = 0;

//     decimal currentStudentGrade = 0;
//     decimal currentStudentExamScore = 0;
//     decimal currentStudentExtraCreditScore = 0;


//     /* 
//     the inner foreach loop sums assignment scores
//     extra credit assignments are worth 10% of an exam score
//     */
//     foreach (int score in studentScores)
//     {
//         gradedAssignments += 1;

//         if (gradedAssignments <= examAssignments)
//             sumExamScores = sumExamScores + score;

//         else
//             gradedExtraCreditAssignments += 1;
//             sumExtraCreditScores += score / 10;
//     }

//     currentStudentExamScore = (decimal)sumExamScores / examAssignments;
//     currentStudentExtraCreditScore = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;

//     currentStudentGrade = (sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(decimal)sumExtraCreditScores / 10 / examAssignments} pts)");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();


int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Display the header row for the updated score report
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{

    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else if (name == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    decimal extraCreditTotal = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            extraCreditTotal += score;
    }

    decimal examScore = (decimal)sumAssignmentScores / examAssignments;
    int completedExtraCreditAssignments = studentScores.Length - examAssignments;
    decimal extraCreditPoints = completedExtraCreditAssignments > 0
        ? (decimal)(extraCreditTotal) / (10 * completedExtraCreditAssignments)
        : 0;

    decimal overallGrade = examScore + (0.10m * extraCreditPoints);

    if (overallGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (overallGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (overallGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (overallGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (overallGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (overallGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (overallGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (overallGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (overallGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (overallGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (overallGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (overallGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    int extraCreditPts = (int)(extraCreditPoints * 10);

    Console.WriteLine($"{name}\t\t{examScore:F1}\t{overallGrade:F2}\t{currentStudentLetterGrade}\t{extraCreditPts} ({extraCreditPoints:F2} pts)");
}

// Required for running in VS Code (keeps the Output window open to view results)
Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
