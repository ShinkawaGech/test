using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    public string FileName = "test";
    public MasterDataLoader testData = new MasterDataLoader();
    
    void Awake() {
        testData.CsvRead(FileName);
        Debug.Log("CSV:" + testData.csvDatas[1][1]);

        //for (int i = 0; i < testData.csvDatas.Count ; i++) {
        //    for (int j = 0; j < testData.csvDatas[i].Length; j++)
        //    {
        //        Debug.Log("CSV["+i+"]["+j+"] = " + testData.csvDatas[i][j]);
        //    }
        //}

        //Debug.Log("awake");

    }

    void Start () {
        SceneManager.LoadScene("background", LoadSceneMode.Additive);
        SceneManager.LoadScene("gimmick", LoadSceneMode.Additive);
        SceneManager.LoadScene("ui", LoadSceneMode.Additive);

    }

    void Update () {
    }

}
