using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    private void Awake() {
        Debug.Log("awake");

        //SceneManager.LoadScene("test", LoadSceneMode.Single);
        SceneManager.LoadScene("background", LoadSceneMode.Additive);
        SceneManager.LoadScene("gimmick", LoadSceneMode.Additive);
        SceneManager.LoadScene("ui", LoadSceneMode.Additive);

    }

    void Start () {
        Debug.Log("play");


    }

    // Update is called once per frame
    void Update () {
        Debug.Log("update");
    }


}
