using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour
{
    const int max = 512;
    private AudioSource audioSource;
    public float[] samples = new float[max];

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        GetSpectumAudioSource();
    }

    void GetSpectumAudioSource()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }
}
