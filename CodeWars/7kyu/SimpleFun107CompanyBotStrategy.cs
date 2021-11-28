/*
https://www.codewars.com/kata/589a9aadc4e27877cb000027/csharp

7 kyu
Simple Fun #107: Company Bot Strategy

Task
There are some Bots works in CodeFights Company. 
Each CodeFights Company Bot is trained by engineers from that specific company. 
The way it works is that a representative group of engineers from each company is identified as trainers before the bot goes live, 
and they CodeFight against the bot during a training phase. 
The current training algorithm is definitely more complex, but let's assume it works this way:

For each trainer we collect two pieces of information per task
[answerTime, correctness], 
where correctness is 1 if the answer was correct,
                      -1 if the answer was wrong, 
                   and 0 if no answer was given.```

 In this case, the bot's correct answer time for a given task would be the average of the answer times from the trainers who answered correctly. 
 Given all of the training information for a specific task, calculate the bot's answer time.

# Example

 For
trainingData = [[3, 1], [6, 1], [4, 1], [5, 1]]``` the output should be 4.5.

All four trainers have solved the task correctly, so the answer is (3 + 6 + 4 + 5) / 4 = 4.5.

For

trainingData = [[4, 1],
                [4, -1],
                [0, 0],
                [6, 1]]```
the output should be `5.0`.

 Only the `1st` and the `4th` trainers (1-based) submitted correct solutions, so the answer is `(4 + 6) / 2 = 5.0`.

 For
trainingData = [[4, -1], [0, 0], [5, -1]]``` the output should be 0.

No correct answers were given for the task.

Input/Output
[input] 2D integer array trainingData

The ith element of trainingData contains exactly 2 elements:

trainingData[i][0] is the answer time for the ith person and trainingData[i][1] is correctness.

If a trainer answered correctly, then correctness equals 1;

If a trainer answered incorrectly, then correctness equals -1;

If a trainer didn't give any answer, answerTime and correctness both equal to 0.

Constraints:

1 ≤ trainingData.length ≤ 50.

0 ≤ trainingData[i][0] ≤ 100.

-1 ≤ trainingData[i][1] ≤ 1.

[output] a float value

The time the bot will take to solve a specific task. 
Return 0 if none of the trainers answered correctly. 
Your output will be considered correct if its absolute error does not exceed 10-5 compared to our tests.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun107CompanyBotStrategy
    {
        public double CompanyBotStrategy(int[][] TrainingData)
        {
            return TrainingData.Where(a => a[1] == 1).DefaultIfEmpty(new[] {0}).Average(x => x[0]);
            // return TrainingData.Where(a => a[1] == 1).Select(a => a[0]).DefaultIfEmpty().Average();
            // return TrainingData.Where(x => x[1] == 1).Select(x => x[0]).DefaultIfEmpty(0).Average();
            // return TrainingData.Where(x => x[1] > 0).DefaultIfEmpty(new int[] {0}).Average(x => x[0]);
            // return TrainingData.Where(d => d[1] == 1).DefaultIfEmpty(new[] {0, 0}).Average(d => d[0]);
            // return TrainingData.Where(a => a.Last() == 1).Select(a => a.First()).DefaultIfEmpty(0).Average();
            // return TrainingData.Where(data => data[1] > 0).Select(data => data[0]).DefaultIfEmpty().Average();
            // return TrainingData.Any(x => x[1] == 1) ? TrainingData.Where(x => x[1] == 1).Average(y => y[0]) : 0;
            // return TrainingData.Where(data => data[1] == 1).DefaultIfEmpty(new int[] {0, 0}).Average(data => data[0]);
        }
    }
}