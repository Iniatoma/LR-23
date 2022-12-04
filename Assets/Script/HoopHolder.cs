
using UnityEngine;

public class HoopHolder : MonoBehaviour
{
    public Transform obstacle;
    bool obstacleCompleted;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //take control of player
            FindObjectOfType<Player>().takePlayerInput = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (obstacleCompleted) return;
        if (collision.tag == "Player")
        {
            FindObjectOfType<Player>().takePlayerInput = false;
            obstacle.GetComponent<Obstacle>().RemoveObstacle();
            DestroyGameObject();
        }

    }
    public void DestroyGameObject()
    {
        GetComponentInParent<ObstacleHolder>().PlayDeadAnimation();
        Destroy(gameObject);
    }
}
