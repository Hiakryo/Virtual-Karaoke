using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song2Control : ShootableUI
{
    public GameObject ListPlane;
    public override void ShotClick()
    {
        worldSpaceVideo.Song2();
        ListPlane.SetActive(false);
    }
}
