/*
 Nombre del desarrollador: Perez Montiel Miguel Ulises
 Asignatura: Realidad aumentada
 Nombre Scripts: eventosmouse
 Descripcion: En este script se cambia el color de un objeto de la escena
  
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosmouse : MonoBehaviour
{
    [SerializeField]
    Renderer materiaObjeto;

   // private void OnMouseEnter()
   // {
   //     materiaObjeto.material.color = Color.blue;
   // }

   // private void OnMouseExit()
   // {
   //      materiaObjeto.material.color = Color.green;
   // }

   // private void OnMouseOver()
   //{
   //     materiaObjeto.material.color = Color.red;
   //}

        // Cuando se suelta el click el color cambia a negro
    private void OnMouseUp()
    {
        materiaObjeto.material.color = Color.black;
    }
    // Cuando se da click el color cambia a amarillo
    private void OnMouseDown()
    {
        materiaObjeto.material.color = Color.yellow;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
