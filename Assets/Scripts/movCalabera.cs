using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCalabera : MonoBehaviour
{
    // Start is called before the first frame update 
    public Vector3 rotInicial, posInicial;
    public bool rotacionVertical, movimientoVertical, rotacionQuijada;

    public float amplitud = 1;
    public float velocidad = 1;
    public float variacionz = 20;
    public float rotZ = 0;

    public Vector4 variacionPosicion;
    public float variacionx = 0;
    public float velocidadPos = 0;
    public float escalaPos = 1;
    public Vector3 posZY = Vector3.zero;

    public float variacionq = 0;
    void Start()
    {
        posInicial = transform.position;
        rotInicial = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update() { 
    
        if (rotacionVertical)
        {
            rotZ = amplitud * Mathf.Sin(variacionz);
            variacionz += velocidad * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotInicial.x, rotInicial.y, rotInicial.z + amplitud * Mathf.Sin(variacionz));

        }
        if (movimientoVertical)
        {
            variacionx += velocidadPos * Time.deltaTime;
            posZY += new Vector3(0, variacionPosicion.z * Mathf.Sin(variacionPosicion.w*variacionx), variacionPosicion.x*Mathf.Cos(variacionPosicion.y * variacionx));
            transform.position = posInicial + posZY*escalaPos;
        }
        if (rotacionQuijada)
        {
            variacionz += velocidad * Time.deltaTime;
            variacionq += velocidad * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotInicial.x - amplitud*0.5f * (Mathf.Cos(variacionq)+Mathf.Sin(0.36f*variacionq)), rotInicial.y, rotInicial.z + amplitud * Mathf.Sin(variacionz)); 
        }
    }
}
