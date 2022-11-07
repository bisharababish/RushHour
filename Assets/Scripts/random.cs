using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    
    public GameObject[] enemyPrefabs; // enemies
    public Transform[] spawnPoints; // spawn points which is colored as red.
    public float startimespawn; // the seconds of the spawn,if its "2" means each 2 seconds it spawns the enemy character.
    private float timespawen;
    private int rand;
    private int rand2;
    // Start is called before the first frame update
    void Start()
    {
        timespawen = startimespawn;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timespawen <=0){
            // Enemy Character as a random spawn points.
            rand = Random.Range(0,enemyPrefabs.Length); 
            rand2 = Random.Range(0,spawnPoints.Length);  
            Instantiate(enemyPrefabs[rand], spawnPoints[rand2].transform.position, Quaternion.identity);
            timespawen= startimespawn;
        }
        else {
            timespawen = timespawen -   Time.deltaTime; // Time
        }
    }
}
