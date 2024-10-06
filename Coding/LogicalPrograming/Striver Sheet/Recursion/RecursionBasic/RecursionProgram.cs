using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionBasic
{
    internal class RecursionProgram
    {

        private int sumOfnumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int a = sumOfnumbers(n - 1);
                Console.WriteLine($"n : {n}, a : {a}");
                return n + a;
            }



        }
        private int sumOfnumbersWithParmiterise(int i,int sum)
        {
            if (i<= 0)
            {
                Console.WriteLine($"sum : {sum}");
                return sum;
            }
            else
            {
                Console.WriteLine($"i : {i}, sum : {sum}");
                return sumOfnumbersWithParmiterise(i-1,sum+i);
              
               
            }



        }

        private int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * factorial(n - 1);




        }

        int call = 0;
        private int fabonacci(int n)
        {
            
            if (n <= 1)
            {
                return n;
            }
            
            int a = fabonacci(n - 1);
            int b = fabonacci(n - 2);
            call++;
            Console.WriteLine($"call=>{call} a :{a}, b :{b}, a+b:{a+b}");

            return a + b;
        }

        private int fabonacci1(int n)
        {
            //0,1,1,2,3,5,8,13,21,34

            if (n <= 1)
            {
                return n;
            }
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;


        }

      //  int[] arr = { 1, 4, 7, 3, 6, 9, 0 };
        private int[] reverse(int i,int l,int[] arr)
        {
            if(i <= l/2)
            {
                swap(i, l,arr);
              return  reverse(i + 1, l - 1,arr);

            }
            return  arr;
        }

        private int[] reverse1(int i, int l,int [] arr)
        {
            if (i <= l / 2)
            {
                swap(i, l-i-1, arr);
                return reverse1(i + 1, l, arr);

            }
            return arr;
        }

        private void swap(int i,int j,int[] arr) {

            int temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
        }
        private bool palindrome(int i, int n, int[] arr) 
            {
                if (i >= n / 2)
                    return true;
            var t = n - i - 1;
                if (arr[i] != arr[t])
                    return false;
                return palindrome(i + 1, n, arr);



            
            
        }

        private bool palindrome1(int i,int n,string arr)
        {
            if(i>=arr.Length/2)
            {
                return true;
            }
            if(arr[i] != arr[n-i-1])
                return false;
            return palindrome1(i + 1,n, arr);
        }
        public void Main()
        {
            // Console.WriteLine($"Sum of No :{sumOfnumbers(3)}");//Sum of No. 6 is:  6+5+4+3+2+1 OutPut is:21 
            //  Console.WriteLine($"Sum of No :{sumOfnumbersWithParmiterise(3,0)}");//Sum of No. 6 is:  6+5+4+3+2+1 OutPut is:21 
            //  Console.WriteLine($"Factorial :{factorial(5)}");//factorial of 5: 5*4*3*2*1  OutPut is:120 
            //  Console.WriteLine($"Fabonacci :{fabonacci(7)}");//fabonacci of 7 : 0,1,1,2,3,5,8,13,21  OutPut is:13 
            //Console.WriteLine($"Fabonacci-1 :{fabonacci1(7)}");//fabonacci of 7 : 0,1,1,2,3,5,8,13,21  OutPut is:13 
            //  Console.WriteLine($"reverse :{ string.Join(",",reverse(0,6,new int[] { 1, 4, 7, 3, 6, 9, 0 }))}");//reverse of   OutPut is:120 
            Console.WriteLine($"reverse :{string.Join(",", reverse1(0, 7, new int[] { 1, 4, 7, 3, 6, 9, 0 }))}");//reverse-1 of  OutPut is:120 
           // Console.WriteLine($"palindrome :{palindrome(0, 5, new int[] { 1,2,3,2,1 })}");//palindrome of  OutPut is:tre/false 
            Console.WriteLine($"palindrome :{palindrome1(0, 9, "MADDADDAM")}");//palindrome of  OutPut is:tre/false 


        }


    }
}
