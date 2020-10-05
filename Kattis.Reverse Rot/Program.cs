using System;

namespace Kattis.Reverse_Rot
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";
            //Läser in rad från användare
            var input = Console.ReadLine();

            var words = input.Split(' ');
            var rotation = Convert.ToInt32(words[0]);
            var message = words[1];

            var result = "";

            for (int i = 0; i < message.Length; i++)
            {
                var letter = message.ToCharArray()[i];
                var indexOfLetter = alphabet.IndexOf(letter);
                var newIndex = indexOfLetter + rotation;
                if(newIndex > 27)
                {
                    newIndex = newIndex - 28;
                }

                var newLetter = indexOfLetter + rotation;
                // samma som ovanför
                result += alphabet.ToCharArray()[newIndex];


            }

            var reverseWord = ReverseString(result);



            Console.WriteLine(result);

        }

        private static string ReverseString(string result)
        {
            var restulArr = result.ToCharArray();
            Array.Reverse(restulArr);
            return new string(restulArr);


        }
    }
}
