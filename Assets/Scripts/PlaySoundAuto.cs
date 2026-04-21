using UnityEngine;

public class PlaySoundAuto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public AudioClip sound;

    void Start()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}