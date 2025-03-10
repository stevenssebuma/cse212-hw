public static class ArraySelector  
{  
    public static void Run()  
    {  
        // Lists definition  
        var l1 = new[] { 1, 2, 3, 4, 5 };   
        var l2 = new[] { 2, 4, 6, 8, 10 };   
        var select = new[] { 1, 1, 1, 2, 2, 1, 1, 2, 2, 1 };   
        
        var intResult = ListSelector(l1, l2, select);  
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}");  
    }  

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)  
    {  
        var results = new List<int>();  

        // Iterate through the selection array  
        for (int i = 0; i < select.Length; i++)  
        {  
            if (select[i] == 1 && i < list1.Length) // Check bounds for list1  
            {  
                results.Add(list1[i]);  
            }  
            else if (select[i] == 2 && i < list2.Length) // Check bounds for list2  
            {  
                results.Add(list2[i]);  
            }  
        }  

        // Return results as an array  
        return results.ToArray(); 
    }  
}  