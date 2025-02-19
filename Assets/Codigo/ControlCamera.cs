using UnityEngine;
public class ControlCamara : MonoBehaviour
{
    public Transform objetivo;
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(objetivo);
    }
}