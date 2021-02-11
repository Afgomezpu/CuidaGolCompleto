using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptByd : MonoBehaviour
{
      Opciones bloqueydificultad;
      public GameObject btnAdicionar;
      public GameObject inputoption;

    void Start()
    {
        bloqueydificultad = GameObject.Find("BloqueyDificultad").GetComponent<Opciones>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void enviarBloque(string bloque){
        bloqueydificultad.Bloque(bloque);
        print(bloque);
    }

      public void enviarDificultad(string grado){
        bloqueydificultad.Gradodificultad(grado);
        print(grado);
        if(bloqueydificultad.TipoPreguntas.Equals("Seleccion multiple")){
          btnAdicionar.SetActive(true);
          inputoption.SetActive(true);
        }
          else if(bloqueydificultad.TipoPreguntas.Equals("Falso y Verdadero")){
          btnAdicionar.SetActive(true);
          inputoption.SetActive(false);
        }
    }

    
    
}
