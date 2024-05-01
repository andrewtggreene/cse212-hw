public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Creating a queue with objects Third priority 1, Second priority 2, First priority 3
        // Expected Result: The results should print Third Second First, Third Second, Third,[]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Third",1);
        priorityQueue.Enqueue("Second",2);
        priorityQueue.Enqueue("First",3);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: No objects were actually removed. The middle object was removed before the highest priority object

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with 3 objects with the same priority and then two more objects with different priorities
        // Expected Result: [Second, Third, Fourth, Fifth, First] First Second Third Fourth Fifth "The Queue is empty"
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Second",1);
        priorityQueue2.Enqueue("Third",1);
        priorityQueue2.Enqueue("Fourth",1);
        priorityQueue2.Enqueue("Fifth",-2);
        priorityQueue2.Enqueue("First",2);
        Console.WriteLine(priorityQueue2);
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine(priorityQueue2.Dequeue());
        // Defect(s) Found: The order they were removed was incorrect as the ones with priority 1 were removed first. Multiple priority values also
        // incorrectly dequeued.

        Console.Write("---------");

        // Add more Test Cases As Needed Below
    }
}