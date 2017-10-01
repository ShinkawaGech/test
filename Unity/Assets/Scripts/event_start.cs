using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event_start : MonoBehaviour {

    public string eventName;

	void Start () {
	}


    void Update () {
    }


    public void eventStart()
    {

        //Debug.Log("click");

        if (eventName == "Gim_Chest")
        {
            Debug.Log("event : " + eventName);
            //chestが取得できていない
            GimChest chest = GameObject.Find("Gim_Chest").GetComponent<GimChest>();
            chest.ChestRotate();
            //Debug.Log("GimChest : "+chest.name);
        }
        else if (eventName == "test")
        {
            Debug.Log("event : " + eventName);
        }
        else {
            Debug.Log("etc...");
        }

    }


}
