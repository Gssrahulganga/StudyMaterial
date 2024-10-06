

namespace DSProgram1.Arrays
{
    internal class SetMatrixZero
    {
        //BruteForceApproach
        /*
3
4 4
1 2 3 4
5 6 0 8
9 10 11 12
13 14 15 16
3 4
1 2 3 4
5 6 7 8
9 0 11 12
5 4
1 2 3 4
5 6 7 8
9 0 11 12
13 14 15 16
17 18 0 20
         */
        private void BruteForceApproach(int caseNum, int COL, int Row, int[,] arrayValues)
        {
            if (arrayValues.Length > 0)
            {
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        if (arrayValues[i,j] == 0)
                        {
                            SetCOL_BruteForceApproach(i, COL,arrayValues);
                            SetRow_BruteForceApproach(j, Row, arrayValues);
                        }
                    }

                }
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                       Console.Write(arrayValues[i,j]+" ");
                    }
                    Console.WriteLine("");

                }

               

            }

        }

        public void SetCOL_BruteForceApproach(int COL,int COLs,  int[,] arrayValues)
        {
            for (int i = 0; i < COLs; i++)
            {
                
                    arrayValues[COL, i] = -1;
                
            }
        }

        public void SetRow_BruteForceApproach(int Row, int Rows, int[,] arrayValues)
        {
            for (int i = 0; i < Rows; i++)
            {

                arrayValues[i, Row] = -1;

            }
        }

        public void Main_BruteForceApproach()
        {
            int T = int.Parse(Console.ReadLine()); //Number of Test Cases




            for (int t = 1; t <= T; t++)
            {
                string[] Inputs = Console.ReadLine().Split(); //Number of Test Cases
                int Row  = int.Parse(Inputs[0]); //Number of COLs 
                int COL = int.Parse(Inputs[1]); //Number of Rowumns
                int[,] ArrayValues = new int[ Row,COL];
                for (int j = 0; j < Row; j++)
                {
                    string[] COLs = Console.ReadLine().Split();

                    for (int k = 0; k < COL; k++)
                    {

                        ArrayValues[j, k] = int.Parse(COLs[k]);


                    }



                }
                Console.WriteLine("\n");
                BruteForceApproach(t, COL, Row, ArrayValues);
                Console.WriteLine("\n");

            }






        }
/*
3
4 4
1 2 3 4
5 6 0 8
9 10 11 12
13 14 15 16
3 4
1 2 3 4
5 6 7 0
9 0 11 12
5 4
1 2 3 4
5 6 7 8
9 0 0 12
13 14 15 16
17 18 0 20
*/

        public void Main_BetterApproach()
        {
            int T = int.Parse(Console.ReadLine()); //Number of Test Cases




            for (int t = 1; t <= T; t++)
            {
                string[] Inputs = Console.ReadLine().Split(); //Number of Test Cases
                int Row = int.Parse(Inputs[0]); //Number of COLs 
                int COL = int.Parse(Inputs[1]); //Number of Rowumns
                int[,] ArrayValues = new int[Row, COL];
                for (int j = 0; j < Row; j++)
                {
                    string[] COLs = Console.ReadLine().Split();
                    for (int k = 0; k < COL; k++)
                    {
                        ArrayValues[j, k] = int.Parse(COLs[k]);
                    }
                }
                Console.WriteLine("\n");
                BetterApproach(t, COL, Row, ArrayValues);
                Console.WriteLine("\n");
            }






        }

        private void BetterApproach(int caseNum, int COL, int Row, int[,] arrayValues)
        {
            Console.WriteLine("caseNum:"+ caseNum);
            int[] TempRow= new int[Row];
            int[] TempCOL = new int[COL];
            if (arrayValues.Length > 0)
            {

                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        if (arrayValues[i, j] == 0)
                        {
                            TempRow[i] = 1;
                            TempCOL[j] = 1;
                        }
                    }

                }

                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        if (TempRow[i]==1|| TempCOL[j]==1)
                        {
                            arrayValues[i, j] = 0;
                        }
                    }

                }


                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        Console.Write(arrayValues[i, j] + " ");
                    }
                    Console.WriteLine("");

                }



            }

        }






    }
}
