using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool isPaused;


    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Continou();
            }else
            {
                Pause();
            }
        }
    }

    public void Continou()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = true;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = false;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
