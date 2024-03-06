using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaScript : MonoBehaviour
{
    public float tiempoEscalaInicial = 2.5f;
    public float tiempoEscalaIntermedia = 2.5f;
    public float tiempoEscalaCero = 2.5f;

    private Vector3 escalaInicial;
    private Vector3 escalaIntermedia;
    private bool aEscalaIntermedia = false;

    private void Start()
    {
        escalaInicial = Vector3.zero;
        escalaIntermedia = new Vector3(7.979696f, 7.979696f, 7.979696f);
        InvokeRepeating("CambiarEscala", tiempoEscalaInicial, tiempoEscalaInicial + tiempoEscalaIntermedia + tiempoEscalaCero);
    }

    private void CambiarEscala()
    {
        if (transform.localScale == escalaInicial)
        {
            transform.localScale = escalaIntermedia;
            Invoke("VolverEscalaInicial", tiempoEscalaIntermedia);
        }
        else if (transform.localScale == escalaIntermedia)
        {
            transform.localScale = Vector3.zero;
            Invoke("VolverEscalaIntermedia", tiempoEscalaCero);
        }
    }

    private void VolverEscalaInicial()
    {
        transform.localScale = escalaInicial;
    }

    private void VolverEscalaIntermedia()
    {
        transform.localScale = escalaIntermedia;
    }
}