using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueRelentizador : Bloque
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        resistencia = 1;
        CambioDeResistenciaConDificultad();
    }

    
    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
