using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;
    public Opciones opcionesDelJuego;

    public void Awake()
    {
        if( opcionesDelJuego.nivelDificultad == Opciones.dificultad.facil)
        {
            resistencia = resistencia + 1;
        }
        if (opcionesDelJuego.nivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = resistencia + 2;
        }
        if (opcionesDelJuego.nivelDificultad == Opciones.dificultad.dificil)
        {
            resistencia = resistencia * 2;
        }
    }
    //sirve para disparar cada que un objeto choque con el collider de este bloque
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }


    //operacion para sacar el vector de la bola
    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().opciones.velocidadBola * direccion;
        resistencia--;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }

    }
    public virtual void RebotarBola()
    {

    }
}
