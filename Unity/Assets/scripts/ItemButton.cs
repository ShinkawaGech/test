using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//アイテム欄を選択して詳細を見たりする
public class ItemButton : MonoBehaviour {

    public string itemNo;
    //ItemButton btn;

    void Start () {
        //ボタンオブジェクト取得
        string btnName = "Item_" + itemNo;
        //btn = GameObject.Find(btnName).GetComponent<ItemButton>();
        //Debug.Log(btn);
    }
	
	void Update () {
		
	}

    //アイテムボタンを押した
    void PushItemButton() {
        StartCoroutine("OpenItemDetail");
    }

    IEnumerator OpenItemDetail() {

        //パネルをenable
        //ItemData[itemNo]
        yield return new WaitForSeconds(0);
    }
}
