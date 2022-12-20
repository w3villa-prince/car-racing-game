using UnityEngine;

public class detectcollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

    /* public float AreaOfTrapezium(float a, float b, float c, float d)
     {
         float h = c - a;
         float area = (b + d) * h / 2;
         return area;
     }

     public float AreaOfArray(float[,] array2d)
     {
         float areaofArray = 0;
         int row = array2d.Length;
         for (int i = 0; i < row - 1; i++)
         {
             Debug.Log(i);
             areaofArray += AreaOfTrapezium(array2d[i, 0], array2d[i, 1], array2d[i + 1, 0], array2d[i + 1, 1]);
         }
         return areaofArray;
     }*/
}
