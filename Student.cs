using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        private string StudentFirstName;
        private string StudentLastName;
        private string StudentSlackHandle;

        public List<Exercise> Exercises {get; set;} = new List<Exercise>();

        public Student(string firstName, string lastName, string slackHandle)
        {
            StudentFirstName = firstName;
            StudentLastName = lastName;
            StudentSlackHandle = slackHandle;

        }

        public void Print () {
            Console.WriteLine($@"
            -----------------------------------
            Student Name: {StudentFirstName} {StudentLastName}");
            foreach(Exercise taco in Exercises) {

                taco.Print();
            }
        }
    }
}

//students = {
    //exercises: {}, {}, 
// }