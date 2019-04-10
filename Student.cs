using System;

namespace StudentExercises
{
    class Student
    {

        private string _StudentFirstName;
        private string _StudentLastName;
        private string _StudentSlackHandle;
        private string _StudentCohort;

        //is this where my collection(list) of Student Exercises should be?

        public Student(string firstName, string lastName, string slackHandle, string studentCohort)
        {
            _StudentFirstName = firstName;
            _StudentLastName = lastName;
            _StudentSlackHandle = slackHandle;
            _StudentCohort = studentCohort;

        }

    }
}