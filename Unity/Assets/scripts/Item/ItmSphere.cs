using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmSphere : MonoBehaviour {

    private GameObject sphere;

    void Start () {
        sphere = transform.Find("Sphere").gameObject;

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void GetSpere() {
        Debug.Log("getだぜ！");
    }

}
