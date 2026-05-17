using LeetCodeCSharp.Solutions;
using Xunit;

namespace LeetCodeCSharp.Tests.Solutions;

public class AddTwoNumbersTests
{
    private readonly AddTwoNumbers _sut = new();

    private static int[] ToArray(ListNode? node)
    {
        var result = new List<int>();
        while (node != null) { result.Add(node.val); node = node.next; }
        return [.. result];
    }

    [Fact]
    public void Example1_342Plus465_Returns807()
    {
        // 342 + 465 = 807  =>  [7, 0, 8]
        var result = _sut.Solve(ListNode.From(2, 4, 3), ListNode.From(5, 6, 4));
        Assert.Equal([7, 0, 8], ToArray(result));
    }

    [Fact]
    public void Example2_ZeroPlusZero_ReturnsZero()
    {
        var result = _sut.Solve(ListNode.From(0), ListNode.From(0));
        Assert.Equal([0], ToArray(result));
    }

    [Fact]
    public void Example3_LargeNumbers_ReturnsCorrectSum()
    {
        // 9999999 + 9999 = 10009998  =>  [8, 9, 9, 9, 0, 0, 0, 1]
        var result = _sut.Solve(
            ListNode.From(9, 9, 9, 9, 9, 9, 9),
            ListNode.From(9, 9, 9, 9));
        Assert.Equal([8, 9, 9, 9, 0, 0, 0, 1], ToArray(result));
    }

    [Fact]
    public void UnequalLengths_ShortPlusLong_ReturnsCorrectSum()
    {
        // 5 + 645 = 650  =>  [0, 5, 6]
        var result = _sut.Solve(ListNode.From(5), ListNode.From(5, 4, 6));
        Assert.Equal([0, 5, 6], ToArray(result));
    }

    [Fact]
    public void CarryPropagates_999Plus1_Returns1000()
    {
        // 999 + 1 = 1000  =>  [0, 0, 0, 1]
        var result = _sut.Solve(ListNode.From(9, 9, 9), ListNode.From(1));
        Assert.Equal([0, 0, 0, 1], ToArray(result));
    }

    [Fact]
    public void SingleDigitNoCarry_ReturnsCorrectSum()
    {
        // 3 + 4 = 7
        var result = _sut.Solve(ListNode.From(3), ListNode.From(4));
        Assert.Equal([7], ToArray(result));
    }

    [Fact]
    public void SingleDigitWithCarry_ReturnsCorrectSum()
    {
        // 7 + 8 = 15  =>  [5, 1]
        var result = _sut.Solve(ListNode.From(7), ListNode.From(8));
        Assert.Equal([5, 1], ToArray(result));
    }
}
