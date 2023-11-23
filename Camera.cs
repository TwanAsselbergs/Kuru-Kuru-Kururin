using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dit is de Camera klasse die erft van MonoBehaviour
public class Camera : MonoBehaviour
{
   // Dit is een privé variabele die de positie van de speler bijhoudt
   [SerializeField] private Transform playerTransform;

   // Deze methode wordt elke frame bijgewerkt
   private void Update()
   {
      // Hier stellen we de positie van de camera in op de positie van de speler, maar dan 5 eenheden naar achteren in de z-as
      transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -5f);
   }
}