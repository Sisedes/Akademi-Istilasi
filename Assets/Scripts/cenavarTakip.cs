using UnityEngine;

public class cenavarTakip : MonoBehaviour
{
    public float Speed = 2f;
    public float stoppingDistance = 1f;
    public float retreatDistance = 0.5f;

    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Character").transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, target.position) < stoppingDistance && Vector2.Distance(transform.position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -Speed * Time.deltaTime);
        }
    }
}
