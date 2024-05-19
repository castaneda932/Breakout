using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;
    
    

    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();

        if (PlayerPrefs.HasKey("PuntajeAlto"))
        {
            //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO}";
        }
    }

    private void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50;
    }
    // Update is called once per frame
    void Update()
    {
        // si el puntaje actual es mayor la puntaje alto se modificara
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntajeAlto}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            //PlayerPrefs.SetInt("PuntajeAlto", puntos);
        }
    }
}
