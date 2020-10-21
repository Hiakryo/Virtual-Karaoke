using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour
{
    public Material playButtonMaterial;
    public Material pauseButtonMaterial;
    public Renderer playButtonRenderer;
    public VideoClip[] videoClips;

    private VideoPlayer videoPlayer;
    private int videoClipIndex=-1;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void SetNextClip()
    {
       videoClipIndex++;
        if(videoClipIndex >= videoClips.Length)
        {
            videoClipIndex = videoClipIndex % videoClips.Length;
        }
        videoPlayer.clip = videoClips[videoClipIndex];
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    public void RestartClip()
    {
        
        videoPlayer.clip = videoClips[videoClipIndex];
        videoPlayer.Stop();
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    public void Song1()
    {
        videoClipIndex = 0;
        videoPlayer.clip = videoClips[videoClipIndex];
        videoPlayer.Stop();
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    public void Song2()
    {
        videoClipIndex = 1;
        videoPlayer.clip = videoClips[videoClipIndex];
        videoPlayer.Stop();
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    public void Song3()
    {
        videoClipIndex = 2;
        videoPlayer.clip = videoClips[videoClipIndex];
        videoPlayer.Stop();
        videoPlayer.Prepare();
        videoPlayer.Play();
    }
    public void PlayPause()
    {
        if(videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playButtonRenderer.material = playButtonMaterial;
        }
        else
        {
            videoPlayer.Play();
            playButtonRenderer.material = pauseButtonMaterial;
        }
    }
    public void PauseVid()
    {
        videoPlayer.Stop();
    }
}
