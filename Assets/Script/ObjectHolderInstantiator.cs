
using UnityEngine;

public class ObjectHolderInstantiator : MonoBehaviour
{
    public GameObject obstacle;
    public int distanceBetweenObstacle;
     int currentObstaclePosition;
    public Vector2 minMaxYValue;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateObstacle();
    }
    
    public void InstantiateObstacle()
    {
        for (int i = 0; i < 50; i++)
        {
            currentObstaclePosition += distanceBetweenObstacle;
            GameObject GO =  Instantiate(obstacle, new Vector3(currentObstaclePosition, 0, 0),
                Quaternion.identity) as GameObject;
            GO.transform.GetChild(1).transform.position = 
                new Vector2(GO.transform.GetChild(1).position.x, Random.Range(minMaxYValue.x, minMaxYValue.y));
        }
    }
}
