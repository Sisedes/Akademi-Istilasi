using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public void oyunBaslat()
    {
        SceneManager.LoadScene(1);
    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene(0);
    }
}
