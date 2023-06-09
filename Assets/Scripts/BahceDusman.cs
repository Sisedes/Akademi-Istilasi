using UnityEngine;
using UnityEngine.SceneManagement;

public class BahceDusman : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] float movespeed;
    public int waypointDest;
    [SerializeField] GameObject enemy;
    private void Update()
    {
        patrols();
    }

    private void patrols()
    {
        if (gameObject.CompareTag("Serseri"))
        {
            if (waypointDest == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, waypoints[0].position, movespeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, waypoints[0].position) < .2f)
                {
                    transform.localScale = new Vector2(5.211222f, transform.localScale.y);
                    waypointDest = 1;
                }
            }
            else if (waypointDest == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, waypoints[1].position, movespeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, waypoints[1].position) < .2f)
                {
                    transform.localScale = new Vector2(-5.211222f, transform.localScale.y);
                    waypointDest = 2;
                }
            }
            else if (waypointDest == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, waypoints[2].position, movespeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, waypoints[2].position) < .2f)
                {
                    transform.localScale = new Vector2(-5.211222f, transform.localScale.y);
                    waypointDest = 3;
                }
            }
            else if (waypointDest == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, waypoints[3].position, movespeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, waypoints[3].position) < .2f)
                {
                    transform.localScale = new Vector2(-5.211222f, transform.localScale.y);
                    waypointDest = 0;
                }
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            SceneManager.LoadScene(2); 
        }
    }
}
