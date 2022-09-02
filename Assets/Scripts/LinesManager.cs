using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinesManager : MonoBehaviour
{

    public GameObject[] lines_Screens;

    public GameObject credits_Screen;

    int timesPassed;


    public void SetLineOn()
    {
        lines_Screens[Random.Range(0, lines_Screens.Length - 1)].SetActive(true);
        StartCoroutine(Fade());
    }

    public void SetCreditsOn()
    {
        StartCoroutine(FadeCredits());
    }


    IEnumerator Fade()
    {

        yield return new WaitForSeconds(1.25f);

        //lines_Screens[Random.Range(0, lines_Screens.Length - 1)].SetActive(true);

    }

    IEnumerator FadeCredits()
    {

        yield return new WaitForSeconds(1.1f);

        //lines_Screens[Random.Range(0, lines_Screens.Length - 1)].SetActive(true);
        credits_Screen.SetActive(true);

    }
}
