using Lab_1.Logic;
using System.Diagnostics;

namespace Penkov_Lab_1.Logic
{
    internal class CompareArrayTime<T> where T : class, new()
    {


        private long GetTime(T[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();

            foreach (T el in arr)
            {
                el.ToString();
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        private long GetTime(T[,] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();

            foreach (T el in arr)
            {
                el.ToString();
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        private long GetTime(T[][] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (T[] row in arr)
            {
                foreach (T el in row)
                {
                    el.ToString();
                }
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public CompareArrayResult CompareTime(
            T[] oneDimensionArr,
            T[,] twoDimensionArr,
            T[][] stairsArr)
        {


            long oneDimensionTime = this.GetTime(oneDimensionArr);
            long twoDimensionTime = this.GetTime(twoDimensionArr);
            long stairsTime = this.GetTime(stairsArr);

            return new CompareArrayResult()
            {
                OneDimensionTime = oneDimensionTime,
                TwoDimensionTime = twoDimensionTime,
                StairArrayTime = stairsTime
            };
        }
    }
}