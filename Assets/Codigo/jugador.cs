using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    // Velocidades de rotación y movimiento
    public float velAngular = 100f;
    public float velocidad = 5f;
    void Start()
    {

    }
    void Update()
    {
        // Rotación hacia la izquierda (tecla A)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -velAngular * Time.deltaTime, 0));
        }

        // Rotación hacia la derecha (tecla D)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, velAngular * Time.deltaTime, 0));
        }

        // Movimiento hacia adelante (tecla W)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
        }

        // Movimiento hacia atrás (tecla S)
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -velocidad * Time.deltaTime));
        }
    }
}