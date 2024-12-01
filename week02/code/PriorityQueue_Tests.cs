using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: New queue, add two items of the same priority
    // Expected Result: When dequeuing, front item should be "test1"
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var testQueue = new PriorityQueue();
        testQueue.Enqueue("test1", 0);
        testQueue.Enqueue("test2", 0);

        Assert.AreEqual("test1", testQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: New queue, add 3 items, middle value higher than either other
    // Expected Result: When dequeuing, item should be "test2", as it's value is highest
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var testQueue = new PriorityQueue();
        testQueue.Enqueue("test1", 1);
        testQueue.Enqueue("test2", 5);
        testQueue.Enqueue("test3", 2);

        Assert.AreEqual("test2", testQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: New queue, add 6 items, 3nd and 5th are of highest value
    // Expected Result: When dequeuing, item should be "test3", as it's value is highest, and is closest to the front
    // Defect(s) Found: Expected:<test3>. Actual:<test5>.
    public void TestPriorityQueue_3()
    {
        var testQueue = new PriorityQueue();
        testQueue.Enqueue("test1", 2);
        testQueue.Enqueue("test2", 4);
        testQueue.Enqueue("test3", 5);
        testQueue.Enqueue("test4", 1);
        testQueue.Enqueue("test5", 5);
        testQueue.Enqueue("test6", 2);

        Assert.AreEqual("test3", testQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: New, empty queue
    // Expected Result: Trying to dequeue should throw an exception with an empty queue
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var testQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => testQueue.Dequeue());
    }
}