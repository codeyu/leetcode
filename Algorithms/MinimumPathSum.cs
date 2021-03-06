// Source : https://leetcode.com/problems/minimum-path-sum/ 
// Author : codeyu 
// Date : Sunday, December 11, 2016 4:11:41 PM 

/**********************************************************************************
*
* Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.
* 
* Note: You can only move either down or right at any point in time.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution064 
    {
        public static int MinPathSum(int[,] grid) 
        {
            if(grid == null || grid.GetLength(0) == 0|| grid.GetLength(1)==0)  
                return 0;  
            int[] res = new int[grid.GetLength(1)];  
            res[0] = grid[0,0];  
            for(int i=1;i<grid.GetLength(1);i++)  
            {  
                res[i] = res[i-1]+grid[0,i];  
            }  
            for(int i=1;i<grid.GetLength(0);i++)  
            {  
                for(int j=0;j<grid.GetLength(1);j++)  
                {  
                    if(j==0)  
                        res[j] += grid[i,j];  
                    else  
                        res[j] = Math.Min(res[j-1], res[j])+grid[i,j];  
                }  
            }  
            return res[grid.GetLength(1)-1];
            
        }
    }
}

