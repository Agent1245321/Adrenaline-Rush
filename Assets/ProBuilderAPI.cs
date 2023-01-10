using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.ProBuilder;

public class ProBuilderAPI : MonoBehaviour
{
    public Material windowMatt;
    private ProBuilderMesh building;
    public int[] tempQuad;

     public float xscale;
     public float yscale;
     public float zscale;

    private void Start()
    {

          /*ProBuilderMesh quad = ProBuilderMesh.Create(
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

  }); */
        building = GetComponent<ProBuilderMesh>();
        foreach (Face window in building.faces)
        {
            if (window.IsQuad() == true)
            {
                window.indexes.CopyTo(tempQuad, 3);
                Debug.Log(tempQuad[0]);
                Debug.Log(tempQuad[1]);
                Debug.Log(tempQuad[2]);
                Debug.Log(tempQuad[3]);

                new Face[] { new Face( new int[] {tempQuad})
                

                if (tempQuad[0] < tempQuad[2])
                {
                    building.TranslateVerticesInWorldSpace(tempQuad, new Vector3(1, 0, 0));
                }
            }
        }
        
        building.ToMesh();
        building.Refresh();
        
     //   building.Refresh();
        
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
