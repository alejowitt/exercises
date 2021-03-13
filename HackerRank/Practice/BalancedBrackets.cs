using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HackerRank.Practice
{
    public class BalancedBrackets : BaseExcercise, IExcercise
    {
        public BalancedBrackets()
        {
        }

        public void Run()
        {
            string s = "[()][{}()][](){}([{}(())([[{}]])][])[]([][])(){}{{}{[](){}}}()[]({})[{}{{}([{}][])}]";
            string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] lines = System.IO.File.ReadAllLines($"{directoryName}/TestFiles/inputbalanced.txt");
            var q = new List<string>();
            q.AddRange(lines);

            foreach(var l in q)
            {

                var r = isBalanced(l);
            }
        }

        static string isBalanced(string s)
        {

            var q = new Stack();
            var currentIndex = 0;
            foreach (var c in s)
            {
                
                if (c == '{' || c == '[' || c == '(')
                {
                    if (currentIndex == s.Length - 1 && q.Count != 0)
                        return "NO";
                    q.Push(c);
                }
                else
                {
                    if (q.Count == 0)
                        return "NO";

                    switch (c)
                    {
                        case '}':
                            if ((char)q.Peek() != '{')
                                return "NO";
                            break;
                        case ')':
                            if ((char)q.Peek() != '(')
                                return "NO";
                            break;
                        case ']':
                            if ((char)q.Peek() != '[')
                                return "NO";
                            break;
                    }
                    q.Pop();
                }
                currentIndex++;
            }
            return "YES";
        }
    }
}
