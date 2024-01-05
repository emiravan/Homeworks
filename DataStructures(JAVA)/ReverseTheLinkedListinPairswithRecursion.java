package EXC1;

public class EXC1 {
    public static Node ReversePairRecursive(Node head) {
        if (head == null || head.next == null) {
            return head;
        }

        Node firstNode = head;
        Node secondNode = head.next;

        firstNode.next = ReversePairRecursive(secondNode.next);
        secondNode.next = firstNode;

        return secondNode;
    }
}

