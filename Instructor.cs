using System;

namespace StudentExercises
{
    class Instructor
    {
        private string _InstructorFirstName;
        private string _InstructorLastName;
        private string _InstructorSlackHandle;
        // private string _InstructorCohort;

        public Instructor(string firstName, string lastName, string slackHandle)
        {
            _InstructorFirstName = firstName;
            _InstructorLastName = lastName;
            _InstructorSlackHandle = slackHandle;

        }

        //A method to assign an exercise to a student
         public void AssignExercise (Exercise exercise, Student student) {

             //take the exercise and assign it to the student's list of exercises
             //remember that things are being read from right to left
            student.Exercises.Add(exercise);
        }

        public void Print() {
            Console.WriteLine($@"
            Instructor: {_InstructorFirstName} {_InstructorLastName}");
        }

    }
}