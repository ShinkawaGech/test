﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    public MasterDataLoader MstData = new MasterDataLoader();

    public bool isDebug;

    void Awake() {
        //マスターデータ読み込み
        MstData.CsvRead("FlagList");
        //MstData.CsvRead("CameraSet");
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
