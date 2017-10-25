using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    //システムフラグ
    public static bool isDebug = false;         //デバッグモード
    public static bool isFirstPlay = false;     //初回プレイ
    public static bool isGameClear = false;     //ゲームクリア

    //プレイヤー情報
    public static string isRoom = "room_front";    //現在の場所
    public static string isProgress = "title";      //現在の進行度    

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
