package EXC3;

public class EXC3 {
    private static int[] arr;

    public static boolean checkIfBST(Node root) {
        arr = new int[1000]; 
        
        traversalAlgorithm(root); 
        
        for (int i = 1; i < arr.length; i++) {
            if (arr[i] != 0 && arr[i - 1] >= arr[i]) {
                return false; 
            }
        }
        return true;
    }

    public static int traversalIndex = 0;

    public static void traversalAlgorithm(Node root) {
        if (root != null) {
            traversalAlgorithm(root.leftChild);
            arr[traversalIndex++] = root.data;
            traversalAlgorithm(root.rightChild);
        }
    }
}

