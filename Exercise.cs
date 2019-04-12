using System;

namespace StudentExercises
{
    class Exercise
    {

        public string ExerciseName { get; set; }
        public string ExerciseLanguage { get; set; }

        public Exercise(string name, string language)
        {
            ExerciseName = name;
            ExerciseLanguage = language;
        }
        public void Print() {
            Console.WriteLine($@"
            ------------------------------------
            Student Exercises: {ExerciseName} in {ExerciseLanguage}");
        }

    }
}