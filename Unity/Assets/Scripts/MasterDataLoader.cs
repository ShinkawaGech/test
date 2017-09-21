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

    }


}
