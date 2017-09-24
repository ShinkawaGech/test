using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MasterDataLoader {

    public List<string[]> csvDatas = new List<string[]>();

    public void CsvRead(string file) {
        TextAsset csvFile = Resources.Load("csv/" + file) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        while(reader.Peek() > -1){
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
        }

        //要素数取得
        int row = csvDatas.Count;
        int col = csvDatas[0].Length;
        //Debug.Log("Lst :" + row + ":" + col);

        //csvデータのディクショナリ可
        Dictionary<string, bool> flg = new Dictionary<string, bool>();

        for (int i = 0; i < row; i++) {
            string key = csvDatas[i][0];
            bool value = bool.Parse(csvDatas[i][1]);
            flg.Add(key, value);
        }

        //デバッグ：参照
        //foreach (KeyValuePair<string, bool> pair in flg) {
        //Debug.Log(pair.Key + " : " + pair.Value);
        //}
        //Debug.Log("m01_kit_a : " + flg["m01_kit_a"]);
        //Debug.Log("m01_kit_b : " + flg["m01_kit_b"]);
        //Debug.Log("m01_kit_c : " + flg["m01_kit_c"]);

        //デバッグ：書き込み
        flg["m01_kit_b"] = true;
        //Debug.Log("m01_kit_a : " + flg["m01_kit_a"]);
        //Debug.Log("m01_kit_b : " + flg["m01_kit_b"] + " <-Trueになる");
        //Debug.Log("m01_kit_c : " + flg["m01_kit_c"]);

    }


}
