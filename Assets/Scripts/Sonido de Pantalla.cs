using UnityEngine;

public class SonidoDePantalla : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip music;

    private void Start() 
    {
        audioSource.clip = music; 
        audioSource.Play(); 
    }
}