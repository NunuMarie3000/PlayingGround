namespace TestInCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      // TWOSUM
      int[] nums = { 3, 2, 4 };
      int target = 6;
      int[] response = TwoSum(nums, target);
      foreach(int num in response)
        Console.Write(num + " ,");


      // VALID PARENTHESES

    }

    static bool IsValid(string s)
    {
      
    }

    static int[] TwoSum(int[] nums, int target)
    {
      int[] response = new int[2];
      for(int i=0; i<nums.Length; i++)
      {
        for(int j=i+1; j<nums.Length; j++)
        {
          if(nums[i] + nums[j] == target)
          {
            response[0] = i;
            response[1] = j;
          }
        }
      }
      return response;
    }
  }
}