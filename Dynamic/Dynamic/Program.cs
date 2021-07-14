using System;
using System.Collections.Generic;
using System.IO;
namespace Dynamic
{
    class Program
    {
        static char[] sentence = new char[60];
        static string[] dictionary = new string[68];
        static List<string> words = new List<string>();
        static List<string> new_sentence = new List<string>();
        public static void build() 
        {
            string sentence_ = "Erişmekistedikleribirhedefiolmayanlarçalışmaktanzevkalmazlar";
            sentence = sentence_.ToCharArray();
        
            string dosya_yolu = @"C:\Users\elifv\Desktop\sozluk.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi;
            for (int i = 0; i < dictionary.Length; i++)
            {
                yazi = sw.ReadLine();
                dictionary[i] = yazi;
            }
        }

        public static void comparison(int a,int b) 
        {
           
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (sentence[a] == dictionary[i][0] && sentence[a+1] == dictionary[i][1]) 
                {
                    if (dictionary[i].Length <= b+1) 
                    {
                        words.Add(dictionary[i]);
                    }
                  
                }

            }
            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}
        }
        static string b = "";
       static int d;
        public static int recursive(int index , int max) 
        {
            int a;
            
             string[] word = words.ToArray();
            a = sentence.Length - word[index].Length;
            if (index < max)
            {
                d = sentence.Length - word[index + 1].Length;

            }

            if (index <= max) 
            {
                if (a < d) 
                {
                    recursive(index + 1, max);
                   
                }
                else
                {
                    if (index < max) 
                    {
                        if (index + 1 != max)
                        {
                            recursive(index + 1, max);

                        }
                        else
                        {
                            b = word[index + 1].ToString();
                            new_sentence.Add(b + " ");

                        }
                    }
                    
                    else 
                    {
                        b = word[index].ToString();
                        new_sentence.Add(b + " ");

                    }
                    
                }
                
            }
            return a;
        }
        static void Main(string[] args)
        {
            build();
            Console.WriteLine("                                 Program Çıktısı:");
            comparison(0,7);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(7,11);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(18,3);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(21,6);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(27,10);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(37,11);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(48,4);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(52,9);
            recursive(0, words.Count - 1);

            foreach (var item in new_sentence)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            new_sentence.Clear();
            Console.WriteLine("                                     Veya");
            comparison(0, 7);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(7, 4);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(11, 7);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(18, 3);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(21, 6);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(27, 10);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(37, 8);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(45, 3);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(48, 4);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(52, 9);
            recursive(0, words.Count - 1);
            words.Clear();

            foreach (var item in new_sentence)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            new_sentence.Clear();
            comparison(0, 7);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(7, 11);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(18, 3);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(21, 6);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(27, 10);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(37, 8);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(45, 3);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(48, 4);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(52, 9);
            recursive(0, words.Count - 1);
            words.Clear();
            foreach (var item in new_sentence)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            new_sentence.Clear();
            comparison(0, 7);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(7, 4);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(11, 7);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(18, 3);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(21, 6);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(27, 10);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(37, 11);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(48, 4);
            recursive(0, words.Count - 1);
            words.Clear();
            comparison(52, 9);
            recursive(0, words.Count - 1);
            words.Clear();

            foreach (var item in new_sentence)
            {
                Console.Write(item);
            }
        }
    }
}
