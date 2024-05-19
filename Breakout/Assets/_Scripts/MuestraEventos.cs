using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler OnSpacePressed; //encasodeespacioprecionado
    // Start is called before the first frame update
    void Start()
    {
        OnSpacePressed += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
            
        }
    }

    public void EventoEscuchado (object sender, EventArgs e)
    {
        Debug.Log("el evento se esucho correctamente");

    }

    public void EventoUnityDisparado()
    {
        Debug.Log("el evento unity se disparo correctamente");
    }
}
