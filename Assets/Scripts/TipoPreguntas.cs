using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TipoPreguntas : MonoBehaviour
{   
     Opciones bloqueydificultad;
     IngresarPregunta ingresa;

    void Start()
    {
        bloqueydificultad = GameObject.Find("BloqueyDificultad").GetComponent<Opciones>();
        ingresa=GameObject.Find("Controlador").GetComponent<IngresarPregunta>();
        var dropdown=transform.GetComponent<TMP_Dropdown>();
        DropdownItemSelected(dropdown);
        dropdown.onValueChanged.AddListener(delegate{DropdownItemSelected(dropdown);});
    }
    
    void DropdownItemSelected(TMP_Dropdown dropdown){
            int index=dropdown.value;
            print(dropdown.options[index].text);
            bloqueydificultad.Tipo(dropdown.options[index].text);
            ingresa.Tipo(dropdown.options[index].text);

    }
    void Update()
    {
        
    }
}
