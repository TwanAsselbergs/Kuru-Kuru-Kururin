using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWall : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f; // Rotatiesnelheid van de muur
    [SerializeField] private float movementSpeed = 1f; // Bewegingssnelheid van de muur
    [SerializeField] private float maxMovementDistance = 1f; // Maximale bewegingsafstand van de muur
    private float baseX; // Basis X-positie van de muur

    private void Start()
    {
        baseX = transform.position.x; // Stel de basis X-positie in op de huidige X-positie van de muur
    }

    private void Update()
    {
        // Als de naam van het spelobject begint met "Wall 2 Rotate"
        if (gameObject.name.StartsWith("Wall 2 Rotate"))
        {
            // Roteer de muur met de ingestelde rotatiesnelheid
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime * -50);
        }
        // Als de naam van het spelobject begint met "Wall 2 Reverse Rotate"
        else if (gameObject.name.StartsWith("Wall 2 Reverse Rotate"))
        {
            // Roteer de muur in omgekeerde richting met de ingestelde rotatiesnelheid
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime * 50);
        }
        // Als de naam van het spelobject begint met "Wall 3 Horizontal 1"
        else if (gameObject.name.StartsWith("Wall 3 Horizontal 1"))
        {
            // Beweeg de muur horizontaal met de ingestelde bewegingssnelheid
            float newX = baseX + Mathf.PingPong(movementSpeed * Time.time * 5, maxMovementDistance);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
        // Als de naam van het spelobject begint met "Wall 3 Horizontal 2"
        else if (gameObject.name.StartsWith("Wall 3 Horizontal 2"))
        {
            // Beweeg de muur horizontaal met een verhoogde bewegingssnelheid
            float newX = baseX + Mathf.PingPong(movementSpeed * Time.time * 10, maxMovementDistance * 3);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }
}