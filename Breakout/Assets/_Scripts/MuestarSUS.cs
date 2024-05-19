using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestarSUS : MonoBehaviour
{
    MuestraEventos subscriptor;
    // Start is called before the first frame update
    void Start()
    {
        subscriptor = GetComponent<MuestraEventos>();
        subscriptor.OnSpacePressed += MensajeEscuchadoPorElSuscriptot;
    }

    private void MensajeEscuchadoPorElSuscriptot(object sender, EventArgs e)
    {
        Debug.Log("el evento ha sido esuchado desde otra clase");
        subscriptor.OnSpacePressed -= MensajeEscuchadoPorElSuscriptot;
    }
}
