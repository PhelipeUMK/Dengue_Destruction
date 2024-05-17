using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Focos : MonoBehaviour
{
    [SerializeField] float remainingTime;

    bool pneu1 = true;
    bool pneu2 = true;
    bool pneu3 = true;
    bool pneu4 = true;
    bool pneu5 = true;
    bool pneu6 = true;
    bool pneu7 = true;
    bool pneu8 = true;
    bool pneu9 = true;
    bool caixaDaAgua = true;
    bool tempo = true;
    bool pratoDeVaso1 = true;
    bool pratoDeVaso2 = true;

    int focos = 12;
    int casos = 0;
    public TMP_Text casosTotal;
    public TMP_Text focosTotal;
    public TMP_Text rank;
    int rankN = 1;
     

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    { 
        if (tempo)
        {
            remainingTime -= Time.deltaTime;
        }

        if (focos == 0)

        {
            tempo = false;
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        

        if (focos > 0)
        {
            casos++;
            casosTotal.SetText($"Casos: {casos}");
        }

        if (casos < 26000)
        {
            rank.SetText("Rank: A");
            rankN = 1;
        }

       else if (casos < 30000)
        {
            rank.SetText("Rank: B");
            rankN = 2;
        }
        else if (casos < 34000)
        {
            rank.SetText("Rank: C");
            rankN = 3;
        }
        else if (casos < 38000)
        {
            rank.SetText("Rank: D");
            rankN = 4;
        }
        else
        {
            rank.SetText("Rank: E");
            rankN = 5;
        }
    }

    void OnTriggerStay(Collider y)
    {


        if ((y.gameObject.name == $"Pneu1" && Input.GetKey(KeyCode.E)))
        {
            if (pneu1)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu1 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu2" && Input.GetKey(KeyCode.E)))
        {
            if (pneu2)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu2 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu3" && Input.GetKey(KeyCode.E)))
        {
            if (pneu3)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu3 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu4" && Input.GetKey(KeyCode.E)))
        {
            if (pneu4)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu4 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu5" && Input.GetKey(KeyCode.E)))
        {
            if (pneu5)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu5 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu6" && Input.GetKey(KeyCode.E)))
        {
            if (pneu6)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu6 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu7" && Input.GetKey(KeyCode.E)))
        {
            if (pneu7)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu7 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu8" && Input.GetKey(KeyCode.E)))
        {
            if (pneu8)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu8 = false;
            }
        }

        if ((y.gameObject.name == $"Pneu9" && Input.GetKey(KeyCode.E)))
        {
            if (pneu9)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pneu9 = false;
            }
        }

        if ((y.gameObject.name == $"Tampa" && Input.GetKey(KeyCode.E)))
        {
            if (caixaDaAgua)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                caixaDaAgua = false;
            }
        }

        if ((y.gameObject.name == $"PratoDeVaso1" && Input.GetKey(KeyCode.E)))
        {
            if (pratoDeVaso1)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pratoDeVaso1 = false;
            }
        }

        if ((y.gameObject.name == $"PratoDeVaso2" && Input.GetKey(KeyCode.E)))
        {
            if (pratoDeVaso2)
            {
                focos--;
                focosTotal.SetText($"Focos: {focos}");
                pratoDeVaso2 = false;
            }
        }
        if (focos == 0)
        {
            if (rankN == 1)
            {
                focosTotal.SetText("Parabéns!!!");
            }
            else if (rankN == 2)
            {
                focosTotal.SetText("Nada mal.");
            }
            else if (rankN == 3)
            {
                focosTotal.SetText("Foi mais ou menos.");
            }
            else if (rankN == 4)
            {
                focosTotal.SetText("Você foi mal.");
            }
            else if (rankN == 5)
            {
                focosTotal.SetText("Péssimo!");
            }
        }
    }
}
