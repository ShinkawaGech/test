using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {

    //カメラ位置設定
    //ディクショナリ形式にする
    public Vector3 pos;
    public Vector3 rot;

    void Start () {
        //csv読み込み
        //TextAsset csvFile = Resources.Load("csv/" + file) as TextAsset;
        //StringReader reader = new StringReader(csvFile.text);
        //
        //while (reader.Peek() > -1)
        //{
        //    string line = reader.ReadLine();
        //    csvDatas.Add(line.Split(','));
        //}

        Dictionary<string, Vector3> camPos = new Dictionary<string, Vector3>();
        camPos.Add("liv_front", pos = new Vector3(0.0f, 3.0f, -3.0f));
        camPos.Add("liv_front_chest", pos = new Vector3(0.0f, 4.0f, -6.0f));

        Dictionary<string, Vector3> camRot = new Dictionary<string, Vector3>();
        camRot.Add("liv_front", rot = new Vector3(20.0f, 0.0f, 0.0f));
        camRot.Add("liv_front_chest", rot = new Vector3(25.0f, 0.0f, 0.0f));
        //Debug.Log(camRot["liv_front"]);
        //ebug.Log(camRot["liv_front_chest"]);

        //カメラ移動値反映
        CameraMove(pos,rot);
    }

    void Update () {
		
	}

    void CameraMove(Vector3 posM, Vector3 rotM) {
        Vector3 posSet = transform.position;
        posSet.x = posM.x;
        posSet.y = posM.y;
        posSet.z = posM.z;
        transform.position = posSet;
        Debug.Log("posSet : " + posSet.x + " : " + posSet.y + " : " + posSet.z);

    }


}
