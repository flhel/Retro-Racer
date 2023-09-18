using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    public GameObject FinishMenu;

    void Start()
    {
        FinishMenu.SetActive(false);
    }

    // Checks if the Car has crossed the finishline
    void OnTriggerEnter()
    {
        FinishMenu.SetActive(true);
    }

    // Code for the Finishmenu Buttons
    public void ExitDrive()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
