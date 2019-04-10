using System;

namespace StudentExercises
{
    class Instructor
    {
 private string _InstructorFirstName;
        private string _InstructorLastName;
        private string _InstructorSlackHandle;

        private string _InstructorCohort;

        //A method to assign an exercise to a student


        public Instructor(string firstName, string lastName, string slackHandle, string cohort)
        {
            _InstructorFirstName = firstName;
            _InstructorLastName = lastName;
            _InstructorSlackHandle = slackHandle;
            _InstructorCohort = cohort;

        }

    }
}