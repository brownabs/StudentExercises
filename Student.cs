using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string StudentFirstName;
        public string StudentLastName;
        public string StudentSlackHandle;
        // public string StudentCohort;

        public List<Exercise> exercises = new List<Exercise>();

        public Student(string firstName, string lastName, string slackHandle)
        {
            StudentFirstName = firstName;
            StudentLastName = lastName;
            StudentSlackHandle = slackHandle;

        }
    }
}