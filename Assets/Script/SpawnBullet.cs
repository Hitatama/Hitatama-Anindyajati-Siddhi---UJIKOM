using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject spawnBullet;
    public Transform spawnPoint;
    public float lifeTime = 3f;
    public AudioClip impact;
    /*AudioSource audioSource;*/


    // Start is called before the first frame update
    void Start()
    {
        /*audioSource = GetComponent<AudioSource>(); */ 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            /*audioSource.PlayOneShot(impact);*/
            Spawn();    
        }


    }


    void Spawn()
    {
        GameObject spawnObject = Instantiate(spawnBullet, spawnPoint.position, spawnPoint.rotation);

        Destroy(spawnObject, lifeTime);
    }
}
