public class TakingTurnsQueue  
{  
    private class PersonNode  
    {  
        public string Name { get; }  
        public int TurnsRemaining { get; set; }  
        
        public PersonNode(string name, int turns)  
        {  
            Name = name;  
            TurnsRemaining = turns;  
        }  
    }  

    private readonly Queue<PersonNode> _queue = new Queue<PersonNode>();  

    public int Length => _queue.Count;  

    public void AddPerson(string name, int turns)  
    {  
        _queue.Enqueue(new PersonNode(name, turns));  
    }  

    public Person GetNextPerson()  
    {  
        if (_queue.Count == 0)  
        {  
            throw new InvalidOperationException("No one in the queue.");  
        }  

        var current = _queue.Dequeue();  
        var result = new Person(current.Name, current.TurnsRemaining);  

        // Handle turns logic  
        if (current.TurnsRemaining > 1)  
        {  
            // Finite turns remaining - decrement and requeue  
            current.TurnsRemaining--;  
            _queue.Enqueue(current);  
        }  
        else if (current.TurnsRemaining <= 0)  
        {  
            // Infinite turns - requeue without changing turns  
            _queue.Enqueue(current);  
        }  
        // Else (turns == 1) - don't requeue  

        return result;  
    }  
}  