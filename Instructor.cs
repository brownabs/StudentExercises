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
            student.exercises.Add(exercise);
        }

    }
}