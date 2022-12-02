using UnityEngine;

public class Moveforward : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
