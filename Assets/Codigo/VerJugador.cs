using UnityEngine;

public class VerJugador : MonoBehaviour // Hereda de MonoBehaviour
{
    public Transform objetivo; // El objetivo a detectar
    public float rangoVision = 50f; // Distancia máxima de visión
    public float rangoFOV = 30f; // Ángulo de visión en grados
    private Vector3 jugadorDesdeIA;
    private float distanciaAJugador = 0f; 
    public float angulo = 0f; 
    // Start se llama al inicio
    void Start()
    {
    }

    // Update se llama cada frame
    void Update()
    {
        bool visto = false;
        // Calculamos la distancia al objetivo
        distanciaAJugador = Vector3.Distance(transform.position, objetivo.position);
        if (distanciaAJugador <= rangoVision)
        {
            jugadorDesdeIA = objetivo.position - transform.position; // Dirección hacia el jugador
            angulo = Vector3.Angle(transform.forward, jugadorDesdeIA); // Ángulo entre la vista y el jugador

            // Verificamos si el jugador está dentro del ángulo de visión
            if (angulo <= rangoFOV)
            {
                visto = true;
            }
        }

        if (visto)
        {
            // Aquí va la lógica si el jugador es visto
            Debug.Log("Jugador visto!");
        }
        else
        {
            Debug.Log("No veo jugador");
        }
    }
}
