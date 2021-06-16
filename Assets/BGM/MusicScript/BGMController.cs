using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    static BGMController instance = null;
    private AudioSource _audioSource;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
            _audioSource = GetComponent<AudioSource>();
        }
    }
    
       

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }
    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
