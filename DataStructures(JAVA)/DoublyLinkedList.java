public class DoublyLinkedList {

    class Node {
        int data;
        Node prev;
        Node next;

        Node(int data) {
            this.data = data;
        }
    }
    private Node head;
    private Node tail;
    public void printList() {
        if (head == null) {
            System.out.println("List is empty");
            return;
        }
        Node current = head;
        while (current != null) {
            System.out.print(current.data + " ");
            current = current.next;
        }
        System.out.println();
    }
    public void insertToBeginning(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            tail = newNode;
        } else {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
    }
    public void insertToEnd(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            tail = newNode;
        } else {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
    }
    public void insertToMiddle(int data, int position) {
        Node newNode = new Node(data);
        if (head == null || position <= 1) {
            insertToBeginning(data);
            return;
        }
        Node current = head;
        int count = 1;
        while (count < position - 1 && current.next != null) {
            current = current.next;
            count++;
        }
        if (current.next == null) {
            current.next = newNode;
            newNode.prev = current;
            tail = newNode;
        } else {
            newNode.next = current.next;
            newNode.prev = current;
            current.next.prev = newNode;
            current.next = newNode;
        }
    }
    public void deleteFromBeginning() {
        if (head == null) {
            System.out.println("List is empty");
            return;
        }
        if (head == tail) {
            head = null;
            tail = null;
        } else {
            head = head.next;
            head.prev = null;
        }
    }
    public void deleteFromEnd() {
        if (head == null) {
            System.out.println("List is empty");
            return;
        }
        if (head == tail) {
            head = null;
            tail = null;
        } else {
            tail = tail.prev;
            tail.next = null;
        }
    }
    public void deleteFromMiddle(int position) {
        if (head == null || position <= 1) {
            deleteFromBeginning();
            return;
        }
        Node current = head;
        int count = 1;
        while (count < position && current != null) {
            current = current.next;
            count++;
        }
        if (current == tail) {
            tail = tail.prev;
            tail.next = null;
        } else if (current != null) {
            current.prev.next = current.next;
            if (current.next != null) {
                current.next.prev = current.prev;
            }
        }
    }
    public static void main(String[] args) {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.insertToBeginning(3);
        dll.insertToBeginning(2);
        dll.insertToEnd(4);
        dll.printList(); 
        dll.deleteFromBeginning();
        dll.deleteFromEnd();
        dll.printList();
    }
}
