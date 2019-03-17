/*
 * @author - Ryan Chung
 * This program will initialize 20 chapters worth of Japanese vocab from the Genki I & II textbooks
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Japanese_Review
{
    class Program
    {
        private static Random rand = new Random();

        /*
         * Helper method to parse a string of chapters into an int array of chapters
         * @param chapterString - a string representing the chapters of interest
         * Format of chapterString:
         *     [15] - just the chapter 15
         *     [1, 15, 20] - the chapters 1, 15, and 20
         *     [1-20] - the chapters 1 through 20
         *     [1-12, 15, 18-20] - the chapters 1 through 12, 15, and 18 through 20
         * @return chapters - an int array, each int represents the chapter of interest
         */
        public static int[] parseChapters(string chapterString)
        {
            // convert the input string into an array of int (chapters) to pass to initGenki()
            var chapters = new int[20]; // there can be no more than 20 chapters of vocab from genki
            var idx = 0; // represents current index in chapters, and also the number of chapters specified
            
            // if there are multiple chapters separated by ','
            if (chapterString.Contains(','))
            {
                var chapterArray = chapterString.Split(',');
                foreach (var c in chapterArray)
                {
                    // strip the whitespace from the string
                    var chapter = c.Replace(" ", "");
                    
                    // add multiple chapters indicated by '-'
                    if (chapter.Contains('-'))
                    {
                        var startEnd = chapter.Split('-');
                        var start = Convert.ToInt32(startEnd[0]);
                        var end = Convert.ToInt32(startEnd[1]);
                        for (var i = start; i <= end; i++)
                        {
                            chapters[idx] = i;
                            idx++;
                        }
                    }
                    else // just a chapter number
                    {
                        chapters[idx] = Convert.ToInt32(chapter);
                        idx++;
                    }
                }
            }
            
            // else if there are multiple chapters indicated by '-'
            else if (chapterString.Contains('-'))
            {
                var startEnd = chapterString.Split('-');
                var start = Convert.ToInt32(startEnd[0]);
                var end = Convert.ToInt32(startEnd[1]);
                for (var i = start; i <= end; i++)
                {
                    chapters[idx] = i;
                    idx++;
                }
            }

            else // just a single chapter number
            {
                chapters[idx] = Convert.ToInt32(chapterString);
                idx++;
            }

            // remove the extra 0s in the array of chapters
            var prunedChapters = new int[idx];
            for (var i = 0; i < idx; i++)
            {
                prunedChapters[i] = chapters[i];
            }

            return prunedChapters;
        }
        
        /*
         * Helper method to start a quiz
         * @param wordBank - bank of Japanese words available for the quiz
         * @param type - the words to quiz (english, hiragana, katakana, or kanji)
         * @return score - the score on the quiz based on the number correct divided by total words in the quiz * 100
         */
        public static double quiz(ArrayList wordBank, string type)
        {
            // init quiz bank for words to quiz and a random number generator to select words from the bank
            var quizBank = new ArrayList();
            var correct = 0;
            var totalWords = 1;
            switch (type)
            {
                // english to hiragana or romaji quiz
                case "english":
                    Console.WriteLine("You may answer in hiragana or in romaji");
                    // add only hiragana words to the quiz
                    foreach (JapaneseWord word in wordBank)
                    {
                        if (word.Writing.Equals("hiragana"))
                        {
                            quizBank.Add(word);
                        }
                    }
                    
                    // begin the quiz and keep track of the score
                    totalWords = quizBank.Count;
                    while (quizBank.Count != 0)
                    {
                        var idx = rand.Next(0, quizBank.Count - 1);
                        var word = (JapaneseWord)quizBank[idx];
                        Console.WriteLine();
                        foreach (var definition in word.English)
                        {
                            Console.Write(definition + "; ");
                        }
                        Console.WriteLine();
                        var guess = Console.ReadLine();
                        Console.WriteLine("answer: " + word.Japanese);
                        if (guess.Equals(word.Japanese) || guess.Equals(word.Romaji))
                        {
                            correct++;
                        }
                        quizBank.RemoveAt(idx);
                    }
                    break;
                
                // hiragana to english quiz
                case "hiragana":
                    Console.WriteLine("You may only answer in english");
                    // add only hiragana words to the quiz
                    foreach (JapaneseWord word in wordBank)
                    {
                        if (word.Writing.Equals("hiragana"))
                        {
                            quizBank.Add(word);
                        }
                    }
                    
                    // begin the quiz and keep track of the score
                    totalWords = quizBank.Count;
                    while (quizBank.Count != 0)
                    {
                        var idx = rand.Next(0, quizBank.Count - 1);
                        var word = (JapaneseWord)quizBank[idx];
                        Console.WriteLine();
                        Console.WriteLine(word.Japanese);
                        var guess = Console.ReadLine();
                        Console.Write("definitions: ");
                        foreach (string definition in word.English)
                        {
                            Console.Write(definition + "; ");
                            if (guess.Equals(definition))
                            {
                                correct++;
                                break;
                            }
                        }
                        Console.WriteLine();
                        quizBank.RemoveAt(idx);
                    }
                    break;
                
                // katakana to english quiz
                case "katakana":
                    Console.WriteLine("You may only answer in english");
                    // add only katakana words to the quiz
                    foreach (JapaneseWord word in wordBank)
                    {
                        if (word.Writing.Equals("katakana"))
                        {
                            quizBank.Add(word);
                        }
                    }
                    
                    // begin the quiz and keep track of the score
                    totalWords = quizBank.Count;
                    while (quizBank.Count != 0)
                    {
                        var idx = rand.Next(0, quizBank.Count - 1);
                        var word = (JapaneseWord)quizBank[idx];
                        Console.WriteLine();
                        Console.WriteLine(word.Japanese);
                        var guess = Console.ReadLine();
                        Console.Write("definitions: ");
                        foreach (string definition in word.English)
                        {
                            Console.Write(definition + "; ");
                            if (guess.Equals(definition))
                            {
                                correct++;
                                break;
                            }
                        }
                        Console.WriteLine();
                        quizBank.RemoveAt(idx);
                    }
                    break;
                
                // kanji to english quiz
                case "kanji":
                    Console.WriteLine("You may only answer in english");
                    // add only words with kanji to the quiz
                    foreach (JapaneseWord word in wordBank)
                    {
                        if (!word.Kanji.Equals(""))
                        {
                            quizBank.Add(word);
                        }
                    }
                    
                    // begin the quiz and keep track of the score
                    totalWords = quizBank.Count;
                    while (quizBank.Count != 0)
                    {
                        var idx = rand.Next(0, quizBank.Count - 1);
                        var word = (JapaneseWord)quizBank[idx];
                        Console.WriteLine();
                        Console.WriteLine(word.Kanji);
                        var guess = Console.ReadLine();
                        Console.Write("definitions: ");
                        foreach (string definition in word.English)
                        {
                            Console.Write(definition + "; ");
                            if (guess.Equals(definition))
                            {
                                correct++;
                                break;
                            }
                        }
                        Console.WriteLine();
                        quizBank.RemoveAt(idx);
                    }
                    break;
            }

            return ((double)correct/totalWords) * 100;
        }
        
        static void Main(string[] args)
        {
            // ask for chapters of interest
            Console.WriteLine("What chapter(s) would you like to be quizzed on?");
            Console.WriteLine("Option examples: [15] [1, 15, 20] [1-20] [1-5, 15-20] (exclude brackets)");
            var chapterString = Console.ReadLine();
            var chapters = parseChapters(chapterString);
            
            // initialize a Hashtable representing 20 chapters of Genki vocab
            var genkiVocab = JapaneseWord.initGenki();
            
            // initialize a vocab word bank for the quiz
            var wordBank = new ArrayList();
            foreach (var chapter in chapters)
            {
                var vocabList = ((JapaneseWord[])genkiVocab[chapter]);
                foreach (var word in vocabList)
                {
                    wordBank.Add(word);
                }
            }
            
            // ask for type of quiz
            Console.WriteLine("What would you like to be quizzed on?");
            Console.WriteLine("Options: [english] [hiragana] [katakana] [kanji]");
            var type = Console.ReadLine();
            
            // set output encoding to recognize Japanese characters, and start the quiz
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var score = quiz(wordBank, type);
            Console.WriteLine("Your score for the quiz is: " + Math.Round(score) + "%!");
        }
    }
}