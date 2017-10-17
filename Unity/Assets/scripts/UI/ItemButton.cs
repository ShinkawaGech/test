using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//全てのアイテムボタンにアタッチする。ItemMenuへの繋ぎ。
//共通処理のみ
public class ItemButton : MonoBehaviour {

    //アイテムメニュー
    ItemMenu iMenu;

    void Awake () {
        iMenu = GameObject.Find("ItemMenu").GetComponent<ItemMenu>();
    }

    //	void Update () {
        //StartCoroutine("OpenItemDetail");
    //	}

    //アイテムボタンを押した
    public void PushItemButton() {
        iMenu.ItemDetailEnable();
    }

    //アイテム詳細閉じるボタンを押した
    public void PushItemDetailClose()
    {
        iMenu.ItemDetailDisable();
    }

    //他のアイテムボタンを押した
    public void ChangeItemDetailClose()
    {
        iMenu.ItemDetailDisable();
        iMenu.ItemDetailEnable();
    }

    //    IEnumerator OpenItemDetail() {
    //
    //        //パネルをenable
    //        //ItemData[itemNo]
    //        yield return new WaitForSeconds(0);
    //    }

}
