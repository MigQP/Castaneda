using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject titleScreen;

   


    public void SetOffTitle()
    {
        titleScreen.SetActive(false);
    }

    public void ExitApp ()
    {
        Application.Quit();
    }


}
