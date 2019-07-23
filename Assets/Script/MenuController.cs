using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public string ARFoodMenu;
    public string MainMenu;
    public GameObject PanelInstructions;
    public GameObject PanelAbout;

    public void ARFoodMenuScene()
    {
        SceneManager.LoadScene(ARFoodMenu);
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void ShowPanelInstructions()
    {
        PanelInstructions.SetActive(true);
    }

    public void ShowPanelAbout()
    {
        PanelAbout.SetActive(true);
    }

    public void GoToMainMenu()
    {
        PanelInstructions.SetActive(false);
        PanelAbout.SetActive(false);
    }

    public void QuitApps()
    {
        Application.Quit();
    }
}
