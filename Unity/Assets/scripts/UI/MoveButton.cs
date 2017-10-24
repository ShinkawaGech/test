using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PushMoveL () {
        Debug.Log("ひだり！");
    }

    public void PushMoveR () {
        Debug.Log("みぎ！");
    }

    public void PushMoveUp (){
        Debug.Log("うえ！");
    }

    public void PushMoveBack () {
        Debug.Log("もどる！");
    }

}
