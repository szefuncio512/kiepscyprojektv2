using System.Collections.Specialized;

private IEnumerator coroutine;




   

void Start()
{

    {
        SpawnObstacle(startPosition);
        coroutine = WaitToSpawn(1f);
        StartCoroutine(coroutine);
    }

    void Update()


    void SpawnObstacle(BitVector32 lastobjPosition)

    IEnumerator WaitToSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waiTime);
            SpawnObstacle(obstaclesOnMap[obstaclesOnMap.Count - 1].transform.position);
            {
                Destroy(obstaclesOnMap[0]);
                obstaclesOnMap.Remove(obstaclesOnMap[0]);
            }



        }




    }
}

