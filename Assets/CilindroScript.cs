using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroScript : MonoBehaviour
{
    public float tiempoEscalaInicial = 5f;
    public float tiempoEscalaCero = 10f;

    private Vector3 escalaInicial;

    private void Start()
    {
        escalaInicial = new Vector3(5.908186f, 5.908186f, 5.908186f);
        InvokeRepeating("CambiarEscala", 0f, tiempoEscalaInicial + tiempoEscalaCero);
    }

    private void CambiarEscala()
    {
        StartCoroutine(CambiarEscalaCoroutine());
    }

    private System.Collections.IEnumerator CambiarEscalaCoroutine()
    {
        transform.localScale = escalaInicial;
        yield return new WaitForSeconds(tiempoEscalaInicial);
        transform.localScale = Vector3.zero;
        yield return new WaitForSeconds(tiempoEscalaCero);
    }
}