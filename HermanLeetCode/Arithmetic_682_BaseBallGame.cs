using System.Collections.Generic;
using System.Linq;

namespace HermanLeetCode
{
    public class Arithmetic_682_BaseBallGame
    {
        public static int CalPoints(string[] ops)
        {
            var newOps = new List<int>();
            foreach (var t in ops)
            {
                if (t.Equals("C"))
                {
                    newOps.RemoveAt(newOps.Count - 1);
                }
                else if (t.Equals("+"))
                {
                    newOps.Add(newOps[^1] + newOps[^2]);
                }
                else if (t.Equals("D"))
                {
                    newOps.Add(newOps[^1] * 2);
                }
                else
                {
                    newOps.Add(int.Parse(t));
                }
            }

            return newOps.Sum();
        }

        public static int CalPointsWithStack(string[] ops)
        {
            Stack<int> newStack = new Stack<int>();
            foreach (var t in ops)
            {
                if (t.Equals("C"))
                {
                    newStack.Pop();
                }
                else if (t.Equals("+"))
                {
                    var top = newStack.Pop();
                    var top2 = newStack.Pop();
                    var sum = top + top2;
                    newStack.Push(top2);
                    newStack.Push(top);
                    newStack.Push(sum);
                }
                else if (t.Equals("D"))
                {
                    newStack.Push(newStack.Peek() * 2);
                }
                else
                {
                    newStack.Push(int.Parse(t));
                }
            }

            return newStack.Sum();
        }
    }
}