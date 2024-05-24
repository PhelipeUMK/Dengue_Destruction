using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClicarSim()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ClicarNao()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
