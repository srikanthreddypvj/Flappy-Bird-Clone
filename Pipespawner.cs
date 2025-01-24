using UnityEngine;
public class PipeSpawner : MonoBehaviour
{
   public GameObject pipePrefab;
   public float spawnRate = 2f;
   public float heightOffset = 1f;
   void Start()
   {
       InvokeRepeating("SpawnPipe", 0f, spawnRate);
   }
   void SpawnPipe()
   {
       float randomHeight = Random.Range(-heightOffset, heightOffset);
       Instantiate(pipePrefab, new Vector3(5, randomHeight, 0), Quaternion.identity);
   }
}
