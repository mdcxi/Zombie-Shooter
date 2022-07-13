using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_souns : MonoBehaviour
{
    [SerializeField]
    private AudioClip audioClip;

    [SerializeField]
    private AudioSource audioSource;

    void Start()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
