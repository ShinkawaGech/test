using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MasterDataLoader : MonoBehaviour {

    //csv読み込み用
    public List<string[]> csvDatas = new List<string[]>();

    void Awake(){

		//マスターデータ読み込み
		LoadData("FlagList");		//フラグ		    A:string,bool
		LoadData("EventList");		//イベント		A:string,bool
		LoadData("GimmickList");	//ギミック		B:string,string
		LoadData("ItemList");		//アイテム	    B:string,string
		LoadData("CutList");		//カット	    	C:string,list[string[3]]
		LoadData("CameraList");		//カメラリスト	D:string,list[float[6]]

	}

    public void LoadData(string fileName) {

        //csvファイル読み込み
        TextAsset csvFile = Resources.Load("csv/" + fileName) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        //コメント行なら無視する
        //string strCheck = "#コメント行";
        //if (strCheck.StartsWith("#")) {
        //    Debug.Log(strCheck +" は、コメント行！");
        //}

		//データのリスト化
        while(reader.Peek() > -1){
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
        }

        //要素数取得
        int row = csvDatas.Count;
        int col = csvDatas[0].Length;

		//要素数リスト(key,row,col)に入れる

		switch(fileName){
            //A: string,bool
 			case "FlagList":
                Dictionary<string, bool> FlagDic = new Dictionary<string, bool>();
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];
                    bool value = bool.Parse(csvDatas[i][1]);
                    FlagDic.Add(key, value);

                    //Debug.Log("Dic[value] : " + FlagDic[csvDatas[i][0]]);
                }

                Debug.Log("読込完了！　" + fileName + " : " + FlagDic.Count + " 件");
                break;

            //A: string,bool
            case "EventList":
		        Dictionary<string, bool> EveDic = new Dictionary<string, bool>();
        		for (int i = 0; i < row; i++)
                {
            		string key = csvDatas[i][0];
        		    bool value = bool.Parse(csvDatas[i][1]);
    		        EveDic.Add(key, value);

                    //Debug.Log("Dic[value] : " + EventDic[csvDatas[i][0]]);
                }

                Debug.Log("読込完了！　" + fileName + " : " + EveDic.Count + " 件");
                break;

            //B: string,string
            case "GimmickList":
                Dictionary<string, string> GimDic = new Dictionary<string, string>();
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];
                    string value = csvDatas[i][1];
                    GimDic.Add(key, value);

                    //Debug.Log("Dic[value] : " + GimmickDic[csvDatas[i][0]]);
                }

                Debug.Log("読込完了！　" + fileName + " : " + GimDic.Count + " 件");
                break;

            //B: string,string
            case "ItemList":
                Dictionary<string, string> ItemDic = new Dictionary<string, string>();
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];
                    string value = csvDatas[i][1];
                    ItemDic.Add(key, value);

                    //Debug.Log("Dic[value] : " + ItemDic[csvDatas[i][0]]);
                }

                Debug.Log("読込完了！　" + fileName + " : " + ItemDic.Count + " 件");
                break;

            //C: string,list<string[3]>
            case "CutList":
                Dictionary<string, List<string[]>> CutDic = new Dictionary<string, List<string[]>>();

                for (int i = 0; i < row; i++)
                {
                    //毎回newする事で別のリストになる
                    List<string[]> cutDatas = new List<string[]>();
                    string[] cutArray = new string[3];

                    string key = csvDatas[i][0];

                    cutArray[0] = csvDatas[i][1];
                    cutArray[1] = csvDatas[i][2];
                    cutArray[2] = csvDatas[i][3];
                    cutDatas.Add(cutArray);

                    CutDic.Add(key, cutDatas);

                    //専用リストなので消さない。
                    //cutDatas.Clear();
                }

                //[key][0固定][0:L,1:R,2:B]
                //Debug.Log(CutDic["room_front"][0][0]);
                Debug.Log("読込完了！　" + fileName + " : " + CutDic.Count + " 件");
                break;

            //C: string,list<float[6]>
            case "CameraList":
                Dictionary<string, List<float[]>> CamDic = new Dictionary<string, List<float[]>>();

                for (int i = 0; i < row; i++)
                {
                    //毎回newする事で別のリストになる
                    List<float[]> camDatas = new List<float[]>();
                    float[] camArray = new float[6];

                    string key = csvDatas[i][0];

                    camArray[0] = float.Parse(csvDatas[i][1]);
                    camArray[1] = float.Parse(csvDatas[i][2]);
                    camArray[2] = float.Parse(csvDatas[i][3]);
                    camArray[3] = float.Parse(csvDatas[i][4]);
                    camArray[4] = float.Parse(csvDatas[i][5]);
                    camArray[5] = float.Parse(csvDatas[i][6]);
                    camDatas.Add(camArray);

                    CamDic.Add(key, camDatas);

                    //専用リストなので消さない。
                    //camDatas.Clear();
                }

                //[key][0固定][0:posX,1:posY,2:posZ, 3:rotX,4:rotY,5:rotZ]
                //Debug.Log(CamDic["room_front"][0][0]);
                Debug.Log("読込完了！　" + fileName + " : " + CamDic.Count + " 件");
                break;

			default:
				Debug.Log("Listが見つからない");
				break;
		}

        //リスト初期化
        csvDatas.Clear();
    }

}
