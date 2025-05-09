using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject MusicHandle;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        MusicHandle.transform.position = new Vector3(Mathf.Clamp(MusicHandle.transform.position.x, -1.0f, 0.8f), Mathf.Clamp(MusicHandle.transform.position.y, -0.1f, -0.1f), Mathf.Clamp(MusicHandle.transform.position.z, 2.8f, 2.8f));
        
        if(MusicHandle.transform.position.x <= -0.9f)
        {
            audioSource.GetComponent<AudioSource>().volume = 0f;
        }
        if (MusicHandle.transform.position.x >= -0.9f && MusicHandle.transform.position.x <= 0)
        {
            audioSource.GetComponent<AudioSource>().volume = 0.2f;
        }
        if (MusicHandle.transform.position.x >= 0 && MusicHandle.transform.position.x <= 0.4f)
        {
            audioSource.GetComponent<AudioSource>().volume = 0.5f;
        }
        if (MusicHandle.transform.position.x >= 0.4f && MusicHandle.transform.position.x <= 0.8f)
        {
            audioSource.GetComponent<AudioSource>().volume = 1f;
        }
    }
}
