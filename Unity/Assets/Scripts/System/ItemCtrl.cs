using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//全てのアイテムにアタッチする。ItemMenuへの繋ぎ。
//共通処理のみ
public class ItemCtrl : MonoBehaviour {

    //ItemMenuコンポーネント
    ItemMenu iMenu;

    //アイテム名＝オブジェクト名
    string ItemName;

//    void Awake () {
//    }

    void Start () {
        iMenu = GameObject.Find("ItemMenu").GetComponent<ItemMenu>();
        ItemName = this.gameObject.name;
        //Debug.Log(ItemName);

    }
	
//	void Update () {
//        //Debug.Log(flg_item);
//	}

    public void GetItem() {
        //クリックしたアイテムを取得状態（非表示）にする。
        this.gameObject.SetActive(false);

        //インベントリ追加処理
        iMenu.AddInventory(ItemName);
    }

}

