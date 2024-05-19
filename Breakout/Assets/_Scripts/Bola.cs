using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false;
    [SerializeField] public float velocidadBola = 10f;
    // Start is called before the first frame update
    void Start()
    { // se busca el tag de Jugador y se suma unas unidades en eje Y, se asigna setparent para saber la herencia entre objetos
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 1;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);

        
    }

    // Update is called once per frame
    void Update()
    {
        //si preciono tecla espacio y en caso de que el juego empiece la bola ya no es hijo del paddle y con el rigidbody de nuestra bola se inicie hacia arriba
        //el submit sale del boton A en control
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButton("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }
        
    }
}
