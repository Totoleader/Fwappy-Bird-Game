using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_CheckPoint : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D targetObj)
    {

        if (targetObj.gameObject.CompareTag("Player"))
        {
            
            GetComponent<AudioSource>().Play(0);
        
        }
    }
    
}
