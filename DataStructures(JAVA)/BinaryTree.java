import java.util.*;

public class BinaryTree {
    TreeNode root;

    public BinaryTree() {
        root = null;
    }

    public boolean insert(Listing newListing) {
        TreeNodeWrapper p = new TreeNodeWrapper();
        TreeNodeWrapper c = new TreeNodeWrapper();
        TreeNode n = new TreeNode();

        if (n == null) {
            return false; 
        } else {
            n.node = newListing.deepCopy(); 
            n.lc = null;
            n.rc = null;

            if (root == null) { 
                root = n;
            } else {
                findNode(newListing.getKey(), p, c); 

                if (newListing.getKey().compareTo(p.get().node.getKey()) < 0) {
                    p.get().lc = n; 
                } else {
                    p.get().rc = n; 
                }
            }
            return true;
        } 
    }

    public Listing fetch(String targetKey) {
        boolean found;
        TreeNodeWrapper p = new TreeNodeWrapper();
        TreeNodeWrapper c = new TreeNodeWrapper();

        found = findNode(targetKey, p, c); 

        if (found) {
            return c.get().node.deepCopy();
        } else {
            return null;
        }
    }

    public boolean delete(String targetKey) {
        boolean found;
        TreeNodeWrapper p = new TreeNodeWrapper();
        TreeNodeWrapper c = new TreeNodeWrapper();
        TreeNode largest;
        TreeNode nextLargest;

        found = findNode(targetKey, p, c);

        if (!found) {
            return false; 
        } else {
            if (c.get().lc == null && c.get().rc == null) { 
                if (p.get().lc == c.get()) {
                    p.get().lc = null;
                } else {
                    p.get().rc = null;
                }
            } else if (c.get().lc == null || c.get().rc == null) { 
                if (p.get().lc == c.get()) {
                    if (c.get().lc != null) {
                        p.get().lc = c.get().lc; 
                    } else {
                        p.get().lc = c.get().rc; 
                    }
                } else {
                    if (c.get().lc == null) {
                        p.get().rc = c.get().rc; 
                    } else {
                        p.get().rc = c.get().lc; 
                    }
                }
            } else {
                nextLargest = c.get();
                largest = nextLargest.rc;

                if (largest != null) { 
                    while (largest.rc != null) { 
                        nextLargest = largest;
                        largest = largest.rc;
                    }
                    c.get().node = largest.node; 
                    nextLargest.rc = largest.lc;
                } else { 
                    nextLargest.rc = c.get().rc; 

                    if (p.get().lc == c.get()) {
                        p.get().lc = nextLargest; 
                    } else {
                        p.get().rc = nextLargest; 
                    }
                }
            }
            return true;
        }
    }

    public boolean update(String targetKey, Listing newListing) {
        if (!delete(targetKey)) {
            return false; 
        }

        return insert(newListing); 
    }

    private boolean findNode(String targetKey, TreeNodeWrapper parent, TreeNodeWrapper child) {
        parent.set(root);
        child.set(root);

        if (root == null) 
            return false;

        while (child.get() != null) {
            if (child.get().node.getKey().compareTo(targetKey) == 0)
                return true;
            else {
                parent.set(child.get());
                if (targetKey.compareTo(child.get().node.getKey()) < 0)
                    child.set(child.get().lc);
                else
                    child.set(child.get().rc);
            }
        }
        return false;
    }

    public class TreeNode {
        private Listing node;
        private TreeNode lc;
        private TreeNode rc;

        public TreeNode() {
        }
    }

    public class TreeNodeWrapper {
        TreeNode treeRef = null;

        public TreeNodeWrapper() {
        }

        public TreeNode get() {
            return treeRef;
        } 

        public void set(TreeNode t) {
            treeRef = t;
        }
    }
}

public class MainBinaryTree {
    public static void main(String[] args) {
        BinaryTree t = new BinaryTree();
        Listing l1 = new Listing("Ann", "3rd Avenue", "333 3333");
        Listing l2 = new Listing("Bill", "4th Avenue", "444 4444");
        Listing l3 = new Listing("Carol", "5th Avenue", "555 5555");
        Listing l4 = new Listing("Mike", "6th Avenue", "666 6666");
        Listing l5 = new Listing("Pat", "1st Avenue", "111 1111");
        Listing l6 = new Listing("Sally", "2nd Avenue", "222 2222");
        Listing l7 = new Listing("Ted", "7th Avenue", "777 7777");
        Listing l8 = new Listing("Vick", "8th Avenue", "888 8888");
        Listing l9 = new Listing("Will", "9th Avenue", "999 9999");
        Listing l10 = new Listing("Zack", "11th Avenue", "101 0101");
        Listing l11 = new Listing("Zeek", "12th Avenue", "121 2121");

        t.insert(l9);
        t.insert(l7);
        t.insert(l10);
        t.insert(l3);
        t.insert(l8);
        t.insert(l1);
        t.insert(l4);
        t.insert(l2);
        t.insert(l6);
        t.insert(l5);

        System.out.println(t.fetch("Carol"));
        System.out.println(t.fetch("Sally"));
        System.out.println(t.fetch("Ted"));

        t.delete("Carol");
        System.out.println(t.fetch("Carol"));

        t.delete("Sally");
        System.out.println(t.fetch("Sally"));

        t.delete("Ted");
        System.out.println(t.fetch("Ted"));

        t.update("Bill", l2);
        System.out.println(t.fetch("Carol"));
        System.out.println(t.fetch("Bill"));
    }
}
