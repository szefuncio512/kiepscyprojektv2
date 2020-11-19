using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject obstacleObj;
    List<GameObject> obstaclesOnMap = new List<GameObject>();
    void Start()
    {
        SpawnObstacle(new Vector3(0f, 0.4f, 20f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnObstacle(obstaclesOnMap[obstaclesOnMap.Count - 1].transform.position);
        }
    }

    void SpawnObstacle(Vector3 lastObjPosition)
    {
        Vector3 spawnPosition = new Vector3(((int)Random.Range(-1.9f, 1.9f) * 3), lastObjPosition.y, lastObjPosition.z + 10);
        obstaclesOnMap.Add(Instantiate(obstacleObj, spawnPosition, Quaternion.Euler(0, 0, 0)));
    }
}
