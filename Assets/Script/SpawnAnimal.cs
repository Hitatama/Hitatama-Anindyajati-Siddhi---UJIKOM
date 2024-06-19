using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VR;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject spawnAnimal;

    int instanceNumber = 1;

    public float lifeTime = 6f;

    public Vector3 maxArea;
    public Vector3 minArea;

    public float nextSpawn;

    public float minspawn = 1f;
    public float maxSpawn = 5f;

    



    // Start is called before the first frame update
    void Start()
    {
        SpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            SpawnEntities();
            SpawnTime();
        }
        
        
    }

    void SpawnEntities()
    {


        Vector3 RandomPosition = new Vector3(
            Random.Range(maxArea.x, minArea.x),
            Random.Range(maxArea.y, minArea.y),
            Random.Range(maxArea.z, minArea.z));

        GameObject spawnObject = Instantiate(spawnAnimal, RandomPosition, Quaternion.identity);

        Destroy(spawnObject, lifeTime); ;

    }

    void SpawnTime()
    {
        nextSpawn = Time.time + Random.Range(minspawn, maxSpawn);
    }
}
