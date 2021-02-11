using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class IngresarPregunta : MonoBehaviour
{
    public GameObject Panel;
    public GameObject pregunta;
    public GameObject opcion1;
    public GameObject opcion2;
    public GameObject opcion3;
    public GameObject correcta;
    private string tipoPreguntas;
    PreguntasIngresadas preguntas;
    
      void Start()
    {
        preguntas = GameObject.Find("PreguntasIngresadas").GetComponent<PreguntasIngresadas>();
    }
    

    public void Tipo(string tipo){

        TipoPreguntas=tipo;
    }

       public string TipoPreguntas   // property
  {
    get { return tipoPreguntas; }
    set { tipoPreguntas = value; }
  }
   
   public void GuardaPregunta(){
      string[] respuestas;
      // print(TipoPreguntas);
      // if(TipoPreguntas.Equals("Seleccion multiple")){
      preguntas.AgregarPreguntasAdicionales(pregunta.GetComponent<TMP_InputField>().text, 
      respuestas=new string[3]{opcion1.GetComponent<TMP_InputField>().text,opcion2.GetComponent<TMP_InputField>().text,
      opcion3.GetComponent<TMP_InputField>().text}, int.Parse(correcta.GetComponent<TMP_InputField>().text));
      print((pregunta.GetComponent<TMP_InputField>().text));
      print((int.Parse(correcta.GetComponent<TMP_InputField>().text)));
      Panel.SetActive(false);
      pregunta.GetComponent<TMP_InputField>().text="";
      opcion1.GetComponent<TMP_InputField>().text="";
      opcion2.GetComponent<TMP_InputField>().text="";
      opcion3.GetComponent<TMP_InputField>().text="";
      correcta.GetComponent<TMP_InputField>().text="";
      
    //  }
    //   else if(TipoPreguntas.Equals("Falso y Verdadero")){
    //   preguntas.AgregarPreguntasAdicionales(pregunta.GetComponent<TMP_InputField>().text, 
    //   respuestas=new string[2]{opcion1.GetComponent<TMP_InputField>().text,opcion2.GetComponent<TMP_InputField>().text}, 
    //   int.Parse(correcta.GetComponent<TMP_InputField>().text));
    //   }

   }

 
}
