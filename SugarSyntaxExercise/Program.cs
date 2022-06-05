using System;

namespace SugarSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            var greaterThanResponse = $"{answer} is greater than or equal to nine";
            var lessThanResponse = $"{answer} is less than nine";

            var answerToQuestion = (answer < 9) ? lessThanResponse : greaterThanResponse;

            Console.Write(answerToQuestion);
        }
    }
}

