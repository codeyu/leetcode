// Source : https://leetcode.com/problems/jump-game/ 
// Author : codeyu 
// Date : Friday, November 11, 2016 11:57:16 PM 

/**********************************************************************************
*
* 
* Given an array of non-negative integers, you are initially positioned at the first index of the array.
* 
* 
* Each element in the array represents your maximum jump length at that position. 
* 
* 
* Determine if you are able to reach the last index.
* 
* 
* 
* For example:
* A = [2,3,1,1,4], return true.
* 
* 
* A = [3,2,1,0,4], return false.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution055 
    {
        public static bool CanJump(int[] nums) 
        {
            if(nums == null || nums.Length == 0) return false;  
            int reach = 0;  
            for(int i=0; i<=reach && i<nums.Length; i++)  
            {  
                reach = Math.Max(nums[i]+i, reach);  
            }  
            if(reach < nums.Length - 1) return false;  
            return true;
        }
    }
}

