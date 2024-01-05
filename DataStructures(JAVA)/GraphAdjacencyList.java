package EXC1;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

class Node {
    String id;
    String info;
    List<Node> neighbors;

    Node(String id, String info) {
        this.id = id;
        this.info = info;
        neighbors = new ArrayList<>();
    }
}

public class GraphAdjacencyList {
    private Map<String, Node> vertices;

    public GraphAdjacencyList() {
        vertices = new HashMap<>();
    }

    public void insertNode(String id, String info) {
        vertices.put(id, new Node(id, info));
    }

    public void insertEdge(String from, String to) {
        Node fromNode = vertices.get(from);
        Node toNode = vertices.get(to);

        if (fromNode != null && toNode != null) {
            fromNode.neighbors.add(toNode);
            toNode.neighbors.add(fromNode);
        }
    }

}

