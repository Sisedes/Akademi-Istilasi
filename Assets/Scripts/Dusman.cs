using UnityEngine;
using UnityEngine.SceneManagement;

public class Dusman : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    public int waypointDest;
    private void Update()
    {
        
    }

    private void patrols()
    {
        if (waypointDest == 0)
        {

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            SceneManager.LoadScene(5); 
        }
    }
}
