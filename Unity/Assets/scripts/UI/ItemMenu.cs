using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アイテム欄に表示したり並べ替えたりする
public class ItemMenu : MonoBehaviour {

    int maxItmCnt = 5;

    public string[] ItemInventory;  //カレントアイテムのオブジェクト名
    public Button[] iBtn;
    public Image[] iImg;

    public Button Wpn;

    //アイテム欄生成
    void Awake()
    {
    }

    void Start() {

        //インベントリ、ボタン、アイコン数の定義
        ItemInventory = new string[maxItmCnt];
        iBtn = new Button[maxItmCnt];
        iImg = new Image[maxItmCnt];

        //インベントリ初期化
        for (int i = 0; i < maxItmCnt; i++) {
            //ボタン情報取得
            string objName = "Item_" + i.ToString();
            string imgName = "Icon_" + i.ToString();
            iBtn[i] = GameObject.Find(objName).GetComponent<Button>();
            iImg[i] = GameObject.Find(objName + "/" + imgName).GetComponent<Image>();
            //Debug.Log(iImg[i].name);
            Texture2D tex = Resources.Load("icon/green") as Texture2D;
            iImg[i].sprite = Sprite.Create(tex, new Rect(0, 0, 80, 80), Vector2.zero);

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

        //Debug.Log("Item : " + MasterDataLoader.ItemDic["itm_key_01"]);
        //Debug.Log("Icon : " + MasterDataLoader.IconDic["itm_key_01"]);

    }


    //インベントリ更新
    //アイテムフラグが更新されるとアイテム欄に反映する
    void Update() {

        //AddInventoryに移行できるかも
        for (int i = 0; i < maxItmCnt; i++) {
            if (ItemInventory[i] != "none") {

                //ボタン有効化
                //iBtn[i].interactable = true;
                //Debug.Log(ItemInventory[i] + " ok!");

                //アイテムアイコンを表示する
                
            }
            else {

                //アイテムアイコンを非表示にする

                //ボタン無効化
                //iBtn[i].interactable = false;
                //Debug.Log("Item_" + ItemInventory[i]);

            }
        }

    }

    //アイテムモデルをクリックするとアイテム欄に追加される
    public void AddInventory(string iName) {

        //追加処理中フラグ
        bool isAdd = false;

        //アイテムDBからフラグを引っ張ってくる
        //Debug.Log(ItemDic["itm_key_01"]);
        Debug.Log("Item : " + MasterDataLoader.ItemDic["itm_key_01"]);
        Debug.Log("Icon : " + MasterDataLoader.IconDic["itm_key_01"]);

        //空いてるスロットを探す
        for (int i = 0; i < maxItmCnt; i++) {
            if (ItemInventory[i] == "none" && isAdd == false)
            {
                //ItemInventory[i] = iName;

                iBtn[i].interactable = true;

                //アイテムアイコン表示

                isAdd = true;


                Debug.Log("スロット[" + i + "]に " + ItemInventory[i] + " をAddだぜ！");
            }

        }

        if (!isAdd) {
            Debug.Log("アイテムいっぱい");
            //アイテムいっぱいの時はオブジェクト消しちゃダメ
        }
    }
        
    //アイテムを使用するとアイテム欄から削除される
    public void RemInventory()
    {
        Debug.Log("アイテム削除だぜ！");
    }

}