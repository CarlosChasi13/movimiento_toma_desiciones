using UnityEngine;

public class LineaVisionHuir : MonoBehaviour
{
    public float velocidad = 5;
    public Transform objetivo;

    // Start se llama antes de la primera actualización del frame
    void Start()
    {
    }

    // Update se llama una vez por frame
    void Update()
    {
        Vector3 punto = objetivo.position - transform.position;
        Vector3 vision = transform.position - punto;
        
        transform.LookAt(vision);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
