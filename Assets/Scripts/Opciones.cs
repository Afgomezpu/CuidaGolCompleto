using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opciones : MonoBehaviour
{
    private string nombrebloque;
    private string dificultad;
    private string tipoPreguntas;

      void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {   
      

    }

    public void Bloque(string bloque){

        NombreBloque=bloque;
    }

     public void Gradodificultad(string grado){

        Dificultad=grado;
    }

    public void Tipo(string tipo){

        TipoPreguntas=tipo;
    }

      public string NombreBloque   // property
  {
    get { return nombrebloque; }
    set { nombrebloque = value; }
  }

     public string Dificultad   // property
  {
    get { return dificultad; }
    set { dificultad = value; }
  }

  

   public string TipoPreguntas   // property
  {
    get { return tipoPreguntas; }
    set { tipoPreguntas = value; }
  }
    void Update()
    {
    
    }
}
