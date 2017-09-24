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

    }

    void Start () {
        //Awakeだと上手く動かないらしい
        SceneManager.LoadScene("background", LoadSceneMode.Additive);
        SceneManager.LoadScene("gimmick", LoadSceneMode.Additive);
        SceneManager.LoadScene("ui", LoadSceneMode.Additive);

    }

    void Update () {
    }

}
