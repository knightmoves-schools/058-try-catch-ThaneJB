namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
    - should prevent the `FindMember` method from throwing an `IndexOutOfRangeException` when the `memberIndex` is larger than the size of the `members` array
- should return the first member in the `memebers` array if an `IndexOutOfRangeException` is thrown
*/
    [Fact]
    public void Should_Prevent_The_FindMember_Method_From_Throwing_An_IndexOutOfRangeException_When_The_MemberIndex_Is_Larger_Than_The_Size_Of_The_Members_Array(){
       var classroom = new Classroom();
       var members = new string[]{"first", "second", "third"};

       Assert.Equal("second", classroom.FindMember(1, members));
       classroom.FindMember(100, members);
    }

    [Fact]
    public void Should_Return_The_First_Member_In_The_Members_Array_If_An_IndexOutOfRangeException_Is_Thrown(){
       var classroom = new Classroom();
       var members = new string[]{"first", "second", "third"};

       Assert.Equal("second", classroom.FindMember(1, members));
       Assert.Equal("Index was outside the bounds of the array.", classroom.FindMember(100, members));
    }
}