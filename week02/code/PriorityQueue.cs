public class PriorityQueue  
{  
    private class QueueItem  
    {  
        public string Name { get; }  
        public int Priority { get; }  
        public DateTime EnqueueTime { get; }  

        public QueueItem(string name, int priority)  
        {  
            Name = name;  
            Priority = priority;  
            EnqueueTime = DateTime.Now;  
        }  
    }  

    private readonly List<QueueItem> _queue = new List<QueueItem>();  

    public int Length => _queue.Count;  

    public void Enqueue(string name, int priority)  
    {  
        var item = new QueueItem(name, priority);  
        _queue.Add(item);  
        // Sort by priority descending, then by enqueue time ascending  
        _queue.Sort((x, y) =>   
        {  
            if (x.Priority != y.Priority)  
                return y.Priority.CompareTo(x.Priority);  
            return x.EnqueueTime.CompareTo(y.EnqueueTime);  
        });  
    }  

    public string Dequeue()  
    {  
        if (_queue.Count == 0)  
        {  
            throw new InvalidOperationException("Queue is empty");  
        }  

        var item = _queue[0];  
        _queue.RemoveAt(0);  
        return item.Name;  
    }  

    public override string ToString()  
    {  
        return $"[{string.Join(", ", _queue.Select(i => $"{i.Name} (Pri:{i.Priority})"))}]";  
    }  
}  