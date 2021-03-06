// Source : https://leetcode.com/problems/gray-code/?tab=Description 
// Author : codeyu 
// Date : Thursday, March 9, 2017 11:23:37 PM 

/**********************************************************************************
*
* The gray code is a binary numeral system where two successive values differ in only one bit.
* 
* Given a non-negative integer n representing the total number of bits in the code, print the sequence of gray code. A gray code sequence must begin with 0.
* 
* For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:
* 
* 00 - 0
* 01 - 1
* 11 - 3
* 10 - 2
* 
* 
* Note:
* For a given n, a gray code sequence is not uniquely defined.
* 
* For example, [0,2,3,1] is also a valid gray code sequence according to the above definition.
* 
* For now, the judge is able to judge based on one instance of gray code sequence. Sorry about that.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution089
    {
        public static IList<int> GrayCode(int n)
        {
            int count = (int)Math.Pow(2, n);
            List<int> res = new List<int>();
            for (int i = 0; i < count; i++)
            {
                res.Add((i) ^ (i >> 1));
            }
            return res;
        }
        //solution 2
        public static IList<int> GrayCode2(int n)
        {
            var ret = new List<int>();
            ret.Add(0);
            for (var i = 0; i < n; i++)
            {
                var size = ret.Count;
                for (var j = size - 1; j >= 0; j--)
                    ret.Add(ret[j] + size);
            }
            return ret;
        }
    }
}

