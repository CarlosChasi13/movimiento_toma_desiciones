using UnityEngine;

public class PerseguirV1 : MonoBehaviour
{
    public float velocidad = 5f;
    public Transform objetivo;

    private float x = 0f;
    private float y = 0f;
    private float z = 0f;

    void Start()
    {
        y = transform.position.y;
    }

    void Update()
    {
        x = transform.position.x;
        z = transform.position.z;

        if (objetivo.position.x > x)
        {
            x += velocidad * Time.deltaTime;
        }
        if (objetivo.position.x < x)
        {
            x -= velocidad * Time.deltaTime;
        }
        if (objetivo.position.z > z)
        {
            z += velocidad * Time.deltaTime;
        }
        if (objetivo.position.z < z)
        {
            z -= velocidad * Time.deltaTime;
        }

        transform.position = new Vector3(x, y, z);
    }
}