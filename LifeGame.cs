using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class LifeGame
    {
        private int[,] matrix;
        
        public static void LifeGame_UT()
        {
            //pass
        }

        public LifeGame(int[,] matrix)
        {
            this.matrix = matrix;
        }

        //public int[] GetNeighbors(int r, int c)
        //{
        //    int[] neighbors;
        //    int neighborNum = 0;
        //    int index = 0;
        //    if (r == 0 && c == 0 || r == 0 && c == this.matrix.GetLength(1) || r == this.matrix.GetLength(0) && c == 0 || r == this.matrix.GetLength(0) && c == this.matrix.GetLength(1))
        //    {
        //        neighborNum = 3;
        //    }
        //    else if (r == 0 || c == 0 || r == this.matrix.GetLength(0) || c == this.matrix.GetLength(1))
        //    {
        //        neighborNum = 5;
        //    }
        //    else
        //    {
        //        neighborNum = 8;
        //    }
        //    neighbors = new int[neighborNum];
        //    //continue later
        //}

        //public int[,] GetStatus()
        //{
        //    //pass, don't know if this is needed
        //}
        
        public void NextGeneration()
        {
            //pass
        }

        public void PrintBoard()
        {
            //pass
        }
    }
}
