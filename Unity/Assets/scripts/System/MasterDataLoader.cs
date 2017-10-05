﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MasterDataLoader {

	//データ一時保管用リスト（あとで下に持ってく
	List<string>	strDatas = new List<string>();		//Dic用一時リスト(string)
	List<Transform>	trfDatas = new List<Transform>();	//Dic用一時リスト(Transform)


	//private List<GameObject>	myList		= new List<GameObject>();
	//GameObject newObj2 = myList[0]; //Listへのアクセス

	//private List<int>			intList		= new List<int>();    		//int型のリスト
	//private List<float>		floatList	= new List<float>();  		//float型のリスト
	//		  List<Vector3>		v3			= new List<Vector3>{new Vector3(0,0,0), new Vector3(1,1,1)};
	//		  List<Transform>	list		= new List<Transform>();
	

	void Awake(){

		//マスターデータ読み込み
		LoadData("FlagList");		//フラグ		A:string,bool
	//	LoadData("EventList");		//イベント		A:string,bool
	//	LoadData("GimmickList");	//ギミック		B:string,string
	//	LoadData("ItemList");		//アイテム		B:string,string
	//	LoadData("CutList");		//カット		C:string,list[string,string,string]
	//	LoadData("CameraList");		//カメラリスト	D:string,list[float,float,float, float,float,float]

	}

    public void LoadData(string fileName) {
    //public void LoadData(string fileName, int listType ) {

		//csv読み込み用
		List<string> csvDatas = new List<string>();

		//csvファイル読み込み
        TextAsset csvFile = Resources.Load("csv/" + fileName) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

		//データのリスト化
        while(reader.Peek() > -1){
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
        }

        //要素数取得
        int row = csvDatas.Count;
        //int col = csvDatas[0].Length;
        //Debug.Log("Lst :" + row + ":" + col);
		//要素数リスト(key,row,col)に入れる

        //csvデータのディクショナリ可
		//リストごとに個別処理
		
        //ConvertDictionary();
        //string dicName = fileName + "Dic"; 

		//Dictionary<string, List<StringBuilder>> stringToBuilderMap = new Dictionary<string, List<StringBuilder>>();
        //Dictionary<string, bool> dic = new Dictionary<string, bool>();


		switch(fileName){
			case "FlagList":
		        Dictionary<string, bool> FlagDic = new Dictionary<string, bool>();
				ConverDicTypeA(row);
				break;

			case "EventList":
		        Dictionary<string, bool> EventDic = new Dictionary<string, bool>();

        		for (int i = 0; i < row; i++) {
            		string key = csvDatas[i][0];
        		    bool value = bool.Parse(csvDatas[i][1]);
    		        dic.Add(key, value);
		        }

				break;

			case "GimmickList":
				break;

			case "ItemList":
				break;

			case "CutList":
				break;

			case "CameraList":
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
        dic["m01_kit_b"] = true;
        //Debug.Log("m01_kit_a : " + flg["m01_kit_a"]);
        //Debug.Log("m01_kit_b : " + flg["m01_kit_b"] + " <-Trueになる");
        //Debug.Log("m01_kit_c : " + flg["m01_kit_c"]);

        //リスト初期化
        //Debug.Log("クリア前" + csvDatas[0][0]);
        csvDatas.Clear();
        //Debug.Log("クリア後" + csvDatas[0][0]);
        //Debug.Log("Dic名" + dicName);
    }


	//TypeA string(key),bool
	void ConvertDicTypeA(int dRow){
       	for (int i = 0; i < row; i++) {
       		string key = csvDatas[i][0];
       	    bool value = bool.Parse(csvDatas[i][1]);
            dic.Add(key, value);
		}
        Debug.Log("コンバート！");
	}
	
	//TypeB string(key),string
	void ConvertDicTypeA(int dRow){
       	for (int i = 0; i < row; i++) {
       		string key = csvDatas[i][0];
       	    string value = csvDatas[i][1]);
            dic.Add(key, value);
		}
        Debug.Log("コンバート！");
	}


}
