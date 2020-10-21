using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VrGazeTimer : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    float Timer;
    bool gazeStatus;
    private RaycastHit hit;
    public int distanceOfRay = 10; 
    // Update is called once per frame
    void Update()
    {
        if (gazeStatus)
        {
            Timer += Time.deltaTime;
            imgGaze.fillAmount = Timer/totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        if (Physics.Raycast(ray, out hit, distanceOfRay))
        {
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("Tutorial") && gazeStatus == true)
            {
                hit.transform.gameObject.GetComponent<LookRemove>().set();
                Timer = 0;
                imgGaze.fillAmount = 0;
                gazeStatus = false;
            }
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("Teleport") && gazeStatus==true)
            {
                hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
                Timer = 0;
                imgGaze.fillAmount = 0;
                gazeStatus = false;
            }
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("PlayVideo") && gazeStatus == true)
            {
                hit.transform.gameObject.GetComponent<ShootableUI>().ShotClick();
                Timer = 0;
          
                gazeStatus = false;
            }
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("NextVideo") && gazeStatus == true)
            {
                hit.transform.gameObject.GetComponent<ShootableUI>().ShotClick();
                Timer = 0;
                imgGaze.fillAmount = 0;
                gazeStatus = false;
            }
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("ShowList") && gazeStatus == true)
            {
                hit.transform.gameObject.GetComponent<ListPopUp>().Show();
                Timer = 0;

                gazeStatus = false;
            }

        }


    }

    public void GvrOn()
    {
        gazeStatus = true;
    }

    public void GvrOff()
    {
        gazeStatus = false;
        Timer = 0;
        imgGaze.fillAmount = 0;
    }
}
