using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mixer
{
    class Program
    {
        static void Main(string[] args)
        {
//1) Word Frequency Analysis
                                       // get the input text
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
                                      // Convert to array of words and display words  
            String[] wordsarray = ToWordsArray(text);
                                      // Calculate frequency of words 
            int[] counts = countFrequency(wordsarray);
                                      // Display frequency of words
                for(int i=0;i<=wordsarray.Length-1;i++)
            {
                Console.WriteLine("'{0}'  :{1} times", wordsarray[i], counts[i]);
            }
// 2). Generate 'N' sentences, each sentence containing 5 words chosen randomly from the array
                                      //Ask the user to input a number 'N'.
            Console.WriteLine("Enter the number ,how many random sentences you want");
            int number=Convert.ToInt32(Console.ReadLine());
            Random randomword = new Random();
                                      // numbers of sentences
            for (int i=0;i<number;i++)   
            {                         //5 words sentence
                for (int j = 0; j <= 4; j++) 
                {
                    int randomNumber = randomword.Next(0, wordsarray.Length-1);
                    Console.Write(wordsarray[randomNumber] + " ");
                }
                Console.WriteLine();
            } 
            
 // 3) part longest and shortest words
                         // longest 
            String[] largest=new String[wordsarray.Length];
            largest[0] = wordsarray[0];
            int c = 0;
            for (int l = 0; l < wordsarray.Length;l++)
            {
                String str = wordsarray[l];
                if (wordsarray[l].Length>largest[0].Length)
                {
                    largest[0] = wordsarray[l];
                   
                }
            }
            for (int l = 0; l < wordsarray.Length; l++)
            {
                if (wordsarray[l].Length == largest[0].Length)
                {
                    c += 1;
                    largest[c] = wordsarray[l];
                }
            }
            
            Console.WriteLine(" The largest words in text are: ");
            for (int i=1;i<=c;i++)
            {
                Console.WriteLine(" "+largest[i]);
            }
    // shortest in sentence
            String[] shortest = new String[wordsarray.Length];
            shortest[0] = wordsarray[0];
            int d = 0;
            for (int l = 0; l < wordsarray.Length; l++)
            {
                if (wordsarray[l].Length < shortest[0].Length)
                {
                    shortest[0] = wordsarray[l];

                }
            }
            for (int l = 0; l < wordsarray.Length; l++)
            {
                if (wordsarray[l].Length == shortest[0].Length)
                {
                    d += 1;
                    shortest[d] = wordsarray[l];
                }
            }

            Console.WriteLine(" The smallest words in text are: ");
            for (int i = 1; i <= d; i++)
            {
                Console.WriteLine(" " + shortest[i]);
            }
//4) Search Word in text
            Console.WriteLine("Enter the word to search from text");
            String searched=Console.ReadLine();
            int counto = 0;
            for (int i=0;i<wordsarray.Length;i++)
            {
                if (searched==wordsarray[i])
                {
                    counto++;
                }
            }
            Console.WriteLine("{0} is {1} times in the given text", searched, counto);
            if (counto==0)
            {
                Console.WriteLine("so sorry {0} does not exist in the senence text", searched);
            }
//5)Check existaance of palidrome 
               (int[], int) palidromeResult = palidromecheck(wordsarray);
            int NoOfPalidromeWords = palidromeResult.Item2;
            int[]  indexesOfPalidrome= palidromeResult.Item1;
            Console.WriteLine("there are {0} palidromxab", NoOfPalidromeWords+1);
            for (int u=0;u<indexesOfPalidrome.Length;u++)
            {
                Console.WriteLine("{0} is palidrome in sentence at {1} index", wordsarray[indexesOfPalidrome[u]],indexesOfPalidrome[u]);
            }
            Console.WriteLine();
//6) vovals and consonants 
            int vovel = 0;
            int consonants = 0;
            for (int i=0;i<wordsarray.Length;i++)
            {
                Char[] alphabets = wordsarray[i].ToCharArray();
                if(alphabets[i]=='o')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'O')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'i')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'I')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'u')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'U')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'a')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'A')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'e')
                {
                    vovel++;
                }
                else if (alphabets[i] == 'E')
                {
                    vovel++;
                }
                else
                {
                    consonants++;
                }
            }
            Console.WriteLine("there are {0} consonants and {1} vovels in sentence", consonants, vovel);
           Console.ReadKey();
            
        }

                
// Method to convert a text to array of words
        static String[] ToWordsArray(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }
        
//Method to count frequency of words 
        static int[] countFrequency(string[] wordsarray)
        {
            int[] countersArray = new int[wordsarray.Length];
            foreach (String word in wordsarray)
            {
                for (int i = wordsarray.Length - 1; i >= 0; i--)
                {                   // calculate the matching  number of elements
                    if (wordsarray[i] == word)
                    {
                        countersArray[i]++;
                    }
                }
            }
            return countersArray;
        }
// method to check palidrom existances in a sentence text
        static (int[],int) palidromecheck(String[] wordsarray)
        {
            int couant = 0;
            int[] iss = new int[wordsarray.Length];
            for (int i = 0; i < wordsarray.Length; i++)
            {
                
                String[] reversed = new String[wordsarray.Length];
                reversed[i] = Convert.ToString(wordsarray[i].Reverse());
                if (reversed[i] == wordsarray[i])
                {
                    couant++;
                    iss[i] = i;
                   
                }
            }
            return (iss, couant);
        }

    }
    
}
