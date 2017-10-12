using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MasterDataLoader : MonoBehaviour {

    //csv読み込み用
    public List<string[]> csvDatas = new List<string[]>();

    //private List<GameObject>	myList		= new List<GameObject>();
    //GameObject newObj2 = myList[0]; //Listへのアクセス

    //private List<int>			intList		= new List<int>();    		//int型のリスト
    //private List<float>		floatList	= new List<float>();  		//float型のリスト
    //		  List<Vector3>		v3			= new List<Vector3>{new Vector3(0,0,0), new Vector3(1,1,1)};
    //		  List<Transform>	list		= new List<Transform>();


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

                Debug.Log(fileName + " : " + FlagDic.Count + "件、読込完了！");
                break;

            //A: string,bool
            case "EventList":
		        Dictionary<string, bool> EventDic = new Dictionary<string, bool>();
        		for (int i = 0; i < row; i++)
                {
            		string key = csvDatas[i][0];
        		    bool value = bool.Parse(csvDatas[i][1]);
    		        EventDic.Add(key, value);

                    //Debug.Log("Dic[value] : " + EventDic[csvDatas[i][0]]);
                }

                Debug.Log(fileName + " : " + EventDic.Count + "件、読込完了！");
                break;

            //B: string,string
            case "GimmickList":
                Dictionary<string, string> GimmickDic = new Dictionary<string, string>();
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];
                    string value = csvDatas[i][1];
                    GimmickDic.Add(key, value);

                    //Debug.Log("Dic[value] : " + GimmickDic[csvDatas[i][0]]);
                }

                Debug.Log(fileName + " : " + row + "件、読込完了！");
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

                Debug.Log(fileName + " : " + ItemDic.Count + "件、読込完了！");
                break;

            //C: string,list<string[3]>
            case "CutList":
                Dictionary<string, List<string[]>> CutDic = new Dictionary<string, List<string[]>>();

                for (int i = 0; i < row; i++)
                {
                    //毎回newする事で別のリストになる
                    List<string[]> cutDatas = new List<string[]>();
                    string[] array = new string[3];

                    string key = csvDatas[i][0];

                    array[0] = csvDatas[i][1];
                    array[1] = csvDatas[i][2];
                    array[2] = csvDatas[i][3];
                    cutDatas.Add(array);

                    CutDic.Add(key, cutDatas);

                    //専用リストなので消さない。
                    //cutDatas.Clear();
                }

                //[key][0固定][0:L,1:R,2:B]
                //Debug.Log(CutDic["room_front"][0][0]);
                Debug.Log(fileName + " : " + CutDic.Count + "件、読込完了！");
                break;

            //C: string,float[]
            case "CameraList":
                //Dictionary<string, List<StringBuilder>> stringToBuilderMap = new Dictionary<string, List<StringBuilder>>();
                //Dictionary<string, string[]> CutList = new Dictionary<string, strinList<string>>();


                Debug.Log("カメラリスト");

                break;

			default:
				Debug.Log("Listが見つからない");
				break;
		}





        //デバッグ：参照
        //foreach (KeyValuePair<string, bool> pair in flg) {
        //Debug.Log(pair.Key + " : " + pair.Value);
        //}
        //Debug.Log("m01_kit_a : " + flg["m01_kit_a"]);
        //Debug.Log("m01_kit_b : " + flg["m01_kit_b"]);
        //Debug.Log("m01_kit_c : " + flg["m01_kit_c"]);

        //デバッグ：書き込み
        //dic["m01_kit_b"] = true;
        //Debug.Log("m01_kit_a : " + flg["m01_kit_a"]);
        //Debug.Log("m01_kit_b : " + flg["m01_kit_b"] + " <-Trueになる");
        //Debug.Log("m01_kit_c : " + flg["m01_kit_c"]);

        //リスト初期化
        //Debug.Log("クリア前" + csvDatas[0][0]);
        csvDatas.Clear();
        //Debug.Log("クリア後" + csvDatas[0][0]);
        //Debug.Log("Dic名" + dicName);
    }


}
