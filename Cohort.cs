using System;

namespace StudentExercises
{
    class Cohort
    {
        //CohortName is read only 
        public string CohortName
        {
            get { return _Name; }
        }
        private string _Name;

        //collection of students
        //collection of instructors
    }
}