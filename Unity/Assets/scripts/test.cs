using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    public bool isDebug = false;

    void Awake() {
    }

    void Start () {
        //Awakeだと上手く動かないらしい
        if (!isDebug) {
            SceneManager.LoadScene("background", LoadSceneMode.Additive);
            SceneManager.LoadScene("gimmick", LoadSceneMode.Additive);
            SceneManager.LoadScene("ui", LoadSceneMode.Additive);
        }

    }

    void Update () {
    }

}
