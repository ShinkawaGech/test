using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    public string FileName = "FlagList";
    public MasterDataLoader flagData = new MasterDataLoader();



    void Awake() {
        //フラグデータ読み込み
        flagData.CsvRead(FileName);

        //List[行][列] 0列のデータ(ラベル）のみ
        //Debug.Log("Csv : " + flagData.csvDatas[0][0]);
        //Debug.Log("Csv : " + flagData.csvDatas[1][0]);
        //Debug.Log("Csv : " + flagData.csvDatas[82][0]);

        //デバッグ
        //for (int i = 0; i < flagData.csvDatas.Count ; i++) {
        //    for (int j = 0; j < flagData.csvDatas[i].Length; j++)
        //    {
        //        Debug.Log("Csv : ["+i+"]["+j+"] = " + flagData.csvDatas[i][j]);
        //    }
        //}

        //Debug.Log("awake");

     

    }

    void Start () {
        SceneManager.LoadScene("background", LoadSceneMode.Additive);
        SceneManager.LoadScene("gimmick", LoadSceneMode.Additive);
        SceneManager.LoadScene("ui", LoadSceneMode.Additive);

        string str = "true";
        bool a = bool.Parse(str);
        //Debug.Log(a);   
    }

    void Update () {
    }

}
