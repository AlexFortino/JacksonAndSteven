using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    bool isPaused = false;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
   public void Pause()
    {
        panel.SetActive(true);

        Time.timeScale = 0;

        Cursor.lockState = CursorLockMode.Confined;
    }
   public void resume() {
        panel.SetActive(false);

        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;


    }
    public void reset()
    {
        resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
