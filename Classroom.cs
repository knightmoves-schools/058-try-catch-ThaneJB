namespace knightmoves;

public class Classroom{

    public string FindMember(int memberIndex, string[] members){
       
       try
        {
            return members[memberIndex];
        } catch (IndexOutOfRangeException indexOutOfRangeException)
        {
            return indexOutOfRangeException.Message;
        }
        

    }
}