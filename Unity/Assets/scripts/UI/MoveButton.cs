using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour {

    //ボタンコンポーネント
    public Button[] mBtn;

    void Awake() {
    }

    void Start () {
        //AwakeでマスターデータをロードしているのでStartでやる
        //コンポーネント取得
        mBtn = new Button[4];
        mBtn[0] = GameObject.Find("Button_L").GetComponent<Button>();
        mBtn[1] = GameObject.Find("Button_R").GetComponent<Button>();
        mBtn[2] = GameObject.Find("Button_Up").GetComponent<Button>();
        mBtn[3] = GameObject.Find("Button_Back").GetComponent<Button>();

        //初期ボタンの有無チェック
        checkButtton();
        //for (int i = 0; i < 4; i++) {
        //    if (MasterDataLoader.CutDic[test.isRoom][0][i] == "none") {
        //        mBtn[i].interactable = false;
        //    }
        //}

        //Debug.Log("部屋 : " + test.isRoom);
        //Debug.Log("ひだり : " + MasterDataLoader.CutDic[test.isRoom][0][0]);
        //Debug.Log("みぎ　 : " + MasterDataLoader.CutDic[test.isRoom][0][1]);
        //Debug.Log("うえ　 : " + MasterDataLoader.CutDic[test.isRoom][0][2]);
        //Debug.Log("戻る　 : " + MasterDataLoader.CutDic[test.isRoom][0][3]);

    }
    
    void Update () {
    }

    void checkButtton() {
        for (int i = 0; i < 4; i++)
        {
            if (MasterDataLoader.CutDic[test.isRoom][0][i] == "none")
            {
                //ボタン非表示
                mBtn[i].interactable = false;
                //Debug.Log(mBtn[i] + " : false");

            } else{
                //ボタン表示
                mBtn[i].interactable = true;
                //Debug.Log(mBtn[i] + " : true");
            }
        }
    }

    //左ボタン
    public void PushMoveL () {
        //Debug.Log("ひだり！");

        //noneの時は非表示
        //if (MasterDataLoader.CutDic[test.isRoom][0][0] == "none") {
        //        Debug.Log("左ボタンなし！");
        //    return;
        //}
        //else {
        //    Debug.Log("左ボタンあり！");
        //}

        //現在地を更新
        test.isRoom = MasterDataLoader.CutDic[test.isRoom][0][0];
        checkButtton();

        Debug.Log("部屋 : " + test.isRoom);

        //カメラ移動
    }

    //右ボタン
    public void PushMoveR () {
        //Debug.Log("みぎ！");

        //noneの時は非表示
        //if (MasterDataLoader.CutDic[test.isRoom][0][1] == "none") {
        //    Debug.Log("右ボタンなし！");
        //    return;
        //} else {
        //    Debug.Log("右ボタンあり！");
        //}

        //現在地を更新
        test.isRoom = MasterDataLoader.CutDic[test.isRoom][0][1];
        checkButtton();

        Debug.Log("部屋 : " + test.isRoom);

        //カメラ移動
    }

    //上ボタン
    public void PushMoveUp (){
        //Debug.Log("うえ！");

        //noneの時は非表示
        //if (MasterDataLoader.CutDic[test.isRoom][0][2] == "none") {
        //    Debug.Log("上ボタンなし！");
        //    return;
        //} else {
        //    Debug.Log("上ボタンあり！");
        //}

        //現在地を更新
        test.isRoom = MasterDataLoader.CutDic[test.isRoom][0][2];
        checkButtton();

        Debug.Log("部屋 : " + test.isRoom);

        //カメラ移動
    }

    //戻るボタン
    public void PushMoveBack () {
        //Debug.Log("もどる！");

        //noneの時は非表示
        //if (MasterDataLoader.CutDic[test.isRoom][0][3] == "none") {
        //    Debug.Log("戻るボタンなし！");
        //    return;
        //}
        //else {
        //    Debug.Log("戻るボタンあり！");
        //}

        //現在地を更新
        test.isRoom = MasterDataLoader.CutDic[test.isRoom][0][3];
        checkButtton();

        Debug.Log("部屋 : " + test.isRoom);

        //カメラ移動
    }

}
