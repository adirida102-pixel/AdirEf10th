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

        public int[] GetNeighbors(int r, int c)
        {
            int[] neighbors;
            int neighborNum = 0;
            int index = 0;
            if (r == 0 && c == 0 || r == 0 && c == this.matrix.GetLength(1) || r == this.matrix.GetLength(0) && c == 0 || r == this.matrix.GetLength(0) && c == this.matrix.GetLength(1))
            {
                neighborNum = 3;
            }
            else if (r == 0 || c == 0 || r == this.matrix.GetLength(0) || c == this.matrix.GetLength(1))
            {
                neighborNum = 5;
            }
            else
            {
                neighborNum = 8;
            }
            neighbors = new int[neighborNum];
            if (r == 0 && c == 0)
            {
                for (int row = 0; row < 2; row++)
                {
                    for (int col = 0; col < 2; col++)
                    {
                        if (!(row == r && col == c))
                        {
                            neighbors[index] = this.matrix[row, col];
                            index++;
                        }
                    }
                }
            }
            else if (r == 0 && c == this.matrix.GetLength(1))
            {
                for (int row = 0; row < 2; row++)
                {
                    for (int col = this.matrix.GetLength(1) - 1; col > this.matrix.GetLength(1) - 3; col--)
                    {
                        if (!(row == r && col == c))
                        {
                            neighbors[index] = this.matrix[row, col];
                            index++;
                        }
                    }
                }
            }
            else if (r == this.matrix.GetLength(0) && c == 0)
            {
                for (int row = this.matrix.GetLength(0) - 1; row > this.matrix.GetLength(0) - 3; row--)
                {
                    for (int col = 0; col < 2; col++)
                    {
                        if (!(row == r && col == c))
                        {
                            neighbors[index] = this.matrix[row, col];
                            index++;
                        }
                    }
                }
            }
            else if (r == this.matrix.GetLength(0) && c == this.matrix.GetLength(1))
            {
                for (int row = this.matrix.GetLength(0) - 1; row > this.matrix.GetLength(0) - 3; row--)
                {
                    for (int col = this.matrix.GetLength(1) - 1; col > this.matrix.GetLength(1) - 3; col--)
                    {
                        if (!(row == r && col == c))
                        {
                            neighbors[index] = this.matrix[row, col];
                            index++;
                        }
                    }
                }
            }
            else if (r == 0)
            {
                for (int row = 0; row < 2; row++)
                {
                    for (int col = c - 1; col < c + 3; col++)
                    {
                        if (!(row == r && col == c))
                        {
                            neighbors[index] = this.matrix[row, col];
                            index++;
                        }
                    }
                }
            }
            else if (c == 0)
            {

            }
        }

        public int[,] GetStatus()
        {
            //pass, don't know if this is needed
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
