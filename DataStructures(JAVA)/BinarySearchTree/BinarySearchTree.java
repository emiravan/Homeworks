package EXC2;

public class BinarySearchTree {
    private Node root;

    private class Node {
        private Student student;
        private Node left;
        private Node right;

        public Node(Student student) {
            this.student = student;
            this.left = null;
            this.right = null;
        }
    }

    public void insert(Student student) {
        root = insertRec(root, student);
    }

    private Node insertRec(Node root, Student student) {
        if (root == null) {
            root = new Node(student);
            return root;
        }

        if (student.getStudentId() < root.student.getStudentId()) {
            root.left = insertRec(root.left, student);
        } else if (student.getStudentId() > root.student.getStudentId()) {
            root.right = insertRec(root.right, student);
        }

        return root;
    }
    
    public void inOrder() {
        inOrderRec(root);
    }

    private void inOrderRec(Node root) {
        if (root != null) {
            inOrderRec(root.left);
            System.out.println(root.student.toString());
            inOrderRec(root.right);
        }
    }
    
    public void delete(int studentId) {
        root = deleteRec(root, studentId);
    }

    private Node deleteRec(Node root, int studentId) {
        if (root == null) {
            return root;
        }

        if (studentId < root.student.getStudentId()) {
            root.left = deleteRec(root.left, studentId);
        } else if (studentId > root.student.getStudentId()) {
            root.right = deleteRec(root.right, studentId);
        } else {
            if (root.left == null) {
                return root.right;
            } else if (root.right == null) {
                return root.left;
            }

            root.student = minValue(root.right);

            root.right = deleteRec(root.right, root.student.getStudentId());
        }
        return root;
    }

    private Student minValue(Node root) {
        Student minVal = root.student;
        while (root.left != null) {
            minVal = root.left.student;
            root = root.left;
        }
        return minVal;
    }
}

