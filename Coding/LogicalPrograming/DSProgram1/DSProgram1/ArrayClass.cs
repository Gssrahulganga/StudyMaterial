using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProgram1
{
    internal class ArrayClass
    {

        public void SecondHeightest()
        {
            
           
            int[] Arr = { 18, 14, 19, 19, 13, 16, 12, 20, 20};
            int FirstMax = -1;
            int SecondMax = -1;
            var count = Arr.Count();
            for (int i = 0; i < count; i++)
            {
                var val=Arr[i];


                if (Arr[i] > FirstMax)
                {
                    SecondMax = FirstMax;
                    FirstMax = Arr[i];

                }
                else if (Arr[i] > SecondMax && Arr[i] != FirstMax)
                {
                    SecondMax = Arr[i];
                }
            }
            Console.WriteLine(SecondMax);
        }


        public void SortArray()
        {


            int[] Arr = { 18, 14, 19, 19, 13, 16, 12, 20, 20 };
            int FirstMax = -1;
            int SecondMax = -1;
            var count = Arr.Count();
            for (int i = 0; i < count; i++)
            {
                var val = Arr[i];


                if (Arr[i] > FirstMax)
                {
                    SecondMax = FirstMax;
                    FirstMax = Arr[i];

                }
                else if (Arr[i] > SecondMax && Arr[i] != FirstMax)
                {
                    SecondMax = Arr[i];
                }
            }
            Console.WriteLine(SecondMax);
        }



    }
}
