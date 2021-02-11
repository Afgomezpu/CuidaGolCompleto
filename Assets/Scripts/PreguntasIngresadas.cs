using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntasIngresadas : MonoBehaviour
{ 

     private List<preguntas> preguntaAdicionales= new List<preguntas>();
    

      void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    { 
         preguntas pregunta1= new preguntas();
       pregunta1.pregunta="El mayor porcentaje de energía eléctrica que produce CHEC es:";
       string[] listarespuestas=new string[4]{"Geotérmica (Volcán) ", "Solar", "Hidroeléctrica", "Fredy Pulgarin "};
        pregunta1.respuestasSeleccion=listarespuestas;
       pregunta1.respuestaCorrecta=3;
       preguntaAdicionales.Add(pregunta1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AgregarPreguntasAdicionales(string pregunta,string[] respuestas,int correcta){

       preguntas pregunta1= new preguntas();
       pregunta1.pregunta=pregunta;
      // string[] listarespuestas=new string[4]{"Geotérmica (Volcán) ", "Solar", "Hidroeléctrica", "Fredy Pulgarin "};
       string[] listarespuestas=respuestas;
       pregunta1.respuestasSeleccion=listarespuestas;
       pregunta1.respuestaCorrecta=correcta;
       preguntaAdicionales.Add(pregunta1);
    }

       public List<preguntas> PreguntaAdicionales   // property
  {
    get { return preguntaAdicionales; }
    set { preguntaAdicionales = value; }
  }

}
