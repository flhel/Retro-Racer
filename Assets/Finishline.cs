using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    public GameObject FinishMenu;

    void OnTriggerEnter()
    {
        FinishMenu.SetActive(true);
    }

    public void ExitDrive()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
