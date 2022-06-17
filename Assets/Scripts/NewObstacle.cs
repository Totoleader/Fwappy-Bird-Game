using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector2 _screenBounds;
    public float respawnTime = 2.0f;
    
    // Start is called before the first frame update
    private void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ObstacleWave());
    }

    private void SpawnObstacle()
    {
        var a = Instantiate(obstaclePrefab);
        a.transform.position = new Vector2(_screenBounds.x + 2, Random.Range(-3f, 3f));
    }

    private IEnumerator ObstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnObstacle();
        }
        // ReSharper disable once IteratorNeverReturns
    }
    
}
