public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: adding a node to the back of the queue 
        // Expected Result: the node adds to the back of the queue
        Console.WriteLine("Test 1");
new_nodes = Priority_Queue()
new_nodes.enqueue(2, 0)
new_nodes.enqueue(-1, 3)
new_nodes.enqueue(9.2, -2)
print(new_nodes)
        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Test 2
        // Scenario: removing one of the nodes depending on the priority
        // Expected Result: Result: removoes the node with the highest priority
        Console.WriteLine("Test 2");

        new_nodes = Priority_Queue()
        new_nodes.enqueue(2, 0)
        new_nodes.enqueue(-1, 3)
        new_nodes.enqueue(9.2, -2)
        new = new_nodes.dequeue()
        print(new)