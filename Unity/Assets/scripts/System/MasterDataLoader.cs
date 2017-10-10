using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MasterDataLoader : MonoBehaviour {

    //データ一時保管用リスト（あとで下に持ってく
    //List<string[]>	strDatas = new List<string[]>();		//Dic用一時リスト(string)
    //List<Transform[]>	trfDatas = new List<Transform[]>();   //Dic用一時リスト(Transform)

    //csv読み込み用
    public List<string[]> csvDatas = new List<string[]>();
    public List<string> cutDatas = new List<string>();

    //private List<GameObject>	myList		= new List<GameObject>();
    //GameObject newObj2 = myList[0]; //Listへのアクセス

    //private List<int>			intList		= new List<int>();    		//int型のリスト
    //private List<float>		floatList	= new List<float>();  		//float型のリスト
    //		  List<Vector3>		v3			= new List<Vector3>{new Vector3(0,0,0), new Vector3(1,1,1)};
    //		  List<Transform>	list		= new List<Transform>();


    void Awake(){

		//マスターデータ読み込み
	//	LoadData("FlagList");		//フラグ		A:string,bool
	//	LoadData("EventList");		//イベント		A:string,bool
	//	LoadData("GimmickList");	//ギミック		B:string,string
	//	LoadData("ItemList");		//アイテム		B:string,string
		LoadData("CutList");		//カット		C:string,list[string,string,string]
	//	LoadData("CameraList");		//カメラリスト	D:string,list[float,float,float, float,float,float]

	}

    public void LoadData(string fileName) {
        //public void LoadData(string fileName, int listType ) {

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

        //csvデータのディクショナリ可
		//リストごとに個別処理
		
        //ConvertDictionary();
        //string dicName = fileName + "Dic"; 

		//Dictionary<string, List<StringBuilder>> stringToBuilderMap = new Dictionary<string, List<StringBuilder>>();
        //Dictionary<string, bool> dic = new Dictionary<string, bool>();


		switch(fileName){
            //A: string,bool
 			case "FlagList":
                Dictionary<string, bool> FlagDic = new Dictionary<string, bool>();
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];
                    bool value = bool.Parse(csvDatas[i][1]);
                    FlagDic.Add(key, value);

                    //Debug.Log(fileName + " : " + row + " : " + col);
                    //Debug.Log("List : " + csvDatas[i][0] + " : " + csvDatas[i][1]);
                    //Debug.Log("Dic[value] : " + FlagDic[csvDatas[i][0]]);
                }
                Debug.Log(fileName + " : " + row + "件、読込完了！");
                break;

            //A: string,bool
            case "EventList":
		        Dictionary<string, bool> EventDic = new Dictionary<string, bool>();
        		for (int i = 0; i < row; i++)
                {
            		string key = csvDatas[i][0];
        		    bool value = bool.Parse(csvDatas[i][1]);
    		        EventDic.Add(key, value);

                    //Debug.Log(fileName + " : " + row + " : " + col);
                    //Debug.Log("List : " + csvDatas[i][0] + " : " + csvDatas[i][1]);
                    //Debug.Log("Dic[value] : " + EventDic[csvDatas[i][0]]);
                }
                Debug.Log(fileName + " : " + row + "件、読込完了！");
                break;

            //B: string,string
            case "GimmickList":
                Dictionary<string, string> GimmickDic = new Dictionary<string, string>();
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];
                    string value = csvDatas[i][1];
                    GimmickDic.Add(key, value);

                    //Debug.Log(fileName + " : " + row + " : " + col);
                    //Debug.Log("List : " + csvDatas[i][0] + " : " + csvDatas[i][1]);
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

                    //Debug.Log(fileName + " : " + row + " : " + col);
                    //Debug.Log("List : " + csvDatas[i][0] + " : " + csvDatas[i][1]);
                    //Debug.Log("Dic[value] : " + ItemDic[csvDatas[i][0]]);
                }
                Debug.Log(fileName + " : " + row + "件、読込完了！");
                break;

            //C: string,list<string>
            case "CutList":
                Dictionary<string, List<string>> CutDic = new Dictionary<string, List<string>>();
                //Dictionary<string, string[]> CutDic = new Dictionary<string, string[]>();
                //Dictionary<string, Transform> CutDic = new Dictionary<string, Transform>();
                //Dictionary<string, GameObject> CutDic = new Dictionary<string, GameObject>();

                //List<Transform> list = new List<Transform>();
                //List<string> list = new List<string>();

                string turnL, turnR, turnB;
                
                for (int i = 0; i < row; i++)
                {
                    string key = csvDatas[i][0];

                    turnL = csvDatas[i][1];
                    turnR = csvDatas[i][2];
                    turnB = csvDatas[i][3];

                    cutDatas.Add(turnL);
                    cutDatas.Add(turnR);
                    cutDatas.Add(turnB);
                    Debug.Log("L,R,B : " + key + " : " + cutDatas[0] + " : " + cutDatas[1] + " : " + cutDatas[2]);

                    //cutDatasをvalueに入れる
                    //なんとか value = なんとか;
                    //CutDic.Add(key, value);

                    
                    //Debug.Log("" + cutDatas[0]);
                    //Debug.Log(cutDatas[1]);
                    //Debug.Log(cutDatas[2]);



                    //Vector3 pos = transform.position;
                    //pos.y += 2;
                    //transform.position = pos;

                    //cutTrans.position;

                    //transform.position.x = posX;

                    //transform.rotation = Quaternion.Euler(rotX, rotY, rotZ);


                    //pos.x = cutDatas[i][1];
                    //pos.y = cutDatas[i][2];
                    //pos.z = cutDatas[i][3];
                    //pos.x = cutDatas[i][4];
                    //pos.y = cutDatas[i][5];
                    //pos.z = cutDatas[i][6];

                    string value = "a";


                    //CutDic.Add(key, value);

                    //ここから           //内部リストに値を代入する方法が不明
                    //string[] value {}
                    //cutDatas[0] = "a";
                    //cutDatas[1] = "b";
                    //cutDatas[2] = "c";
                    //cutDatas[3] = "d";
                    //string value = cutDatas;

                    //Debug.Log(cutDatas[i][0] + " : " + cutDatas[i][1] + " : " + cutDatas[i][2]);
                    //Debug.Log(CutDic["room_box_01"]);

                    cutDatas.Clear();
                }
                Debug.Log(fileName + " : " + row + "件、読込完了！");
                break;

            //C: string,float[]
            case "CameraList":
                //Dictionary<string, List<StringBuilder>> stringToBuilderMap = new Dictionary<string, List<StringBuilder>>();
                //Dictionary<string, string[]> CutList = new Dictionary<string, strinList<string>>();



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
