using UnityEngine;

public class OutOfBoundires : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;

    private float lowerBound = -20;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }
}
