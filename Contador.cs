/*
 Nombre del desarrollador: Perez Montiel Miguel Ulises
 Asignatura: Realidad aumentada
 Nombre Scripts: Contador
 Descripcion: El contador tendra todas las variables y metodos que desencadenaran la seleccion de un objeto y su asignacion al image target
  
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    #region Declaracion de variables
    public menuseleccion comida;
    public GameObject elegido;
    public GameObject destruirObj;
    public GameObject menuHome;
    public Transform objPosition;
    public Transform padrePosition;
    public GameObject[] menus;
    public int contador;


    #endregion

    // Mantiene la conexion entre menu home, los objetos de la comida y el menu de seleccion
    private void Start()
    {
        comida = GetComponentInParent<menuseleccion>();
        menuHome.SetActive(false);
    }

    // Contiene los objetos de comida y aumenta el contador de estos
    public void ContadorSuma()
    {
        comida.objetos[contador].SetActive(false);
        contador++;

        if(contador == comida.objetos.Length)
        {

            contador = 0;
        }

        comida.objetos[contador].SetActive(true);


    }




    // Contiene los objetos de comida y resta el contador de estos
    public void ContadorResta()
    {
        comida.objetos[contador].SetActive(false);
        contador--;

        if (contador < 0)
        {

            contador = comida.objetos.Length - 1; ;
        }

        comida.objetos[contador].SetActive(true);


    }
    // Activa la visualizacion de la comida en QR
    public void Seleccion()
    {
        GameObject comidaPos = Instantiate(elegido,objPosition.position,objPosition.rotation) as GameObject;

        comidaPos.transform.SetParent(padrePosition);

        comidaPos.GetComponent<MeshRenderer>().enabled = false;

        comidaPos.AddComponent<BoxCollider>();

        comidaPos.tag = "Player";

        // Activa el boton menu cuando seleccionas comida
        foreach (var m in menus)
        {

            m.SetActive(false);
        }
        menuHome.SetActive(true);


    }

    // Desactiva la visualizacion de la comida cuando se usa la cámara
    public void Home()
    {
        destruirObj = GameObject.FindGameObjectWithTag("Player");

        Destroy(destruirObj);

        foreach (var m in menus)
        {

            m.SetActive(true);

        }

        menuHome.SetActive(false);

    }

    // Selecciona la comida
    private void Update()
    {
        elegido = comida.objetos[contador];

    }


}
