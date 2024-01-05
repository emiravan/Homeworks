package EXC1;

import java.util.ArrayList;

class Node {
    String id;
    String info;

    Node(String id, String info) {
        this.id = id;
        this.info = info;
    }
}

public class GraphMatrix {
    private Node[] vertices;
    private boolean[][] edges;
    private int vertexCount;

    public GraphMatrix(int size) {
        vertices = new Node[size];
        edges = new boolean[size][size];
        vertexCount = 0;
    }

    public void insertNode(String id, String info) {
        vertices[vertexCount++] = new Node(id, info);
    }

    public void insertEdge(int from, int to) {
        edges[from][to] = true;
        edges[to][from] = true;
    }

}

