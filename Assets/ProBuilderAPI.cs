using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class ProBuilderAPI : MonoBehaviour
{
    public Material windowMatt;
    private ProBuilderMesh building;
    public IReadOnlyCollection<int> indexes { get; }

    // public float xscale;
    // public float yscale;
    // public float zscale;

    private void Start()
    {

        /*  ProBuilderMesh quad = ProBuilderMesh.Create(
      new Vector3[] {
          new Vector3(xscale * 0f, zscale * 0f, zscale * 0f),
          new Vector3(xscale * 1f, yscale * 0f, zscale * 0f),
          new Vector3(xscale * 0f, yscale * 1f, zscale * 0f),
          new Vector3(xscale * 1f, yscale * 1f, zscale * 0f),
          new Vector3(xscale * 0f, yscale * 0f, zscale * 1f),
          new Vector3(xscale * 1f, yscale * 0f, zscale * 1f),
          new Vector3(xscale * 0f, yscale * 1f,zscale *  1f),
          new Vector3(xscale * 1f, yscale * 1f, zscale * 1f),
      },
      new Face[] { new Face(new int[] { 1, 0, 3, 0, 2, 3 }), new Face(new int[] {0, 4, 2, 4, 6, 2 } ), new Face(new int[] {4, 5, 6, 5, 7, 6 } ), new Face(new int[] {5, 1, 7, 1, 3, 7 } ), new Face(new int[] {3, 2, 7, 2, 6, 7 } ), new Face(new int[] {0, 1, 4, 1, 5, 4 } )

  });*/
        building = GetComponent<ProBuilderMesh>();
        foreach (Face window in building.faces)
        {
            
            Debug.Log(building.GetVertices());
            
            
        }
        
     //   building.Refresh();
        
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
