using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public float LimiteX = 7.3f;
    [SerializeField] public float VelocidadPaddle = 15f;
    Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;

    


    // Start is called before the first frame update
    void Start()
    {
        
        
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    //mueve a la derecha
        //    transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    //mueve a la izquierda
        //    transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
        //}

        //al usar getaxis funciona con teclado, control o joystick
        transform.Translate(Input.GetAxis ("Horizontal") * Vector3.down * VelocidadPaddle * Time.deltaTime);

        Vector3 pos = transform.position;
        //pos.x = mousePos3D.x;
        if (pos.x < -LimiteX)
        {
            pos.x = -LimiteX;    
        }
        else if (pos.x > LimiteX)
        {
            pos.x = LimiteX;
        }
        transform.position = pos;
    }
}
