using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuControl : MonoBehaviour
{
    public GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Quick and Dirty Menu with "Game freeze"
            if (PauseMenu.activeSelf)
            {
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                PauseMenu.SetActive(true);
            }

        }
    }

    public void ContinueDrive()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public void ExitDrive()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}