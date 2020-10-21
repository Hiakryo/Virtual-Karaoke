using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButtonControl : ShootableUI
{
    public override void ShotClick()
    {
        worldSpaceVideo.RestartClip();
    }
}
