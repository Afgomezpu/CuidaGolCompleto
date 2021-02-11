using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Judadores : MonoBehaviour
{
    AdministradorJugadores NumeroJugadores;
    private string nombreJugador;
    public GameObject[] jugadores;
    public GameObject Nombre;
    public GameObject perfil;
    public GameObject btnJugador;
    public GameObject textJugadorSiguiente;
    string[] Listperfil;
   public GameObject[] jugadoresCamisa;
   public Material Color2;
   public Material Color3;
   int nuevocontadorColor;

  


    
    void Start()
    {   
        nuevocontadorColor=0;
        NumeroJugadores=FindObjectOfType<AdministradorJugadores>();
        NumeroJugadores.textJugador(1);
        Listperfil=new string[4]{"Soy solidario, creativo, me gusta alegrar la vida de las personas y frente a las dificultades, busco diferentes alternativas de solución.", 
         "Soy fuerte, observador,    propositivo, de pensamiento ágil y me gusta usar responsablemente la energía en todos los lugares.", 
         "Soy amigable, me comunico fácilmente, me gusta ayudar a los demás. Tengo la posibilidad de transformarme y me encanta cuidar el agua.", 
         "Soy un cuidamundos alegre, sensible, fuerte y ágil, me interesa cuidar a las personas y el ambiente natural. Protejo el agua, la energía y el planeta para que juntos tengamos una vida mejor."};
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void CambiarColor(int positicion){
        nuevocontadorColor=nuevocontadorColor+1;
        print(positicion);
        if(nuevocontadorColor==1){
        Renderer rend= jugadoresCamisa[positicion].GetComponent<Renderer>();
        rend.material=Color2;
        }
        else{
            Renderer rend= jugadoresCamisa[NumeroJugadores.Contador].GetComponent<Renderer>();
        rend.material=Color3;
        }

    }

    public void btSiguiente(){
        print(jugadores.Length);
        NumeroJugadores.Contador=NumeroJugadores.Contador+1;
          if(NumeroJugadores.Contador<jugadores.Length){
            for(int i=0;i<jugadores.Length;i++){
             if(i==NumeroJugadores.Contador){
             jugadores[i].SetActive(true);
             perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[i];
            }
            else{
                jugadores[i].SetActive(false);
                
            }
          }
    
    }
    else if(NumeroJugadores.Contador==jugadores.Length){
        NumeroJugadores.Contador=0;
        jugadores[jugadores.Length-1].SetActive(false);
        jugadores[NumeroJugadores.Contador].SetActive(true);
        perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[NumeroJugadores.Contador];
    }
    print(NumeroJugadores.Contador);
    }

    public void btAtras(){
        print(jugadores.Length);
        print(NumeroJugadores.Contador);
        NumeroJugadores.Contador=NumeroJugadores.Contador-1;
          if(NumeroJugadores.Contador<jugadores.Length && NumeroJugadores.Contador>=0){
            for(int i=0;i<jugadores.Length;i++){
             if(i==NumeroJugadores.Contador){
             jugadores[i].SetActive(true);
             perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[i];
            }
            else{
                jugadores[i].SetActive(false);
            }
          }
    
    }
    else if(NumeroJugadores.Contador<0){
        print("entro a el contrador");
        NumeroJugadores.Contador=jugadores.Length-1;
        jugadores[0].SetActive(false);
        jugadores[NumeroJugadores.Contador].SetActive(true);
        perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[NumeroJugadores.Contador];
    }

    }
    public void ombreJugador(){

        NumeroJugadores.NombreJugador=Nombre.GetComponent<TMP_InputField>().text;
        NumeroJugadores.NumeroJugador=NumeroJugadores.Contador;
        print(NumeroJugadores.Contador);
        NumeroJugadores.aceptar.SetActive(true);
        NumeroJugadores.TextAceptar.SetActive(true);
        
    }

    public void seleccionarJugador(){
       if(NumeroJugadores.ListaJugadores.Count<NumeroJugadores.Jugadores){
        Nombre.GetComponent<TMP_InputField>().text="";
        NumeroJugadores.aceptar.SetActive(false);
        NumeroJugadores.TextAceptar.SetActive(false);
       NumeroJugadores.ingresarJugadores(NumeroJugadores.NombreJugador);
       NumeroJugadores.ingresarNumeroJugadores(NumeroJugadores.NumeroJugador);
       
            if(NumeroJugadores.ListaJugadores.Count<NumeroJugadores.Jugadores){
                NumeroJugadores.textJugador(NumeroJugadores.ListaJugadores.Count+1);
                 CambiarColor(NumeroJugadores.Contador);
                textJugadorSiguiente.SetActive(true);
                // GameObject Temp=Instantiate(textJugadorSiguiente);
                // Temp.SetActive(true);
                Destroy(textJugadorSiguiente,3f);
            }
            if(NumeroJugadores.ListaJugadores.Count==NumeroJugadores.Jugadores){
                NumeroJugadores.aceptar.SetActive(false);
                NumeroJugadores.TextAceptar.SetActive(false);
                Nombre.SetActive(false);
                btnJugador.SetActive(false);
                NumeroJugadores.siguiente.SetActive(true); 
                NumeroJugadores.TextSiguiente.SetActive(true); 
                    
            }
       }
       else {
           print("ya selecciono los " + NumeroJugadores.Jugadores +" jugadores");
       }

    }

         public string  NombreJugador  // property
  {
    get { return nombreJugador; }
    set { nombreJugador = value; }
  }

  
}
