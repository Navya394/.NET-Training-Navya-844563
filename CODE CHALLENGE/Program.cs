using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace frequency_of_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            string[] Words = inp.Split(' ');
            Dictionary<string, int> wordfreq = new Dictionary<string, int>();
            for( int n=0;n<Words.Length;++n)
            {
                string temp = Words[n];
                if(wordfreq.ContainsKey(temp))
                {
                    wordfreq[temp] = wordfreq[temp] + 1;
                }
                else
                {
                    wordfreq.Add(temp,1);
                }
            }
            foreach(string word in wordfreq.Keys)
            {
                Console.WriteLine("word:{0}-Freq:{1}",word,wordfreq[word]);
            }
            
        }
    }
}











