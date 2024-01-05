package EXC2;

public class EXC2 {
    public static void interLeavingQueue(Queue<Integer> queue) {
        int size = queue.size();
        int halfSize = size / 2;

        Stack<Integer> stack = new Stack<>();

        for (int i = 0; i < halfSize; i++) {
            stack.push(queue.remove());
        }

        while (!stack.isEmpty()) {
            queue.add(stack.pop()); 
            queue.add(queue.remove()); 
        }
    }
}

