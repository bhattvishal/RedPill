using System;
using System.Collections.Generic;
using VB.RedPill.Contracts;
//using VB.RedPill.WcfRole.ReadifyRedPillServiceReference;

namespace VB.RedPill.WcfRole
{
    internal static class Utils
    {
        /// <summary>
        /// Calculates the Fibonacci Number for the given number
        /// </summary>
        /// <param name="num">Number</param>
        /// <returns>Fibonacci Number</returns>
        public static long GetFibonacciNumber(long num)
        {
            try
            {
                if (Math.Abs(num) > 92)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (num == 0)
                {
                    return 0;
                }

                if (num == 1 || num == 2)
                {
                    return 1;
                }

                long current = 1;
                long next = 1;
                for (int i = 3; i <= num; i++)
                {
                    long sum = current + next;
                    current = next;
                    next = sum;
                }

                return next;
            }
            catch (Exception ex)
            {
                // ToDo : Log Error
                throw ex;
            }
        }

        public static string GetReverseWords(string words)
        {
            try
            {
                if (words == null)
                {
                    throw new ArgumentNullException();
                }

                int index = 0;
                List<char> chars = new List<char>();
                foreach (char chrc in words)
                {
                    if (char.IsWhiteSpace(chrc))
                    {
                        chars.Add(chrc);
                        index = chars.Count;
                    }
                    else
                    {
                        chars.Insert(index, chrc);
                    }
                }
                return new string(chars.ToArray());
            }
            catch (Exception ex)
            {
                // ToDo : Log Error
                throw ex;
            }
        }

        public static TriangleType GetWhatShapeIsThis(int sideA, int sideB, int sideC)
        {
            try
            {
                if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                {
                    return TriangleType.Error;
                }

                if (sideA == int.MaxValue && sideB == int.MaxValue && sideC == int.MaxValue)
                {
                    return TriangleType.Equilateral;
                }

                if (sideA >= int.MaxValue || sideB >= int.MaxValue || sideC >= int.MaxValue)
                {
                    return TriangleType.Error;
                }

                if (sideA >= sideB + sideC || sideA <= Math.Abs(sideB - sideC))
                    return TriangleType.Error;

                if (sideB >= sideA + sideC || sideB <= Math.Abs(sideA - sideC))
                    return TriangleType.Error;

                if (sideC >= sideB + sideA || sideC <= Math.Abs(sideB - sideA))
                    return TriangleType.Error;

                if (sideA == sideB && sideB == sideC)
                {
                    return TriangleType.Equilateral;
                }

                if (sideA == sideB || sideB == sideC || sideC == sideA)
                {
                    return TriangleType.Isosceles;
                }

                return TriangleType.Scalene;
            }
            catch (Exception ex)
            {
                // ToDo : Log Error
                throw ex;
            }
        }
    }
}
