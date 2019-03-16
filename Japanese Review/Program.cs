/*
 * @author - Ryan Chung
 * This program will initialize 20 chapters worth of Japanese vocab from the Genki I & II textbooks
 */

using System;
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
        /*
         * 
         */
        
        //Sample 02: Define Task/Wait Callback function

        
        static void Main(string[] args)
        {
            // 20 chapters of vocab from the genki textbook
            
            Console.WriteLine("What chapter(s) would you like to be quizzed on?");
            Console.WriteLine("Option examples: [15] [1, 15, 20] [1-20] [1-5, 15-20] (exclude brackets)");
            var chapterString = Console.ReadLine();
            
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
            
            var genkiVocab = new JapaneseWord[20][];
            genkiVocab = JapaneseWord.initGenki(prunedChapters);
            

        }
    }
}