using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Veintiuna : MonoBehaviour
{
    private Vector3 valor;
    bool ejecutar;
    public float fuerazaMagnitud=4f;
    int contador;
    Administradortest admin;
   public TextMeshProUGUI ball;
   private bool seguir;

    void Start()
    {    
         contador=0;
        admin=GameObject.Find("Administradortest").GetComponent<Administradortest>();
        ejecutar=false;
    }

    // Update is called once per frame
    void Update()
    
    { 

      // if(ejecutar){
      //   this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
      //   this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0.3f,0)*fuerazaMagnitud,ForceMode.Impulse);
      // }
        // // if(ejecutar){
        // BalonVeintiuna.GetComponent<Rigidbody>().velocity=Vector3.zero;
        // BalonVeintiuna.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0),ForceMode.Impulse);
        // }
      //   valor=transform.position;
      // if(transform.position.x<=1.3|| transform.position.x>=4.3){
      //   valor.x=2.84f;
      //  transform.position=valor;
      // }
      //   if(transform.position.y<=0||transform.position.y>=7.1){
      //   valor.y=3.44f;
      //  transform.position=valor;
      // }

      //  if(transform.position.z<=3 || transform.position.z>=5){
      //   valor.z=4.0f;
      //  transform.position=valor;
      // }
    }

    

    void OnTriggerEnter(Collider other){
        // if(other.name!=terrain||other.name!=estadio){
          
          if(other.name=="LeftToeBase" ||other.name=="RightToeBase"||other.name=="RightFoot" ||other.name=="RightLeg"
          ||other.name=="LeftFoot" ||other.name=="LeftLeg"||other.name=="RightHand" || other.name=="LeftHand"){
            contador=contador+1;
          }

          if(Seguir){
          this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*fuerazaMagnitud,ForceMode.Impulse);
        this.gameObject.GetComponent<Rigidbody>().velocity=new Vector3(0, 10, 0);
          } 
           if(!Seguir){
               this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
               this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*fuerazaMagnitud,ForceMode.Impulse);
           }
          
        // }
        ///print(other.name);
        


        if(other.name=="terrain" ||contador>=21 ||other.name!="estadio"){

        if(contador>=15 && contador<=21){
         if(admin.ContadorSecuencia ==2){
          admin.PuntuacionVeintiuna=3;
          admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;
          contador=0;
          ball.text="Excelente";
        }

        else if(admin.ContadorSecuencia ==4){
          admin.PuntuacionVeintiuna=8;
          admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;
          contador=0;
          ball.text="Excelente";
        }
        }
        
        else if(contador>=5 && contador<=14){
         if(admin.ContadorSecuencia ==2){
          admin.PuntuacionVeintiuna=2;
          admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;
          contador=0;
          ball.text="Bien";
        }

        else if(admin.ContadorSecuencia ==4){
          admin.PuntuacionVeintiuna=4;
          admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;
          contador=0;
          ball.text="Bien";
        }
        }


          else if(contador>=1 && contador<=4){
         if(admin.ContadorSecuencia ==2){
          admin.PuntuacionVeintiuna=1;
          admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;
          contador=0;
          ball.text="Bien";
        }

        else if(admin.ContadorSecuencia ==4){
          admin.PuntuacionVeintiuna=2;
          admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;
          contador=0;
          ball.text="Bien";
        }
        }
        }
      //  if (other.name == "joint_ToeRT"||other.name == "joint_ToeLT"){
      //     ejecutar=true;
      //   }

        
      // print(other.name);
      // ejecutar=true;
    }

     void OnTriggerExit(Collider other)
    {   
        //  if (other.name == "joint_ToeRT"||other.name == "joint_ToeLT"){
            //  ejecutar=false;
        // }
    }


           public bool  Seguir  // property
     {
    get { return seguir; }
    set { seguir = value; }
    }
}
