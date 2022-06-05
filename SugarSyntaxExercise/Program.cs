using System;

namespace SugarSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string greaterThanResponse = $"{answer} is greater than or equal to nine";
            string lessThanResponse = $"{answer} is less than nine";

            var answerToQuestion = (answer < 9) ? lessThanResponse : greaterThanResponse;

            Console.Write(answerToQuestion);
        }
    }
}

