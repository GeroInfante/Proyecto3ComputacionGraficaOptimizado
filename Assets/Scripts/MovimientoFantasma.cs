using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoSilla : MonoBehaviour
{
    // Amplitud del movimiento
    public float amplitude = 0.5f;
    // Frecuencia del movimiento
    public float frequency = 1f;

    public float offset = 0.0f;
    // Posición inicial del objeto
    public Vector3 startPosition;

    private float t = 0;
    void Start()
    {
    }

    void Update()
    {
        startPosition = transform.position;
        t += 0.1f;
        // Calcular el nuevo desplazamiento en el eje Y usando PingPong
        float newY = startPosition.y + Mathf.Sin(t * frequency + offset) * amplitude;
        // Aplicar la nueva posición
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
