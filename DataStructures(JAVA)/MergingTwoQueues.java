
import java.util.LinkedList;
import java.util.Queue;

public class MergingTwoQueues {

    public static Queue mergeSortedQueues(Queue q1, Queue q2) {
        Queue mergedQueue = new LinkedList();

        while (!q1.isEmpty() && !q2.isEmpty()) {
            if (q1.peek() <= q2.peek())
                mergedQueue.add(q1.poll());
            else
                mergedQueue.add(q2.poll());
        }

        while (!q1.isEmpty())
            mergedQueue.add(q1.poll());

        while (!q2.isEmpty())
            mergedQueue.add(q2.poll());

        return mergedQueue;
    }

    public static void printQueue(Queue queue) {
        for (Integer value : queue) {
            System.out.print(value + " ");
        }
        System.out.println();
    }

    public static void main(String[] args) {
        Queue queue1 = new LinkedList();
        queue1.add(5);
        queue1.add(7);
        queue1.add(8);
        queue1.add(12);
        queue1.add(20);

        Queue queue2 = new LinkedList();
        queue2.add(4);
        queue2.add(9);
        queue2.add(13);
        queue2.add(25);
        queue2.add(30);

        System.out.println("Queue 1:");
        printQueue(queue1);
        System.out.println("Queue 2:");
        printQueue(queue2);
        Queue mergedQueue = mergeSortedQueues(queue1, queue2);
        System.out.println("Merged Queue:");
        printQueue(mergedQueue);
    }
}
