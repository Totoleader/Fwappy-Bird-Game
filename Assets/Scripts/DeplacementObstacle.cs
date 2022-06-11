using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementObstacle : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public int obstacleSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-obstacleSpeed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame

    void Update()
    {
        if (transform.position.x < -screenBounds.x -2)
        {
            Destroy(this.gameObject);
        }

    }
}

    
    

