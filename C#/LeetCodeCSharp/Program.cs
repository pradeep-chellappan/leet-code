using LeetCodeCSharp.Solutions;

var twoSum = new TwoSum();
int[] result = twoSum.Solve([2, 7, 11, 15], 9);
Console.WriteLine($"TwoSum([2,7,11,15], 9) => [{result[0]}, {result[1]}]"); // [0, 1]

// AddTwoNumbers: 342 + 465 = 807 => [7, 0, 8]
var addTwo = new AddTwoNumbers();
var sum = addTwo.Solve(ListNode.From(2, 4, 3), ListNode.From(5, 6, 4));
Console.WriteLine($"AddTwoNumbers([2,4,3], [5,6,4]) => {sum}"); // [7, 0, 8]
