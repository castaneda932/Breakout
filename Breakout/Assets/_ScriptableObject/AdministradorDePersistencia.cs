using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDePersistencia : MonoBehaviour
{
    public List<PuntajePersistente> ObjetoAGuardar;
    // Start is called before the first frame update
    public void OnEnable()
    {
        for (int i = 0; i < ObjetoAGuardar.Count; i++)
        {
            var so = ObjetoAGuardar[i];
            so.Cargar();
        }
    }
    public void OnDisable()
    {
        for (int i = 0; i < ObjetoAGuardar.Count; i++)
        {
            var so = ObjetoAGuardar[i];
            so.Guardar();
        }
    }
        
    
}
