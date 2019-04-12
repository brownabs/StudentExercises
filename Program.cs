using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise dailyJournal = new Exercise("Daily Journal", "JavaScript");
            Exercise carLot = new Exercise("Car Lot", "C#");
            Exercise legoLand = new Exercise("Lego Land", "JavaScript");
            Exercise contactList = new Exercise("Contact List", "React");

            // Create 3, or more, cohorts.
            Cohort c32 = new Cohort("Cohort 32");
            Cohort c33 = new Cohort("Cohort 33");
            Cohort c34 = new Cohort("Cohort 34");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Abbey = new Student("Abbey", "Brown", "brownabs");
            Student Katerina = new Student("Katerina", "Freeman", "katfree");
            Student Kirren = new Student("Kirren", "Correy", "animallover");
            Student Janet = new Student("Janet", "Woods", "thejokester");

            //class Cohort with Students List contained in it
            c32.Students.Add(Abbey);
            c33.Students.Add(Katerina);
            c34.Students.Add(Kirren);
            c34.Students.Add(Janet);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Steve = new Instructor("Steve", "Brownlee", "stevebr");
            Instructor Kimmy = new Instructor("Kimmy", "Bird", "birdgirl");
            Instructor Jenna = new Instructor("Jenna", "Jovelis", "loveshawaii");


            c32.Instructors.Add(Steve);
            c33.Instructors.Add(Kimmy);
            c34.Instructors.Add(Jenna); 
            

         

        //    c34.Instructors.ForEach(instr => Console.WriteLine(instr));
            // Have each instructor assign 2 exercises to each of the students.

            Steve.AssignExercise(carLot, Abbey);
            Steve.AssignExercise(contactList, Abbey);
            Jenna.AssignExercise(legoLand, Katerina);
            Jenna.AssignExercise(dailyJournal, Katerina);
            Kimmy.AssignExercise(carLot, Janet);
            Kimmy.AssignExercise(legoLand, Janet);
            Kimmy.AssignExercise(dailyJournal, Kirren);
            Kimmy.AssignExercise(legoLand, Kirren);


            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student>();
            students.Add(Abbey);
            students.Add(Katerina);
            students.Add(Kirren);
            students.Add(Janet);

            //Create a list of exercises. Add all the exercises to the list

            List<Exercise> exercises = new List<Exercise>();

            exercises.Add(dailyJournal);
            exercises.Add(carLot);
            exercises.Add(contactList);
            exercises.Add(legoLand);

            c32.Print();
            c33.Print();
            c34.Print();

        }
    }
}
