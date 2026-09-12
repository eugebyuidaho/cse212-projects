using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Scenario: Enqueue "A" (1), "B" (5), "C" (3). Dequeue once.
    // Expected Result: "B", the middle one, is returned because it has the highest priority.
    // Defect(s) Found: None.
    // The method read the queue but never removed the item from the list. Fixed by adding _queue.RemoveAt(highPriorityIndex); to the DeQueue method. 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result);
    }

    

    [TestMethod]
    //Scenario: Enqueue "A" (1), "B" (3), "C" (5). Dequeue once.
    // Expected Result: "C", the last one, is returned because it has the highest priority.
    // Defect(s) Found: Excpected "C", Actual "A". The DeQueue method used index < _queue.Count - 1 instead of index < _queue.Count, 
    // which caused the last item to be ignored when searching for the highest priority item. 
    // Fixed by deleting the -1 from the DeQueue method.

    public void TestPriorityQueue_2()
    {
            var priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue("A", 1);
            priorityQueue.Enqueue("B", 3);
            priorityQueue.Enqueue("C", 5);

            var result = priorityQueue.Dequeue();
            Assert.AreEqual("C", result);
        
    }
    [TestMethod]
    //Scenario: Enqueue "A" (5), "B" (1), "C" (3). Dequeue once.
    // Expected Result: "A", the first one, is returned because it has the highest priority.
    // Defect(s) Found: None.

    public void TestPriorityQueue_3()
    {
            var priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue("A", 5);
            priorityQueue.Enqueue("B", 1);
            priorityQueue.Enqueue("C", 3);

            var result = priorityQueue.Dequeue();
            Assert.AreEqual("A", result);
        



    }
    
    [TestMethod]
    //Scenario: Enqueue "A" (5), "B" (2), "C" (5). Dequeue once.Two items tie for highest priority.
    // Expected Result: "A" is returned because it is closest to the front of the queue.
    // Defect(s) Found: In this case I found that the DeQueue method used >= instead of >, 
    // which caused the last item to be returned instead of the first item in the case of a tie.
    // Fixed by changing >= to >.

    public void TestPriorityQueue_4()
    {
            var priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue("A", 5);
            priorityQueue.Enqueue("B", 2);  
            priorityQueue.Enqueue("C", 5);

            var result = priorityQueue.Dequeue();
            Assert.AreEqual("A", result);


    }

    [TestMethod]
    //Scenario: Dequeue from an empty queue.
    // Expected Result: "InvalidOperationException" with the message "Queue is empty."
    // Defect(s) Found: None

    public void TestPriorityQueue_5()
    {
            var priorityQueue = new PriorityQueue();

            try
            {
                priorityQueue.Dequeue();
                Assert.Fail("Exception should have been thrown.");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("The queue is empty.", e.Message);
            }
            catch (Exception e)
            {
                Assert.Fail(string.Format("Unexpected exception type: {0}" + " caught: {1}", e.GetType(), e.Message));
            }
    }
        
}