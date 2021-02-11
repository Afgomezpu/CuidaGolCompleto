using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Administradortest : MonoBehaviour
{
    private bool siguienteCobro;
    private int puntuacionVeintiuna;
    private bool respuesta;
    public GameObject botonSeguir;
    bool penalbool;
    private bool veintiunabool;
    Puntuacion1 puntuacion;
    Opciones Bloques;
    PreguntasIngresadas preguntasIngresadas;
    AdministradorJugadores NumeroJugadores;
    ListaPreguntas listaTotalPreguntas;
    List<preguntas> adm;
    ListaPreguntas listaPreguntas1; 
    int Preguntactual;
    public GameObject kinect;
    public GameObject Ballpenalty;
    public GameObject BallVeintiuna;
    public TextMeshProUGUI preguntaTxt;
    public GameObject ContenedorVeintiuna;
    public GameObject textJugador;
    public GameObject panel;
    public GameObject[] options;
    public GameObject[] options2;
    public GameObject back;
    public GameObject front;
    public GameObject[] ListadeJugadoresFrente;
    public GameObject[] ListadeJugadoresEspalda;
    public GameObject PreguntaMedia;
    public GameObject obstaculoGota1;
    public GameObject obstaculoGota2;
    public GameObject obstaculoGota3;
    public GameObject obstaculoRayo1;
    public GameObject obstaculoRayo2;
    public GameObject obstaculoRayo3;
    public GameObject obstaculoArbol1;
    public GameObject obstaculoArbol2;
    public GameObject obstaculoArbol3;
    List<string> NombreJugadores;
    int numeroPreguntas;
    private bool siguientePregunta;
    bool balon;
    bool terreno;
    bool player1;
    bool player2;
    bool player3;
    int contador;
    private int contadorSecuencia ;
    GameObject kinectPenal;
    GameObject kinectVeintiuna;
    int numeroiteraciones;
    private Vector3 positionInicial;
    Vector3 positionAvatar;
    private Vector3 positionFinal;
    // int SecuenciaJuego;
       private void Start()
    {   
        ContadorSecuencia =0;
        // this.SecuenciaJuego=0;
        SiguienteCobro=false;
        penalbool=true ;
        veintiunabool=false;
        numeroiteraciones=0;
        positionAvatar.x=PositionInicial.x-1.5f;
        positionAvatar.y=PositionInicial.y;
        positionAvatar.z=PositionInicial.z;
        // positionFinal=ListadeJugadores[0].transform.position;
        player1=true;
        player2=false;
        player3=false;
        balon=false;
        terreno=false;
        siguientePregunta=false;
        contador=1;
        Bloques=FindObjectOfType<Opciones>();
        puntuacion=FindObjectOfType<Puntuacion1>();
        preguntasIngresadas=FindObjectOfType<PreguntasIngresadas>();
        listaTotalPreguntas=FindObjectOfType<ListaPreguntas>();
        // print(Bloques.NombreBloque);
        // print(Bloques.Dificultad);
        // print(Bloques.TipoPreguntas);
            if( Bloques.TipoPreguntas.Equals("Falso y Verdadero")){
                    PreguntaMedia.SetActive(false);
            }
        NumeroJugadores=FindObjectOfType<AdministradorJugadores>();
        // print(NumeroJugadores.Jugadores);
        NombreJugadores=NumeroJugadores.ListaJugadores;
        // foreach(GameObject jugador in ListadeJugadores){
        //     if(jugador.name==NombreJugadores[0]){
        //         jugador.transform.position=positionAvatar;
        //     //    jugador.SetActive(true);
        //     //    kinect.SetActive(true);

        //     }
        // }

        listaPreguntas1= new ListaPreguntas();
        if(Bloques.Dificultad.Equals("facil")){
          foreach(preguntas preguntica  in preguntasIngresadas.PreguntaAdicionales){
            listaTotalPreguntas.AgregarPreguntasFaciles(Bloques.NombreBloque,preguntica);
        }
        adm=listaTotalPreguntas.PreguntasFacilesbloque1;
        }
        // else if(Bloques.Dificultad.Equals("medio")){
        // adm= new List<preguntas>(listaPreguntas1.AgregarPreguntasFaciles(Bloques.NombreBloque));
        // }
        // else if(Bloques.Dificultad.Equals("dificil")){
        // adm= new List<preguntas>(listaPreguntas1.AgregarPreguntasFaciles(Bloques.NombreBloque));
        // }
        numeroPreguntas=5;
        Secuencia();
    }

 void Update(){
     if(SiguientePregunta){
            if(SiguienteCobro){
                if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                    if(player1){
                        if(ContadorSecuencia ==1){
                            puntuacion.PuntuacionJugador1+=3;
                        }
                        else if(ContadorSecuencia ==3){
                            puntuacion.PuntuacionJugador1+=5;
                        }
                        else if(ContadorSecuencia ==5){
                            puntuacion.PuntuacionJugador1+=10;
                        }
                    }
                    else if(player2){
                           if(ContadorSecuencia ==1){
                            puntuacion.PuntuacionJugador2+=3;
                        }
                        else if(ContadorSecuencia ==3){
                            puntuacion.PuntuacionJugador2+=5;
                        }
                        else if(ContadorSecuencia ==5){
                            puntuacion.PuntuacionJugador2+=10;
                        }

                    }
                    else if (player3){
                           if(ContadorSecuencia ==1){
                            puntuacion.PuntuacionJugador3+=3;
                        }
                        else if(ContadorSecuencia ==3){
                            puntuacion.PuntuacionJugador3+=5;
                        }
                        else if(ContadorSecuencia ==5){
                            puntuacion.PuntuacionJugador3+=10;
                        }

                    }
            }

            else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                    if(player1){
                        if(ContadorSecuencia ==2){
                            puntuacion.PuntuacionJugador1+=PuntuacionVeintiuna;
                        }
                        else if(ContadorSecuencia ==4){
                            puntuacion.PuntuacionJugador1+=PuntuacionVeintiuna;
                        }
                    
                    }
                    else if(player2){
                           if(ContadorSecuencia ==2){
                            puntuacion.PuntuacionJugador2+=PuntuacionVeintiuna;
                        }
                        else if(ContadorSecuencia ==4){
                            puntuacion.PuntuacionJugador2+=PuntuacionVeintiuna;
                        }

                    }
                    else if (player3){
                           if(ContadorSecuencia ==2){
                            puntuacion.PuntuacionJugador3+=PuntuacionVeintiuna;
                        }
                        else if(ContadorSecuencia ==4){
                            puntuacion.PuntuacionJugador3+=PuntuacionVeintiuna;
                        }

                    }
            }
            SiguienteCobro=false;
            }

            Secuencia();
            SiguientePregunta=false;
     }

//      if (Veintiunabool){
//                      veintiUno();
//                      veintiunabool=false;
//     if(SiguienteCobro){
//         panel.SetActive(false);
//                      botonSeguir.SetActive(true);
// }

//                  }
 }
  void SetPreguntas(){
  if(Bloques.TipoPreguntas.Equals("Seleccion multiple")){
      for (int i=0; i<options.Length;i++){
          options[i].GetComponent<respuestas>().correcta=false;
          options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=adm[Preguntactual].respuestasSeleccion[i];
            if(adm[Preguntactual].respuestaCorrecta==i+1)
          {
              options[i].GetComponent<respuestas>().correcta=true;
          }
        
    }
    }
    else if( Bloques.TipoPreguntas.Equals("Falso y Verdadero")){
           for (int i=0; i<options2.Length;i++){
          options2[i].GetComponent<respuestas>().correcta=false;
          options2[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=adm[Preguntactual].respuestaFalsoVerdadero[i];
            if(adm[Preguntactual].respuestaCorrecta==i+1)
          {
              options2[i].GetComponent<respuestas>().correcta=true;
          }
        
    }
    }
 }
          void generarPregunta()
      {    
           Preguntactual= Random.Range(0, adm.Count);
           preguntaTxt.text =adm[Preguntactual].pregunta;
           SetPreguntas();      
        }  

        public void EliminarPregunta(){
            numeroiteraciones=numeroiteraciones+1;
            adm.RemoveAt(Preguntactual);
            //yield return new WaitForSeconds(8);
            // print("entro a eliminar la pregunta");
            // if(contador==1||contador==2){
            //     if(Respuesta){
            //         puntuacion.PuntuacionJugador1+=5;
            //     }
            // }
            //   if(contador==3){
            //     if(Respuesta){
            //         puntuacion.PuntuacionJugador1+=10;
            //     }
            //     }
            //   if(contador==4){
            //     if(Respuesta){
            //         puntuacion.PuntuacionJugador1+=15;
            //     }
            // }
            //   if(contador==5){
            //     if(Respuesta){
            //         puntuacion.PuntuacionJugador1+=20;
            //     }
            // }


            if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                if(Respuesta){
                    penal();
                    if(player1){
                        if(ContadorSecuencia ==1){
                            puntuacion.PuntuacionJugador1+=5;
                        }
                        else if(ContadorSecuencia ==3){
                            puntuacion.PuntuacionJugador1+=10;
                        }
                        else if(ContadorSecuencia ==5){
                            puntuacion.PuntuacionJugador1+=20;
                        }
                    }
                    else if(player2){
                           if(ContadorSecuencia ==1){
                            puntuacion.PuntuacionJugador2+=5;
                        }
                        else if(ContadorSecuencia ==3){
                            puntuacion.PuntuacionJugador2+=10;
                        }
                        else if(ContadorSecuencia ==5){
                            puntuacion.PuntuacionJugador2+=20;
                        }

                    }
                    else if (player3){
                           if(ContadorSecuencia ==1){
                            puntuacion.PuntuacionJugador3+=5;
                        }
                        else if(ContadorSecuencia ==3){
                            puntuacion.PuntuacionJugador3+=10;
                        }
                        else if(ContadorSecuencia ==5){
                            puntuacion.PuntuacionJugador3+=20;
                        }

                    }
                }
                else{
                    penalBarrera();
                }
            }

            else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                  if(Respuesta){
                    veintiUno();
                    if(player1){
                        if(ContadorSecuencia ==2){
                            puntuacion.PuntuacionJugador1+=5;
                        }
                        else if(ContadorSecuencia ==4){
                            puntuacion.PuntuacionJugador1+=15;
                        }
                    
                    }
                    else if(player2){
                           if(ContadorSecuencia ==2){
                            puntuacion.PuntuacionJugador2+=5;
                        }
                        else if(ContadorSecuencia ==4){
                            puntuacion.PuntuacionJugador2+=15;
                        }

                    }
                    else if (player3){
                           if(ContadorSecuencia ==2){
                            puntuacion.PuntuacionJugador3+=5;
                        }
                        else if(ContadorSecuencia ==4){
                            puntuacion.PuntuacionJugador3+=15;
                        }

                    }
                }
                else{
                    veintiUnoRapido();
                }

            }


            // print(Respuesta);
            // if(contador==1||contador==3||contador==5){
                //  if(this.SecuenciaJuego==1){
                //     penal();
                //     penalbool=false;
                //     print("entro a el penal");
            
                //  }
                //  if(this.SecuenciaJuego==2){
                //      veintiUno();
                //      print("entro a la veintiuna");
                //  }
                  
            //      }
            //     else{
            //         penalBarrera();
            //     }
            // }
            // else if(contador==2||contador==4){
            //     if(Respuesta){
            //         veintiUno();
            //         print("entro veintiuna"+ contador);
            //     }
            //     else{
            //         veintiUnoRapido();
            //     }
                
            // }
            // if(numeroiteraciones==NumeroJugadores.ListaJugadores.Count){
            //     contador=contador+1;
            //      print("entro enumero de iteracion"+ contador);
            //     numeroiteraciones=0;
            // }

        }

        void Secuencia(){
            if(player1){
                ContadorSecuencia =ContadorSecuencia +1;
                textJugador.GetComponent<TextMeshProUGUI>().text = "Jugador: " + NombreJugadores[0];
                pregunta();
                
                if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                    Desactivar("ListadeJugadoresFrente");
                    print("entro a el penal");
                    for(int i=0; i<ListadeJugadoresEspalda.Length;i++){
                      if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       ListadeJugadoresEspalda[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresEspalda[i].SetActive(false);
                }

                }
                else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                    print("entro a la veintiuna");
                    Desactivar("ListadeJugadoresEspalda");
                    for(int i=0; i<ListadeJugadoresFrente.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       ListadeJugadoresFrente[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresFrente[i].SetActive(false);
                }

                }
                // foreach(GameObject jugador in ListadeJugadores){
                //     jugador.transform.position=positionFinal;
                // // kinect.SetActive(false);
                // // jugador.SetActive(false);
                // if(jugador.name==NombreJugadores[1]){
                //     jugador.transform.position=positionAvatar;
                // // jugador.SetActive(true);
                // // kinect.SetActive(true);
                // }
            // }
                player1=false;
                player2=true;
                player3=false;
            }
            else if(player2 && NumeroJugadores.ListaJugadores.Count==2){
                textJugador.GetComponent<TextMeshProUGUI>().text = "Jugador: " + NombreJugadores[1];
                pregunta();
             

                if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                    print("entro a el penal");
                     Desactivar("ListadeJugadoresFrente");
                      for(int i=0; i<ListadeJugadoresEspalda.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       ListadeJugadoresEspalda[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresEspalda[i].SetActive(false);
                }
                }
                else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                   print("entro a la veintiuna");
                   Desactivar("ListadeJugadoresEspalda");
                     for(int i=0; i<ListadeJugadoresFrente.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       ListadeJugadoresFrente[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresFrente[i].SetActive(false);
                }
                }
        //         foreach(GameObject jugador in ListadeJugadores){
        //             jugador.transform.position=positionFinal;
        //         //     kinect.SetActive(false);
        //         // jugador.SetActive(false);
        //        if(jugador.name==NombreJugadores[0]){
        //            jugador.transform.position=positionAvatar;
        //     //    jugador.SetActive(true);
        //     //    kinect.SetActive(true);
        //     }
        // }
                player1=true;
                player2=false;
                player3=false;
            }
             else if(player2 && NumeroJugadores.ListaJugadores.Count==3){
                textJugador.GetComponent<TextMeshProUGUI>().text =  "Jugador: " + NombreJugadores[1];
                pregunta();
              

                  if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                    print("entro a el penal");
                    Desactivar("ListadeJugadoresFrente");
                      for(int i=0; i<ListadeJugadoresEspalda.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       ListadeJugadoresEspalda[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresEspalda[i].SetActive(false);
                }
                }
                else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                    print("entro a la veintiuna");
                    Desactivar("ListadeJugadoresEspalda");
                      for(int i=0; i<ListadeJugadoresFrente.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       ListadeJugadoresFrente[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresFrente[i].SetActive(false);
                }
                }
            //      foreach(GameObject jugador in ListadeJugadores){
            //          jugador.transform.position=positionFinal;
            //         //  kinect.SetActive(false);
            //         // jugador.SetActive(false);
            //     if(jugador.name==NombreJugadores[2]){
            //         jugador.transform.position=positionAvatar;
            // //    jugador.SetActive(true);
            // //    kinect.SetActive(true);
            //     }
            // }
    
                player1=false;
                player2=false;
                player3=true;
            }
            else if(player3 && NumeroJugadores.ListaJugadores.Count==3){
                textJugador.GetComponent<TextMeshProUGUI>().text =  "Jugador: " + NombreJugadores[2];
                pregunta();
              

                  if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                    
                    print("entro a el penal");
                    Desactivar("ListadeJugadoresFrente");
                      for(int i=0; i<ListadeJugadoresEspalda.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       ListadeJugadoresEspalda[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresEspalda[i].SetActive(false);
                }
                }
                else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                    print("entro a la veintiuna");
                    Desactivar("ListadeJugadoresEspalda");
                      for(int i=0; i<ListadeJugadoresFrente.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       ListadeJugadoresFrente[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresFrente[i].SetActive(false);
                }
                }
        //          foreach(GameObject jugador in ListadeJugadores){
        //              jugador.transform.position=positionFinal;
        //         //      kinect.SetActive(false);
        //         // jugador.SetActive(false);
        //         if(jugador.name==NombreJugadores[2]){
        //             jugador.transform.position=positionAvatar;
        //     //    jugador.SetActive(true);
        //     //    kinect.SetActive(true);
        //     }
        //  }
                player1=true;
                player2=false;
                player3=false;
            }
            else{
                //  foreach(GameObject jugador in ListadeJugadores){
                //      jugador.transform.position=positionFinal;
                // // jugador.SetActive(false);
                // // kinect.SetActive(false);
                // if(jugador.name==NombreJugadores[0]){
                //     jugador.transform.position=positionAvatar;
                // // jugador.SetActive(true);
                // // kinect.SetActive(true);
                // }
                // }
   
                player1=true;
                pregunta();
                ContadorSecuencia =ContadorSecuencia +1;
             

                  if(ContadorSecuencia ==1||ContadorSecuencia ==3||ContadorSecuencia ==5){
                    print("entro a el penal");
                    Desactivar("ListadeJugadoresFrente");
                     for(int i=0; i<ListadeJugadoresEspalda.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       ListadeJugadoresEspalda[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresEspalda[i].SetActive(false);
                }
                }
                else if(ContadorSecuencia ==2||ContadorSecuencia ==4){
                    print("entro a la veintiuna");
                    Desactivar("ListadeJugadoresEspalda");
                     for(int i=0; i<ListadeJugadoresFrente.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       ListadeJugadoresFrente[i].SetActive(true);
                   }
                    else
                     ListadeJugadoresFrente[i].SetActive(false);
                }
                }
            }
        }




      public Vector3  PositionInicial  // property
     {
    get { return positionInicial; }
    set { positionInicial = value; }
    }

      public Vector3  PositionAvatar  // property
     {
    get { return positionAvatar; }
    set { positionAvatar = value; }
    }

      public Vector3  PositionFinal  // property
     {
    get { return positionFinal; }
    set { positionFinal = value; }
    }
        public bool  Respuesta  // property
     {
    get { return respuesta; }
    set { respuesta = value; }
    }
      
      
               public int ContadorSecuencia  // property
     {
    get { return contadorSecuencia; }
    set { contadorSecuencia = value; }
    }

      
             public int PuntuacionVeintiuna  // property
     {
    get { return puntuacionVeintiuna; }
    set { puntuacionVeintiuna = value; }
    }


          public bool  SiguienteCobro  // property
     {
    get { return siguienteCobro; }
    set { siguienteCobro = value; }
    }

    
             public bool  Veintiunabool  // property
     {
    get { return veintiunabool; }
    set { veintiunabool = value; }
    }

            public bool  SiguientePregunta  // property
     {
    get { return siguientePregunta; }
    set { siguientePregunta = value; }
    }
  

     private IEnumerator Esperar(){
         yield return new WaitForSeconds(8);
     }

     void penal(){
            this.kinectPenal=Instantiate(kinect); 
            //kinect.SetActive(true);
            panel.SetActive(false);
            Ballpenalty.SetActive(true);
            ContenedorVeintiuna.SetActive(false);
            BallVeintiuna.SetActive(false);
        }

     void penalBarrera(){
            this.kinectPenal=Instantiate(kinect);
            panel.SetActive(false);
            Ballpenalty.SetActive(true);
            ContenedorVeintiuna.SetActive(false);
            BallVeintiuna.SetActive(false);
            // if(Respuesta){
            //  panel.SetActive(false);
            // }
            // else{
                if(Bloques.NombreBloque.Equals("Bloque1")||Bloques.NombreBloque.Equals("Bloque2")){

                 if(Bloques.Dificultad.Equals("facil")){
                     obstaculoRayo1.SetActive(true);
                    }
             else if(Bloques.Dificultad.Equals("medio")){
                obstaculoRayo1.SetActive(true);
                obstaculoRayo2.SetActive(true);
                    }
                else if(Bloques.Dificultad.Equals("dificil")){
                    obstaculoRayo1.SetActive(true);
                    obstaculoRayo2.SetActive(true);
                    obstaculoRayo3.SetActive(true);
                    }

                }
                else if(Bloques.NombreBloque.Equals("Bloque3")){

                 if(Bloques.Dificultad.Equals("facil")){
                     obstaculoArbol1.SetActive(true);
                    }
                else if(Bloques.Dificultad.Equals("medio")){
                obstaculoArbol1.SetActive(true);
                obstaculoArbol2.SetActive(true);
                    }
                else if(Bloques.Dificultad.Equals("dificil")){
                    obstaculoArbol1.SetActive(true);
                    obstaculoArbol2.SetActive(true);
                    obstaculoArbol3.SetActive(true);
                    }

                }
                else if(Bloques.NombreBloque.Equals("Bloque4")){

                    if(Bloques.Dificultad.Equals("facil")){
                     obstaculoGota1.SetActive(true);
                    }
                 else if(Bloques.Dificultad.Equals("medio")){
                obstaculoGota1.SetActive(true);
                obstaculoGota2.SetActive(true);
                    }
                    else if(Bloques.Dificultad.Equals("dificil")){
                    obstaculoGota1.SetActive(true);
                    obstaculoGota2.SetActive(true);
                    obstaculoGota3.SetActive(true);
                    }

                }
        
        }

        void Desactivar(string nombreSecuencia){

            if(nombreSecuencia.Equals("ListadeJugadoresEspalda")){
                   for(int i=0; i<ListadeJugadoresEspalda.Length;i++)
                {
                       ListadeJugadoresEspalda[i].SetActive(false);
                   }  
        }
        else {
                     for(int i=0; i<ListadeJugadoresFrente.Length;i++)
                {
                       ListadeJugadoresFrente[i].SetActive(false);
                   }  
        }

        }
        

     void pregunta(){
        //    this.SecuenciaJuego=this.SecuenciaJuego+1;
            // kinect.SetActive(false);
            panel.SetActive(true);
            generarPregunta();
            Destroy(kinectPenal);
            Destroy(kinectVeintiuna);
            obstaculoGota1.SetActive(false);
            obstaculoGota2.SetActive(false);
            obstaculoGota3.SetActive(false);
            obstaculoArbol1.SetActive(false);
            obstaculoArbol2.SetActive(false);
            obstaculoArbol3.SetActive(false);
            obstaculoRayo1.SetActive(false);
            obstaculoRayo2.SetActive(false);
            obstaculoRayo3.SetActive(false);
            BallVeintiuna.GetComponent<Veintiuna>().Seguir=false;
            BallVeintiuna.GetComponent<Veintiuna>().Seguir=false;
            
        
        }

      void veintiUno(){
           BallVeintiuna.GetComponent<Veintiuna>().Seguir=false;
            kinectVeintiuna=Instantiate(kinect); 
          // kinect.SetActive(true);
            panel.SetActive(false);
            Ballpenalty.SetActive(false);
            ContenedorVeintiuna.SetActive(true);
            BallVeintiuna.SetActive(true);
            
            
        }
    void veintiUnoRapido(){
        BallVeintiuna.GetComponent<Veintiuna>().Seguir=true;
            kinectVeintiuna=Instantiate(kinect); 
            panel.SetActive(false);
            Ballpenalty.SetActive(false);
            ContenedorVeintiuna.SetActive(true);
            BallVeintiuna.SetActive(true);
        }

}
