using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminisatradorVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject MenuFinJuego;
    // Start is called before the first frame update
    void Start()
    {// guardamos todos los transforms de hijos. en admin de vidas tenemos 3 hijos
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach (Transform hijo in hijos) 
        {
            vidas.Add(hijo.gameObject);
         
        }
        vidas.RemoveAt(0);
    }

    

    public void EliminarVidas()
    {//seleccionamos obejto a eliminar Vidas. y si llegamos a 0 vidas cargarmos menu fin juego
        var objetoAEliminar = vidas[vidas.Count - 1];
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if(vidas.Count <= 0 )
        {
            MenuFinJuego.SetActive(true);
            return;
        }
        //en caso de que no suceda esto, vamos a instanciar este objeto y se restara una vida
        var bola = Instantiate(bolaPrefab) as GameObject;
        bolaScript = bola.GetComponent<Bola>();
        bolaScript.BolaDestruida.AddListener(this.EliminarVidas);
        Debug.Log($"Vidas restantes: {vidas.Count}");
    }
}
