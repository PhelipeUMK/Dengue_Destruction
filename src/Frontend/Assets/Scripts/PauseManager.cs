using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseManager : MonoBehaviour
{
    private bool isPaused;
    public GameObject pausePanel;

    void Start()
    {
        // Desativa o painel de pausa no in�cio do jogo
        pausePanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

   

    public void TogglePause()
    {
        isPaused = !isPaused;
        pausePanel.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0; // Pausa o tempo do jogo
        }
        else
        {
            Time.timeScale = 1; // Reseta o tempo do jogo para o normal
        }
    }
    public bool IsPaused()
    {
        return isPaused;
    }
    public void ResumeGame()
    {
        isPaused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RetornarMenu(){
        SceneManager.LoadScene("MenuPrincipal");
    }
}

