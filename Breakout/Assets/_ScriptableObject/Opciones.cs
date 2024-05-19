using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : PuntajePersistente
{
    public float velocidadBola = 30;
    public dificultad nivelDificultad = dificultad.facil;
    public void Awake()
    {
        Guardar();
        Cargar();
    }
    public enum dificultad
    {
        facil, //=0
        normal, //=1
        dificil //=2
    }

    public void cambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }

    public void cambiarDificultad(float nuevaDificultad)
    {
        nivelDificultad = (dificultad)nuevaDificultad;
    }

}