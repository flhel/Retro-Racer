using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour, IDataPersistence
{

    //Menus
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject LevelMenu;

    //Buttons
    public GameObject DriveButtonObject;
    private Button DriveButton;

    public void Start()
    {
        QuitToMainMenu();
        DriveButton = DriveButtonObject.GetComponent<Button>();
        DriveButton.interactable = false;
    }

    public void QuitToMainMenu()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        LevelMenu.SetActive(false);
    }

    //MainMenu

    public void SelectLevel()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
    }

    public void Options()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Credits()
    {

    }

    public void QuitGame()
    {
        Debug.Log("This Button Quits the Game");
        Application.Quit();
    }

    // LevelMenu

    private string LevelName = null;

    public void SetGamemodeTimeattack()
    {

    }

    public void SetGamemodeCruise()
    {

    }

    public void SetLevel1()
    {
        LevelName = "CybercityHighway";
        DriveButton.interactable = true;
    }


    public void SetLevel2()
    {
        LevelName = "CaliforniaHighway";
        DriveButton.interactable = true;
    }

    public void Drive()
    {
        SceneManager.LoadScene("Driving");
        SceneManager.LoadScene(LevelName, LoadSceneMode.Additive);
    }



    // OptionsMenu




    // Data Handling

    public void LoadData(GameData data)
    {
    }

    public void SaveData(ref GameData data)
    {
    }
}
