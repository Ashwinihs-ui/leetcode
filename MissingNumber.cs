using System;

public class MissingNumberFinder
{
    public int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int totalSum = n * (n + 1) / 2;
        int currentSum = 0;

        foreach (int num in nums)
        {
            currentSum += num;
        }
        return totalSum - currentSum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MissingNumberFinder finder = new MissingNumberFinder();
        int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 }; //output=8
        int missingNumber = finder.FindMissingNumber(nums);
        Console.WriteLine("Missing number in the array is:" + missingNumber);

    }
}

//Algorithm
/*
  step 1:start
  step 2:An array nums[] containing n distinct numbers in the range[0,n],where one number is missing
  step 3:calculate totalSum of integers from 0 to n
        totalSum=n*(n+1)/2
  step 4:initialize currentSum to 0,which will be used to store the sum of elements in the array nums[]
  step 5:loop through each element num in the array nums[] and add it to currentSum
        currentSum=currentSum+num
  step 6:calculate the missing number by subtracting currentSum from totalSum
        missingNumber=totalSum-currentSum
  step 7:print missingNumber
  step 8:stop
*/



