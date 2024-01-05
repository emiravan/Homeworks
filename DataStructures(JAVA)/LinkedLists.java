package linkedLists;

public class main {

    public static void main(String[] args) {

        Node head = new Node(6);
        Node nodeB = new Node(3);
        Node nodeC = new Node(4);
        Node nodeD = new Node(2);
        Node nodeE = new Node(1);

        head.next = nodeB;
        nodeB.next = nodeC;
        nodeC.next = nodeD;
        nodeD.next = nodeE;

        int nodeCount = countNodes(head);
        System.out.println("Node count: " + nodeCount);
    }

    public static int countNodes(Node head) {
        int count = 1;
        Node current = head;
        while (current.next != null) {
            current = current.next;
            count++;
        }
        return count;
    }
}

class Node {
    int data;
    Node next;

    Node(int data) {
        this.data = data;
    }
}





















