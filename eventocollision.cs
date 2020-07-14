/*
 Nombre del desarrollador: Perez Montiel Miguel Ulises
 Asignatura: Realidad aumentada
 Nombre Scripts: eventcollision
 Descripcion: En este script se cambia el color de un objeto mediante la colision de un elemento llamado bullet
  
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventocollision : MonoBehaviour
{
    [SerializeField]
    Renderer objPlayer;

    public Color objColor;

    // Busca dentro del modelo de c man en especifico la playera para que cambie de color la playera
    private void Awake()
    {
        objPlayer = GameObject.Find("C_man_1_FBX2013").GetComponent<Renderer>();


    }

    // Le da al objeto con el tag bullet la propiedad de cambio de color
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="bullet")
        {
            objPlayer.material.color = objColor;


        }


    }

}
