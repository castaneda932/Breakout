using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBloques : MonoBehaviour
{

    public GameObject MenuFinNivel;
    

    // Update is called once per frame
    void Update()
    { // si este objeto tiene hijos y si estos hijos llega a 0, cargamos al siguiente nivel
        if (transform.childCount == 0)
        { 
         MenuFinNivel.SetActive(true);
        }
    }
}
