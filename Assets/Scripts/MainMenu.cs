using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void BaslatTusu()
    {
        SceneManager.LoadScene(1);
    }

    public void CýkýsTusu()
    {
        Application.Quit();
    }
}
