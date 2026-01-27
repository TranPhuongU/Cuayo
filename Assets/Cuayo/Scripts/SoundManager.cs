using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] AudioSource[] sfxSound;
    [SerializeField] AudioSource[] loseSound;

    private void Awake()
    {
        instance = this;
    }

    public void PlayRandomSound(AudioSource[] audioSource)
    {
        if (audioSource.Length == 0) return;
        int index = Random.Range(0, audioSource.Length);
        audioSource[index].Play();
    }

    public void PlayRandomSFX()
    {
        StopAllSounds();
        PlayRandomSound(sfxSound);
    }

    public void PlayRandomLoseSound()
    {
        StopAllSounds();
        PlayRandomSound(loseSound);
    }


    void StopAllSounds()
    {
        StopArray(sfxSound);
        StopArray(loseSound);
    }

    void StopArray(AudioSource[] sources)
    {
        foreach (var src in sources)
        {
            if (src != null && src.isPlaying)
                src.Stop();
        }
    }

}
