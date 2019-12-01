using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{

    public class Program
    {
        public static void Main()
        {
            var input = "straße";
            CaseAlternatorTask.AlternateCharCases(input);
        }

        public class CaseAlternatorTask
        {
            //Вызывать будут этот метод
            public static List<string> AlternateCharCases(string lowercaseWord)
            {
                var result = new List<string>();
                AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
                var results = new List<string>(result.Distinct());
                results.Sort();
                return results;
            }

            static void AlternateCharCases(char[] word, int startIndex, List<string> result)
            {
                if (startIndex == word.Length)
                {
                    result.Add(new string(word));
                    return;
                }

                if (char.IsLetter(word[startIndex]))
                {
                    word[startIndex] = char.ToUpper(word[startIndex]);
                    AlternateCharCases(word, startIndex + 1, result);                    
                    word[startIndex] = char.ToLower(word[startIndex]);
                    AlternateCharCases(word, startIndex + 1, result);                    
                }
                else
                {
                    AlternateCharCases(word, startIndex + 1, result);
                }
            }
        }
    }
}




//public class Program
//{
//    public static void Main()
//    {
//        var input = "ab42";
//        CaseAlternatorTask.AlternateCharCases(input);
//    }
//}

//public class CaseAlternatorTask
//{
//    //Вызывать будут этот метод
//    public static List<string> AlternateCharCases(string lowercaseWord)
//    {
//        var result = new List<string>();
//        AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
//        return result;
//    }

//    static void AlternateCharCases(char[] word, int startIndex, List<string> result)
//    {
//        //result.Add(new string(word));

//        if (startIndex == word.Length)
//        {
//            result.Add(new string(word));
//            return;
//        }

//        var Newword = new char[word.Length];


//        if (char.IsLetter(word[startIndex]))
//        {
//            word[startIndex] = char.ToUpper(word[startIndex]);
//            result.Add(new string(word));
//        }

//        //var index = Array.IndexOf(word, i, 0, position);
//        //result.Add(new string(word));
//        AlternateCharCases(word, startIndex + 1, result);
//        // TODO Сделать надо здесь       



//for (var i = 0; i < word.Length; i++)
//{

//    if (char.IsLetter(word[startIndex]))
//    {
//        word[startIndex] = char.ToUpper(word[startIndex]);
//        result.Add(new string (word));
//    }

//    //var index = Array.IndexOf(word, i, 0, position);
//    //result.Add(new string(word));
//    AlternateCharCases(word, startIndex + 1, result);

//}




//public static void Main()
//{
//    TestOnSize(1);
//    TestOnSize(2);
//    TestOnSize(0);
//    TestOnSize(3);
//    TestOnSize(4);
//}

//static void TestOnSize(int size)
//{
//    var result = new List<int[]>();
//    MakePermutations(new int[size], 0, result);
//    foreach (var permutation in result)
//        WritePermutation(permutation);
//}

//static void WritePermutation(int[] permutation)
//{
//    var strings = new List<string>();
//    foreach (var i in permutation)
//        strings.Add(i.ToString());
//    Console.WriteLine(string.Join(" ", strings.ToArray()));
//}

//static void MakePermutations(int[] permutation, int position, List<int[]> result)
//{
//    if (position == permutation.Length)
//    {
//        //WritePermutation(permutation);
//        result.Add(permutation.ToArray());
//        return;
//    }
//    else
//    {
//        for (int i = 0; i < permutation.Length; i++)
//        {
//            var index = Array.IndexOf(permutation, i, 0, position);
//            //если i не встречается среди первых position элементов массива permutation, то index == -1
//            //иначе index — это номер позиции элемента i в массиве.
//            if (index == -1)
//            {
//                permutation[position] = i;
//                MakePermutations(permutation, position + 1, result);
//                // если число i ещё не было использовано, то...
//                // доделать.
//            }
//            //continue;
//        }
//    }
//}

