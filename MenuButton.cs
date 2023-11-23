using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
