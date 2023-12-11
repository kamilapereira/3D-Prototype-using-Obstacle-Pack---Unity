using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGmusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("bgmusic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
