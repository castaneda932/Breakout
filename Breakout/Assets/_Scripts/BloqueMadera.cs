using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueMadera : Bloque
{
    public void CambioDeResistenciaConDificultad()
    {
        if (opcionesDelJuego.nivelDificultad == Opciones.dificultad.facil)
        {
            this.resistencia = this.resistencia + 1;
        }
        else if (opcionesDelJuego.nivelDificultad == Opciones.dificultad.normal)
        {
            this.resistencia = this.resistencia + 2;
        }
        else if (opcionesDelJuego.nivelDificultad == Opciones.dificultad.dificil)
        {
            this.resistencia = this.resistencia * 2;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        resistencia = 3;
    }
    public override void RebotarBola()
    {
        base.RebotarBola();
    }

}
