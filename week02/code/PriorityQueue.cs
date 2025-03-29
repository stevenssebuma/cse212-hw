public class PriorityQueue  
{  
    private List<PriorityItem> _queue = new();  
    private int _insertionOrder = 0;  

    public void Enqueue(string value, int priority)  
    {  
        var newNode = new PriorityItem(value, priority, _insertionOrder++);  
        
        // Insert in descending priority order, but ascending insertion order for equal priorities  
        int index = 0;  
        while (index < _queue.Count &&   
              (_queue[index].Priority > newNode.Priority ||   
               (_queue[index].Priority == newNode.Priority &&   
                _queue[index].InsertionOrder < newNode.InsertionOrder)))  
        {  
            index++;  
        }  
        _queue.Insert(index, newNode);  
    }  

    public string Dequeue()  
    {  
        if (_queue.Count == 0)  
        {  
            throw new InvalidOperationException("The queue is empty.");  
        }  

        // Always remove from front (highest priority, oldest for equal priorities)  
        var value = _queue[0].Value;  
        _queue.RemoveAt(0);  
        return value;  
    }  

    public override string ToString()  
    {  
        return $"[{string.Join(", ", _queue)}]";  
    }  
}  

internal class PriorityItem  
{  
    internal string Value { get; set; }  
    internal int Priority { get; set; }  
    internal int InsertionOrder { get; set; }  

    internal PriorityItem(string value, int priority, int insertionOrder)  
    {  
        Value = value;  
        Priority = priority;  
        InsertionOrder = insertionOrder;  
    }  

    public override string ToString()  
    {  
        return $"{Value} (Pri:{Priority})";  
    }  
}  