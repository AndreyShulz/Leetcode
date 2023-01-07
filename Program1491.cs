/*
1491. Average Salary Excluding the Minimum and Maximum Salary
Easy
1.1K
124
Companies
You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.

 

Example 1:

Input: salary = [4000,3000,1000,2000]
Output: 2500.00000
Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
Average salary excluding minimum and maximum salary is (2000+3000) / 2 = 2500
Example 2:

Input: salary = [1000,2000,3000]
Output: 2000.00000
Explanation: Minimum salary and maximum salary are 1000 and 3000 respectively.
Average salary excluding minimum and maximum salary is (2000) / 1 = 2000
 

Constraints:

3 <= salary.length <= 100
1000 <= salary[i] <= 106
All the integers of salary are unique.


/// Hint

Get the total sum and subtract the minimum and maximum value in the array. Finally divide the result by n - 2.
*/
/*
public class Solution2 {
    static void Main(string[] args){
    double Average(int[] salary) {
        
        if (salary.Length <= 2) // If we have 0, 1, or 2 elements, our average excluding the max and min will be 0.
        {
            return 0;
        }
        // Multiply result by 1.0 to convert to double
        return 1.0*(salary.Sum() - salary.Max() - salary.Min()) / (salary.Count()-2); 
    }  Console.WriteLine(Average(new int[] {4000,3000,1000,2000})); 
}   
}
*/