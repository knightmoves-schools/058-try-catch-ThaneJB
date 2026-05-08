namespace knightmoves;

public class Classroom{

    public string FindMember(int memberIndex, string[] members){
       
       try
        {
            int length = memberIndex;
            string member = members[100];
        } catch (IndexOutOfRangeException indexOutOfRangeException)
        {
            return indexOutOfRangeException.Message;
        }
       
        return members[memberIndex];

    }
}