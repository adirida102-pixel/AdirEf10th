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

        public int[,] GetMatrix()
        {
            return this.matrix;
        }

        public void SetMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    this.matrix[row, col] = matrix[row, col];
                }
            }
        }

        public int[] GetNeighbors()
        {
            //pass
        }

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
