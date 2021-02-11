using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptPuntuacion : MonoBehaviour
{
    Puntuacion1 puntuacion;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    AdministradorJugadores NumeroJugadores;
    public GameObject podium1;
    public GameObject podium2;
    public GameObject podium3;
    public GameObject[] Jugadores;
  


    void Start()
    {
        puntuacion=FindObjectOfType<Puntuacion1>();
        NumeroJugadores=FindObjectOfType<AdministradorJugadores>();
    }

    void Update()
    {      
       
         
    }

    public void generarPuntuacion()
    {
       if(puntuacion.PuntuacionJugador1>=puntuacion.PuntuacionJugador2 && puntuacion.PuntuacionJugador1>=puntuacion.PuntuacionJugador3)
       {
            text1.text=puntuacion.PuntuacionJugador1 +" pts";
            podium1.SetActive(true);
               for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       Jugadores[i].SetActive(true);
                   }
            }
            if(NumeroJugadores.Jugadores==2){
                text2.text=puntuacion.PuntuacionJugador2 +" pts";
                podium2.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       Jugadores[i].SetActive(true);
                   }
            }
            }

           else if(NumeroJugadores.Jugadores==3){
               if(puntuacion.PuntuacionJugador2>=puntuacion.PuntuacionJugador3){
                    text2.text=puntuacion.PuntuacionJugador2 +" pts";
                    text3.text=puntuacion.PuntuacionJugador3 +" pts";
                    podium2.SetActive(true);
                    podium3.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       Jugadores[i].SetActive(true);
                   }
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       Jugadores[i].SetActive(true);
                   }
                 }
               }
             else {
                   text2.text=puntuacion.PuntuacionJugador3 +" pts";
                    text3.text=puntuacion.PuntuacionJugador2 +" pts";
                    podium2.SetActive(true);
                    podium3.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       Jugadores[i].SetActive(true);
                   }
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       Jugadores[i].SetActive(true);
                   }
                 }

             }
            }

 
       }

       else if(puntuacion.PuntuacionJugador2>=puntuacion.PuntuacionJugador1 && puntuacion.PuntuacionJugador2>=puntuacion.PuntuacionJugador3)
       {
            text1.text=puntuacion.PuntuacionJugador2 +" pts";
            podium1.SetActive(true);
               for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       Jugadores[i].SetActive(true);
                   }
            }
            if(NumeroJugadores.Jugadores==2){
                text2.text=puntuacion.PuntuacionJugador1 +" pts";
                podium2.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       Jugadores[i].SetActive(true);
                   }
            }
            }

           else if(NumeroJugadores.Jugadores==3){
               if(puntuacion.PuntuacionJugador1>=puntuacion.PuntuacionJugador3){
                    text2.text=puntuacion.PuntuacionJugador1 +" pts";
                    text3.text=puntuacion.PuntuacionJugador3 +" pts";
                    podium2.SetActive(true);
                    podium3.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       Jugadores[i].SetActive(true);
                   }
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       Jugadores[i].SetActive(true);
                   }
                 }
               }
             else {
                   text2.text=puntuacion.PuntuacionJugador3 +" pts";
                    text3.text=puntuacion.PuntuacionJugador1 +" pts";
                    podium2.SetActive(true);
                    podium3.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       Jugadores[i].SetActive(true);
                   }
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       Jugadores[i].SetActive(true);
                   }
                 }

             }
         }
       }

       else  if(puntuacion.PuntuacionJugador3>=puntuacion.PuntuacionJugador1 && puntuacion.PuntuacionJugador3>puntuacion.PuntuacionJugador2)
       {
            text1.text=puntuacion.PuntuacionJugador3 +" pts";
            podium1.SetActive(true);
               for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[2]==i){
                       Jugadores[i].SetActive(true);
                   }
            }

            if(puntuacion.PuntuacionJugador2>=puntuacion.PuntuacionJugador1){
                    text2.text=puntuacion.PuntuacionJugador2 +" pts";
                    text3.text=puntuacion.PuntuacionJugador1 +" pts";
                    podium2.SetActive(true);
                    podium3.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       Jugadores[i].SetActive(true);
                   }
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       Jugadores[i].SetActive(true);
                   }
                 }
               }
             else {
                   text2.text=puntuacion.PuntuacionJugador1 +" pts";
                    text3.text=puntuacion.PuntuacionJugador2 +" pts";
                    podium2.SetActive(true);
                    podium3.SetActive(true);
                   for(int i=0; i<Jugadores.Length;i++){
                   if(NumeroJugadores.ListaNumeroJugadores[0]==i){
                       Jugadores[i].SetActive(true);
                   }
                   if(NumeroJugadores.ListaNumeroJugadores[1]==i){
                       Jugadores[i].SetActive(true);
                   }
                 }

             }

       }
    }
}
