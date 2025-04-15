public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            // Duplicate value, do nothing
            return;
        }

        if (value < Data)
        {
            // Insert to the left

            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    { 
        if (this == null)
            return false;

        if (value == Data)
            return true;

        if (value < Data)
        {
            return Left?.Contains(value) ?? false;
        }
        else
        {
            return Right?.Contains(value) ?? false;
        }        

    }

    public int GetHeight()
    {
        if (this == null)
            return 0;

        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return Math.Max(leftHeight, rightHeight) + 1;
        // TODO Start Problem 4
        // Replace this line with the correct return statement(s)
    }
}