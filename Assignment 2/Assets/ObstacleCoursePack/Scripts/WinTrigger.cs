using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject flagPrefab; //the prefab tap to be instantiated
    public Transform flagPos; //where we want the trap to appear in level
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You win!"); //send message to console for us
            FindObjectOfType<AudioManager>().Play("win");
            Instantiate(flagPrefab, flagPos); //create trap at custom position
            Destroy(gameObject);
        }
    
    }
}
