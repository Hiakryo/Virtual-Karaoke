using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowList : MonoBehaviour
{
    public GameObject mainlist;

    public void setList()
    {
        mainlist.SetActive(true);
    }
}
