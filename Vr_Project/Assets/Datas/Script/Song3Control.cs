using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song3Control : ShootableUI
{
    public GameObject ListPlane;
    public override void ShotClick()
    {
        worldSpaceVideo.Song3();
        ListPlane.SetActive(false);
    }
}
