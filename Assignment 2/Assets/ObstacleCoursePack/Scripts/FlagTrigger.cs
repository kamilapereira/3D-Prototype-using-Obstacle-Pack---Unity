using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
    public GameObject flagPrefab; //the prefab tap to be instantiated
    public Transform flagPos; //where we want the trap to appear in level
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Flag is triggered! Check Point."); //send message to console for us
            FindObjectOfType<AudioManager>().Play("checkpoint");
            Instantiate(flagPrefab, flagPos); //create trap at custom position
            Destroy(gameObject);
        }
    
    }
}
