using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquePiedra : Bloque  
{
    
    // Start is called before the first frame update
    void Start()
    {
        

        resistencia = 5;
        CambioDeResistenciaConDificultad();
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }

}
