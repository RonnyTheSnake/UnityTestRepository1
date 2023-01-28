using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMesh : MonoBehaviour
{
    Mesh triangleMesh;
    MeshFilter meshFilter;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        triangleMesh = new Mesh();
        meshFilter.mesh = triangleMesh;
        DrawTriangle();
    }

    void DrawTriangle()
    {
        Vector3[] verticiesArray = new Vector3[3];
        int[] trianglesArray = new int[3];

        verticiesArray[0] = new Vector3(0, 1, 0);
        verticiesArray[1] = new Vector3(-1, 0, 0);
        verticiesArray[2] = new Vector3(1, 0, 0);

        trianglesArray[0] = 0;
        trianglesArray[1] = 1;
        trianglesArray[2] = 2;

        triangleMesh.vertices = verticiesArray;
        triangleMesh.triangles = trianglesArray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
