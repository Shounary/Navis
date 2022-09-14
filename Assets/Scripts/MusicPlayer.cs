using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource[] musicTrack;

    private int currentTrack = 0;

    private void OnDisable()
    {
        if (musicTrack[currentTrack] != null)
            musicTrack[currentTrack].Stop();

        currentTrack = 0;
    }

    public void RightClick()
    {
        if (musicTrack[currentTrack] != null)
            musicTrack[currentTrack].Stop();

        currentTrack++;
        if (currentTrack > musicTrack.Length - 1)
            currentTrack = 0;

        if (musicTrack[currentTrack] != null)
            musicTrack[currentTrack].Play();

    }

    public void LeftClick()
    {
        if (musicTrack[currentTrack] != null)
            musicTrack[currentTrack].Stop();

        currentTrack--;
        if (currentTrack < 0)
            currentTrack = musicTrack.Length - 1;

        if (musicTrack[currentTrack] != null)
            musicTrack[currentTrack].Play();
    }
}
