using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song1Control : ShootableUI
{
    public GameObject ListPlane;
    public override void ShotClick()
    {
        worldSpaceVideo.Song1();
        ListPlane.SetActive(false);
    }
}
