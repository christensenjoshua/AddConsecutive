using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddConsecutive(new int[] { 1, 1, 1, 1 }));
            Console.ReadLine();
        }
        static int AddConsecutive(int[] nums)
        {
            int firstNum = 0;
            int lastNum = 0;
            int output = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int thisNum = nums[i];
                if(i == 0)
                {
                    firstNum = thisNum;
                    lastNum = thisNum;
                    continue;
                }
                if(thisNum == lastNum)
                {
                    output += thisNum;
                }
                if (i == nums.Length - 1 && thisNum == firstNum)
                {
                    output += thisNum;
                }
                lastNum = thisNum;
            }
            return output;
        }
    }
}
