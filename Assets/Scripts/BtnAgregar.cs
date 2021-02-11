using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAgregar : MonoBehaviour
{
    public GameObject panelPreguntar;
    public GameObject PanelPregunta;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnAdicionar(){
       panelPreguntar.SetActive(true);
       PanelPregunta.SetActive(false);
    }

    public void btnNo(){
        panelPreguntar.SetActive(false);
        PanelPregunta.SetActive(false);
    }

    public void abrirMenuIngresar(){
        panelPreguntar.SetActive(false);
        PanelPregunta.SetActive(true);
    }
}
