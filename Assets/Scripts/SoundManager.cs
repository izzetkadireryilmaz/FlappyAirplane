using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource skyscraperSource;
    public AudioClip CrashSound;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    void Update()
    {
        
    }
}
