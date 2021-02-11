using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Crud : MonoBehaviour
{

    public GameObject itemParent,form_create,item;

    // public GameObject pregunta;
    // public GameObject opcion1;
    // public GameObject opcion2;
    // public GameObject opcion3;
    // public GameObject correcta;
    
    // Start is called before the first frame update
    void Start()
    {   
        read();
    }

 public void read(){
     
     int count=PlayerPrefs.GetInt("count",0);
     int number=0;
     for(int i=0 ;i<itemParent.transform.childCount;i++){
         Destroy(itemParent.transform.GetChild(i).gameObject);
     }
     
     for(int i=1 ;i<=count;i++){
        
        string id=PlayerPrefs.GetString("id["+i+"]");
        string pregunta=PlayerPrefs.GetString("pregunta["+i+"]");
        string op1=PlayerPrefs.GetString("op1["+i+"]");
        string op2=PlayerPrefs.GetString("op2["+i+"]");
        number=number+1;
        if(id != ""){
            GameObject tmp_item=Instantiate(item,itemParent.transform);
            tmp_item.name=i.ToString();
            tmp_item.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=number.ToString();
            print(number.ToString());
            tmp_item.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text=pregunta;
            tmp_item.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text=op1;
            tmp_item.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text=op2;
        }
        
        else{
            number=number-1;
        }
     }
     
 }


 public void create(){
     int count =PlayerPrefs.GetInt("count");
     count++;
     PlayerPrefs.SetString("id["+count+"]", count.ToString());
     PlayerPrefs.SetString("pregunta["+count+"]",form_create.transform.GetChild(1).GetComponent<TMP_InputField>().text);
     print(form_create.transform.GetChild(1).GetComponent<TMP_InputField>().text);
     PlayerPrefs.SetString("op1["+count+"]",form_create.transform.GetChild(2).GetComponent<TMP_InputField>().text);
     PlayerPrefs.SetString("op2["+count+"]",form_create.transform.GetChild(3).GetComponent<TMP_InputField>().text);
     PlayerPrefs.SetInt("count", 0);
     form_create.transform.GetChild(1).GetComponent<TMP_InputField>().text="";
     form_create.transform.GetChild(2).GetComponent<TMP_InputField>().text="";
     form_create.transform.GetChild(3).GetComponent<TMP_InputField>().text="";
     read();
 }



        public void delete(GameObject itemAdional){
            string id_perf=itemAdional.name;
            PlayerPrefs.DeleteKey("id["+id_perf+"]");
            PlayerPrefs.DeleteKey("pregunta["+id_perf+"]");
            PlayerPrefs.DeleteKey("op1["+id_perf+"]");
            PlayerPrefs.DeleteKey("op2["+id_perf+"]");
            read();

        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
