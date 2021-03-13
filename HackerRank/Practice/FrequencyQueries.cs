using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace HackerRank.Practice
{
    public class FrequencyQueries : BaseExcercise, IExcercise
    {
        public FrequencyQueries()
        {
        }

        public void Run()
        {
            var q = new List<List<int>>()
            {
            };

            string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] lines = System.IO.File.ReadAllLines($"{directoryName}/TestFiles/Frequency/input05.txt");

            q.AddRange(lines.Select(l => new List<int>() { Convert.ToInt32(l.Split(' ')[0]), Convert.ToInt32(l.Split(' ')[1]) }));


            var dic = new Dictionary<int, int>();
            var freq = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (List<int> query in q)
            {
                var action = query[0];
                var value = query[1];
                if (action == 3)
                {
                    if (freq.ContainsKey(value))
                        result.Add(1);
                    else
                        result.Add(0);
                    continue;
                }

                AddOrUpdate(dic, value, action, freq);
            }
        }

        public static void Remove(Dictionary<int, int> freq, int freqValue)
        {
            freq[freqValue]--;
            if (freq[freqValue] == 0)
                freq.Remove(freqValue);
        }

        public static void AddOrUpdateFreq(Dictionary<int, int> freq, int freqValue)
        {
            if (freqValue <= 0)
                return;
            if (freq.ContainsKey(freqValue))
                freq[freqValue]++;
            else
                freq.Add(freqValue, 1);
        }

        public static void AddOrUpdate(Dictionary<int,int> dic, int value, int action, Dictionary<int, int> freq)
        {
            if(action == 1)
            {
                if (dic.ContainsKey(value))
                {
                    Remove(freq, dic[value]);
                    dic[value]++;
                }
                else
                    dic.Add(value, 1);         

                AddOrUpdateFreq(freq, dic[value]);
            }
            else if (action == 2 && dic.ContainsKey(value))
            {
                Remove(freq, dic[value]);
                Remove(dic, value);
                if(dic.ContainsKey(value))
                    AddOrUpdateFreq(freq, dic[value]);
            }
        }
    }
}
