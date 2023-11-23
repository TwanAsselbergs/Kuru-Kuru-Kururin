using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Dit is een hulpprogramma klasse voor algemene functies
public class Utilities : MonoBehaviour
{
    // Deze functie laadt het spel
    public void GoToGame()
    {
        SceneManager.LoadScene("Game"); // Laad de scène "Game"
    }

    // Deze functie sluit het spel af
    public void QuitGame()
    {
        Application.Quit(); // Sluit de applicatie
    }
}