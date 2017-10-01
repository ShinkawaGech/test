using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GimChest : MonoBehaviour {

    float sRot = 0.0f;
    float eRot = 90.0f;
    float cRot;
    float rot = 0.0f;
    float rotTime = 0.5f;
    bool chestOpen = false;

    private GameObject chestUp;

    void Start () {
        chestUp = transform.Find("Gim_Chest_Up").gameObject;
        Debug.Log(chestUp.name);
    }

    void Update () {
    }

    public void ChestRotate()
    {
        StartCoroutine("coRotate");
        Debug.Log("1");
    }

    IEnumerator coRotate() {
        if (chestOpen == false)
        {
            Debug.Log("2");

            for (rot = sRot; rot <= eRot; rot += cRot)
            {
                cRot = ((eRot - sRot) / rotTime) * Time.deltaTime;
                chestUp.transform.rotation = Quaternion.Euler(rot, 0.0f, 0.0f);
                yield return new WaitForSeconds(0);
            }
            chestOpen = true;
        }
        else {
            Debug.Log("2");

            chestOpen = false;
            rot = 0.0f;
            chestUp.transform.rotation = Quaternion.Euler(rot, 0.0f, 0.0f);
            yield return new WaitForSeconds(0);
        }


    }


}
