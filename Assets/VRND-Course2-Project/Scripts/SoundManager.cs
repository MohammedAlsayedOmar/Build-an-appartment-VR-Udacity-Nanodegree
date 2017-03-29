using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    //The code is written by me, Mohammed Omar but the audio sources were downloaded from "http://soundbible.com/tags-city.html"

    public Vector2 minMaxRandomTime;

    AudioSource[] audioSources;
    int audioSourceLength;


    void Start () {
        audioSources = GetComponents<AudioSource>();
        StartCoroutine(ChooseRandomTrack(Random.Range(minMaxRandomTime.x, minMaxRandomTime.y)));

        audioSourceLength = audioSources.Length;
    }

    IEnumerator ChooseRandomTrack(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        int randomIndex = Random.Range(0, audioSourceLength);
        if (!audioSources[randomIndex].isPlaying)
            audioSources[randomIndex].Play();

        StartCoroutine(ChooseRandomTrack(Random.Range(minMaxRandomTime.x, minMaxRandomTime.y)));
    }
}
