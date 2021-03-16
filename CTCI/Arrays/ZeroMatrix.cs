using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class ZeroMatrix
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns></returns>
		public int[,] modifiedMatrix(int[,] matrix)
		{
			HashSet<int> rows = new HashSet<int>();
			HashSet<int> cols = new HashSet<int>();
			
			for(int i = 0; i<matrix.GetLength(0); i++)
			{
				for(int j =0; j<matrix.GetLength(1); j++)
				{
					if (matrix[i,j] == 0)
					{
						rows.Add(i);
						cols.Add(j);
					}
				}
			}
			//Set the entire row to 0
			foreach(int i in rows)
			{
				for(int k = 0; k<matrix.GetLength(1); k++)
				{
					matrix[i,k] = 0;
				}
			}
			//Set the entire column to 0
			foreach (int j in cols)
			{
				for (int k = 0; k < matrix.GetLength(0); k++)
				{
					matrix[k,j] = 0;
				}
			}
			return matrix;
		}


		public int[,] modifiedMatrixWithoutNewSpace(int[,] matrix)
		{
			bool rowContainsZero = false, columnContainsZero = false;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				if (matrix[i, 0] == 0)
				{
					columnContainsZero = true;
					break;
				}
			}

			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (matrix[0,j] == 0)
				{
					rowContainsZero = true;
					break;
				}
			}

			for(int i = 1; i<matrix.GetLength(0); i++)
			{
				for(int j = 1; j<matrix.GetLength(1); j++)
				{
					if(matrix[i,j] == 0)
					{
						matrix[i, 0] = 0;
						matrix[0, j] = 0;
					}
				}
			}

			for(int i = 1; i < matrix.GetLength(0); i++)
			{
				if(matrix[i,0] == 0)
				{
					for(int j = 0; j<matrix.GetLength(1);j++)
					{
						matrix[i, j] = 0;
					}
				}
			}

			for(int j = 1; j < matrix.GetLength(1); j++)
			{
				if(matrix[0,j] == 0)
				{	
					for(int i = 0; i < matrix.GetLength(0); i++)
					{
						matrix[i, j] = 0;
					}
				}
			}

			if(rowContainsZero)
			{
				for (int j = 0; j<matrix.GetLength(1); j++)
				{
					matrix[0, j] = 0;
				}
			}
			if (columnContainsZero)
			{
				for (int i = 0; i<matrix.GetLength(0); i++)
				{
					matrix[i, 0] = 0;
				}
			}
			return matrix;
		}
	}
}
