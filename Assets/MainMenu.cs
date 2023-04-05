using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SettingsBtn()
    {

    }

    public void QuitBtn()
    {
        Debug.Log("Exiting game...");
            Application.Quit();
    }
}
