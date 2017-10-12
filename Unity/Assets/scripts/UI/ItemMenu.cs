using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アイテム欄に表示したり並べ替えたりする
public class ItemMenu : MonoBehaviour {

    int maxItmCnt = 5;

    public string[] ItemInventory = new string[5];
    public string[] currentItem = new string[5];
    public Button[] iBtn;
    //public Button Wpn;

    void Awake() {
        //ボタン数定義
        iBtn = new Button[maxItmCnt];

        //インベントリ初期化
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

        //空アイテム追加テスト　ところどころ埋まってる感
        ItemInventory[1] = "item_1";
        ItemInventory[3] = "item_3";
        ItemInventory[4] = "item_4";

    }



    void Start() {
        Texture2D texture = Resources.Load("icon/" + "green") as Texture2D;
        Image img = GameObject.Find("Item_0").GetComponent<Image>();
        img.sprite = Sprite.Create(texture, new Rect(0, 0, 100, 100), Vector2.zero);
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

        bool flg = false;

        //アイテムDBからフラグを引っ張ってくる
        //Debug.Log(ItemDic["itm_key_01"]);
        Debug.Log("Item : " + MasterDataLoader.ItemDic["itm_key_01"]);
        Debug.Log("Icon : " + MasterDataLoader.IconDic["itm_key_01"]);

        //空いてるスロットを探す
        for (int i = 0; i < maxItmCnt; i++) {
            if (ItemInventory[i] == "none" && flg == false)
            {
                ItemInventory[i] = iName;
                iBtn[i].interactable = true;
                flg = true;

                //アイテムアイコンを表示する


                Debug.Log("スロット[" + i + "]に " + ItemInventory[i] + " をAddだぜ！");
            }

        }

        if (flg == false) {
            Debug.Log("アイテムいっぱい");
            //アイテムいっぱいの時はオブジェクト消しちゃダメ
        }

    }

}
