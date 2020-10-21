using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseList : MonoBehaviour
{
    public GameObject ListPlane;
    public void Close()
    {
        ListPlane.SetActive(false);
    }
}
