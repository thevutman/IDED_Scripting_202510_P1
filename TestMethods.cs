using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            if (stack == null || stack.Count == 0)
                return 0;

            foreach (var num in stack)
            {
                if (EsPrimo(num))
                    return num;
            }

            return 0;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            if (stack == null || stack.Count == 0)
                return stack;

            Stack<uint> temp = new Stack<uint>();
            bool removed = false;

            while (stack.Count > 0)
            {
                uint num = stack.Pop();
                if (!removed && EsPrimo(num))
                {
                    removed = true;
                    continue;
                }
                temp.Push(num);
            }

            while (temp.Count > 0)
            {
                stack.Push(temp.Pop());
            }

            return stack;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            if (stack == null || stack.Count == 0)
                return new Queue<uint>();

            return new Queue<uint>(stack);
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            if (stack == null || stack.Count == 0)
                return new List<uint>();

            return new List<uint>(stack);
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            if (list == null || list.Count == 0)
                return false;

            list.Sort();

            return list.Contains(value);
        }

        private static bool EsPrimo(uint n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            uint limite = (uint)Math.Sqrt(n);
            for (uint i = 3; i <= limite; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}