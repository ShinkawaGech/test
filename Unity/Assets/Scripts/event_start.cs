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

        if (eventName == "chest")
        {
            Debug.Log("event : " + eventName);
            chest che = GetComponent<chest>();
            che.ChestRotate();
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
