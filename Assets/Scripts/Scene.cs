using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
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

    public void oyunBaslat()
    {
        SceneManager.LoadScene(1);
    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene(0);
    }
}
