/*
 Nombre del desarrollador: Perez Montiel Miguel Ulises
 Asignatura: Realidad aumentada
 Nombre Scripts: MenuSeleccion
 Descripcion: En este script se guardaran los objetos del menu de seleccion
  
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuseleccion : MonoBehaviour
{
    // Almacena cada objeto seleccionado
    public GameObject[] objetos;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in objetos)
        {
            go.SetActive(false);
        }
        if (objetos[0])
        {


            objetos[0].SetActive(true);

        }



    }

   
}
