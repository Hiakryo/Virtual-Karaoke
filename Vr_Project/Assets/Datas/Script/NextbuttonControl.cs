using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextbuttonControl : ShootableUI
{
    public override void ShotClick ()
    {
        worldSpaceVideo.SetNextClip();
    }
}
