public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else  if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value < Data){
            if (Left is null){
                return false;
            } else {
                return Left.Contains(value);
            }
        } else if (value > Data){
            if (Right is null){
                return false;
            } else {
                return Right.Contains(value);
            }
        } else{
            return true;
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
            if (Left is not null && Right is not null){
                int LeftHeight = Left.GetHeight();
                int RightHeight = Right.GetHeight();
                if (LeftHeight > RightHeight) {
                    return LeftHeight + 1;
                } else {
                    return RightHeight + 1;
                }
            } else if (Left is not null){
                return Left.GetHeight() + 1;
            } else if (Right is not null){
                return Right.GetHeight() + 1;
            } else {
                return 1;
            }
        // Replace this line with the correct return statement(s)
    }
}