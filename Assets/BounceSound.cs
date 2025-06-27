using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    AudioSource audioPlayer;
    public AudioClip bounceFX;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

   void OnCollisionEnter(Collision col){
    audioPlayer.PlayOneShot(bounceFX, 1f);
   }
}
