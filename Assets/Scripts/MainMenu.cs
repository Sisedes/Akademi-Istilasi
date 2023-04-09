using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void Start()
    {
        panel.SetActive(false);
    }
    public void Ayarlar()
    {
        panel.SetActive(true);
    }
    public void kappa()
    {
        panel.SetActive(false);
    }
    public void BaslatTusu()
    {
        SceneManager.LoadScene(1);
    }

    public void CýkýsTusu()
    {
        Application.Quit();
    }
}
