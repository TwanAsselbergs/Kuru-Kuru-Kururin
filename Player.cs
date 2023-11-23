using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class Player : MonoBehaviour // Speler script
{
    [SerializeField] private float rotationSpeed = 1f; // Snelheid van de rotatie
    private float originalRotationSpeed; // Originele snelheid van de rotatie
    [SerializeField] private float playerX; // X positie van de speler
    [SerializeField] private float playerY; // Y positie van de speler
    [SerializeField] private float movementSpeed = 1f; // Snelheid van de beweging
    private Vector2 checkpointLocation = new Vector2(0, 0); // Locatie van het checkpoint
    private float reverseCooldown = 0f; // Cooldown van het omkeren
    private bool canReverse = true; // Kan de speler omkeren?

    private void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime * 10); // Roteer de speler

        if (reverseCooldown > 0) // Check of de cooldown nog niet voorbij is
        {
            reverseCooldown -= Time.deltaTime; // Verlaag de cooldown
        }
        else
        {
            canReverse = true; // Zet omkeren aan
        }
        // Beweeg de speler op basis van de input
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // Check of de speler naar rechts beweegt
        {
            playerX = transform.position.x + movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // Check of de speler naar links beweegt
        {
            playerX = transform.position.x - movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // Check of de speler naar boven beweegt
        {
            playerY = transform.position.y + movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) // Check of de speler naar beneden beweegt
        {
            playerY = transform.position.y - movementSpeed * Time.deltaTime;
        }

        transform.position = new Vector3(playerX, playerY); // Update de positie van de speler
    }

    private void OnCollisionEnter2D(Collision2D other) // Check of de speler een object raakt
    {
        // Check of de speler een finish raakt
        if (other.gameObject.name.StartsWith("Finish 1"))
        {
            playerX = 400f;
            playerY = 100f;
            transform.rotation = Quaternion.identity;
            checkpointLocation = new Vector2(400, 100);
        }
        // Check of de speler een muur raakt
        else if (other.gameObject.name.StartsWith("Wall 1"))
        {
            playerX = checkpointLocation.x;
            playerY = checkpointLocation.y;
            transform.rotation = Quaternion.identity;
        }
        // Check of de speler een finish raakt
        else if (other.gameObject.name.StartsWith("Finish 2"))
        {
            playerX = 850f;
            playerY = 78f;
            transform.rotation = Quaternion.identity;
            checkpointLocation = new Vector2(850, 78);
        }
        // Check of de speler een muur raakt
        else if (other.gameObject.name.StartsWith("Wall 2"))
        {
            playerX = checkpointLocation.x;
            playerY = checkpointLocation.y;
            transform.rotation = Quaternion.identity;
        }
        // Check of de speler een finish raakt
        else if (other.gameObject.name.StartsWith("Finish 3"))
        {
            playerX = 1300f;
            playerY = 78f;
            transform.rotation = Quaternion.identity;
            checkpointLocation = new Vector2(1300, 78);
        }
        // Check of de speler een muur raakt
        else if (other.gameObject.name.StartsWith("Wall 3"))
        {
            playerX = checkpointLocation.x;
            playerY = checkpointLocation.y;
            transform.rotation = Quaternion.identity;
        }
        // Check of de speler een finish raakt
        else if (other.gameObject.name.StartsWith("Finish 4"))
        {
            playerX = 1600f;
            playerY = 78f;
            transform.rotation = Quaternion.identity;
            checkpointLocation = new Vector2(1600, 78);
        }
        // Check of de speler een muur raakt
        else if (other.gameObject.name.StartsWith("Wall 4"))
        {
            playerX = checkpointLocation.x;
            playerY = checkpointLocation.y;
            transform.rotation = Quaternion.identity;
        }
        // Check of de speler een muur raakt
        else if (other.gameObject.name.StartsWith("Wall 5"))
        {
            playerX = checkpointLocation.x;
            playerY = checkpointLocation.y;
            transform.rotation = Quaternion.identity;
        }
        // Check of de speler een checkpoint raakt
        else if (other.gameObject.name.StartsWith("Checkpoint"))
        {
            checkpointLocation = transform.position;
        }
        // Check of de speler een checkpoint raakt
        else if (other.gameObject.name.StartsWith("Reverse") && canReverse)
        {
            rotationSpeed = Math.Abs(rotationSpeed) * -1;
            checkpointLocation = transform.position;
            reverseCooldown = 1f;
            canReverse = false;
        }
        // Check of de speler een checkpoint raakt
        else if (other.gameObject.name.StartsWith("Back") && canReverse)
        {
            rotationSpeed = Math.Abs(rotationSpeed);
            checkpointLocation = transform.position;
            reverseCooldown = 1f;
            canReverse = false;
        }
        // Check of de speler een finish raakt
        else if (other.gameObject.name.StartsWith("Finish 0"))
        {
            playerX = 0f;
            playerY = 0f;
            transform.rotation = Quaternion.identity;
            checkpointLocation = new Vector2(0, 0);
        }

        transform.position = new Vector2(playerX, playerY); // Update de positie van de speler
    }
}