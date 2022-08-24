using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public float fadeOutDuration = 0.001f;
    private float minVolume = 0f;
    private float maxVolume = 3f;

    private IEnumerator fadeOut;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            maxVolume = s.source.volume;
            
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void FadeOutSound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        fadeOut = FadeOut(s.source, fadeOutDuration, minVolume);
        if (s.source.isPlaying)
        {
            StartCoroutine(fadeOut);
        }
    }

    public void SetNormalVolume(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.volume = 3f;
    }

    IEnumerator FadeOut(AudioSource aSource, float duration, float targetVolume)
    {
        float timer = 0f;
        float currentVolume = aSource.volume;
        float targetValue = Mathf.Clamp(targetVolume, minVolume, maxVolume);

        while (aSource.volume > 0)
        {
            timer += Time.deltaTime;
            var newVolume = Mathf.Lerp(currentVolume, targetValue, timer/duration);
            aSource.volume = newVolume;
            yield return null;
        }
    }
}
