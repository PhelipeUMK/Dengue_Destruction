using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Focos : MonoBehaviour
{
    bool pneu1 = true;
    bool pneu2 = true;
    bool pneu3 = true;
    bool pneu4 = true;
    bool pneu5 = true;
    bool pneu6 = true;
    bool pneu7 = true;
    bool pneu8 = true;
    bool pneu9 = true;
    bool caixaDaAgua1 = true;
    bool caixaDaAgua2 = true;
    bool vaso1 = true;
    bool vaso2 = true;
    bool vaso3 = true;
    
    int focos = 14;
    int casos = 0;
    public TMP_Text casosTotal;
    public TMP_Text focosTotal;
    public TMP_Text rank;
    int rankN = 1;

    private PauseManager pauseManager;
    // Start is called before the first frame update
    void Start()
    {
        pauseManager = FindAnyObjectByType<PauseManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseManager != null && !pauseManager.IsPaused())
        {
            if (focos > 0)
            {
                casos++;
                casosTotal.SetText($"Casos: {casos}");
            }

            if (casos < 3000)
            {
                rank.SetText("Rank: A");
                rankN = 1;
            }
            else if (casos < 4000)
            {
                rank.SetText("Rank: B");
                rankN = 2;
            }
            else if (casos < 5000)
            {
                rank.SetText("Rank: C");
                rankN = 3;
            }
            else if (focos < 6000)
            {
                rank.SetText("Rank: D");
                rankN = 4;
            }
            else
            {
                rank.SetText("Rank: ");
                rankN = 5;
            }
        }
    }

    void OnTriggerStay(Collider y)
    {


        if ((y.gameObject.name == "Pneu1" && Input.GetKey(KeyCode.E)))
        {
            if (pneu1)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu1 = false;
            }
        }

        if ((y.gameObject.name == "Pneu2" && Input.GetKey(KeyCode.E)))
        {
            if (pneu2)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu2 = false;
            }
        }

        if ((y.gameObject.name == "Pneu3" && Input.GetKey(KeyCode.E)))
        {
            if (pneu3)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu3 = false;
            }
        }

        if ((y.gameObject.name == "Pneu4" && Input.GetKey(KeyCode.E)))
        {
            if (pneu4)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu4 = false;
            }
        }

        if ((y.gameObject.name == "Pneu5" && Input.GetKey(KeyCode.E)))
        {
            if (pneu5)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu5 = false;
            }
        }

        if ((y.gameObject.name == "Pneu6" && Input.GetKey(KeyCode.E)))
        {
            if (pneu6)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu6 = false;
            }
        }

        if ((y.gameObject.name == "Pneu7" && Input.GetKey(KeyCode.E)))
        {
            if (pneu7)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu7 = false;
            }
        }

        if ((y.gameObject.name == "Pneu8" && Input.GetKey(KeyCode.E)))
        {
            if (pneu8)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu8 = false;
            }
        }

        if ((y.gameObject.name == "Pneu9" && Input.GetKey(KeyCode.E)))
        {
            if (pneu9)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu9 = false;
            }
        }

        if ((y.gameObject.name == "Tampa1" && Input.GetKey(KeyCode.E)))
        {
            if (caixaDaAgua1)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                caixaDaAgua1 = false;
            }
        }

        if ((y.gameObject.name == "Tampa2" && Input.GetKey(KeyCode.E)))
        {
            if (caixaDaAgua2)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                caixaDaAgua2 = false;
            }
        }

        if ((y.gameObject.name == "PratoDeVaso1" && Input.GetKey(KeyCode.E)))
        {
            if (vaso1)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                vaso1 = false;
            }
        }

        if ((y.gameObject.name == "PratoDeVaso2" && Input.GetKey(KeyCode.E)))
        {
            if (vaso2)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                vaso2 = false;
            }
        }

        if ((y.gameObject.name == "PratoDeVaso3" && Input.GetKey(KeyCode.E)))
        {
            if (vaso3)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                vaso3 = false;
            }
        }

        if (focos == 0)
        {
            if (rankN == 1)
            {
                focosTotal.SetText("Parab�ns!!!");
                SceneManager.LoadScene("VictorySceneA");
            }
            else if (rankN == 2)
            {
                focosTotal.SetText("Nada mal.");
                SceneManager.LoadScene("VictorySceneB");
            }
            else if (rankN == 3)
            {
                focosTotal.SetText("Foi mais ou menos.");
                SceneManager.LoadScene("VictorySceneC");
            }
            else if (rankN == 4)
            {
                focosTotal.SetText("Voc� foi mal.");
                SceneManager.LoadScene("VictorySceneDE");
            }
            else if (rankN == 5)
            {
                focosTotal.SetText("P�ssimo!");
                SceneManager.LoadScene("VictorySceneDE");
            }
        }
    }
}
