using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueExplosivo : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
