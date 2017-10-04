using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アイテム欄に表示したり並べ替えたりする
public class ItemMenu : MonoBehaviour {

    int maxItmCnt = 5;

    public string[] ItemInventory = new string[5];
    public Button[] iBtn;
    //public Button Wpn;

    void Awake() {
        //ボタン数定義
        iBtn = new Button[maxItmCnt];
        //Wpn = GameObject.Find("weapon").GetComponent<Button>();

        //インベントリ初期化
        //Wpn = GameObject.Find("weapon").GetComponent<Button>();

        for (int i = 0; i < maxItmCnt; i++) {
            //ボタン情報取得
            string objName = "Item_" + i.ToString();
            iBtn[i] = GameObject.Find(objName).GetComponent<Button>();

            //初期化
            iBtn[i].interactable = false;
            ItemInventory[i] = "none";

            //Debug.Log("アイテム["+ i +"] : "+ItemInventory[i]);
            //Debug.Log(iBtn[i]);

        }

        //空アイテム追加テスト
        ItemInventory[1] = "item_1";
        ItemInventory[3] = "item_3";
        ItemInventory[4] = "item_4";

    }



    void Start() {
    }

    //インベントリ更新
    void Update() {
        for (int i = 0; i < maxItmCnt; i++) {
            if (ItemInventory[i] != "none") {
                //ボタン有効化
                iBtn[i].interactable = true;
                //Debug.Log(ItemInventory[i] + " ok!");
            } else {
                //ボタン無効化
                iBtn[i].interactable = false;
                //Debug.Log("Item_" + ItemInventory[i]);
            }
        }

    }

    public void AddInventory(string iName) {
        //Debug.Log(iName + " をAddだぜ！");

        bool flg = false;

        //アイテムDBからフラグを引っ張ってくる

        //空いてるスロットを探す
        for (int i = 0; i < maxItmCnt; i++) {
            if (ItemInventory[i] == "none" && flg == false)
            {
                ItemInventory[i] = iName;
                iBtn[i].interactable = true;
                flg = true;
                Debug.Log("スロット[" + i + "]に " + ItemInventory[i] + " をAddだぜ！");

                //アイテムアイコンを表示する
            }

        }

        if (flg == false) {
            Debug.Log("アイテムいっぱい");
            //アイテムいっぱいの時はオブジェクト消しちゃダメ
        }

    }

}
