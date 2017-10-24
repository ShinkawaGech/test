using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アイテム欄に表示したり並べ替えたりする
public class ItemMenu : MonoBehaviour {

    //アイテム欄
    int maxItmCnt = 5;

    public string[] ItemInventory;  //カレントアイテムのオブジェクト名
    public Button[] iBtn;
    public Image[] iImg;

    public Button Wpn;

    string objName;
    string imgName;
    string iconName;

    //アイテム詳細
    GameObject iDetail;


    void Awake (){
        //アイテム詳細
        iDetail = GameObject.Find("ItemDetail").gameObject;
        iDetail.SetActive(false);

    }

    void Start() {
        //AwakeでマスターデータをロードしているのでStartでやる
        //インベントリ、ボタン、アイコン数の定義
        ItemInventory = new string[maxItmCnt];
        iBtn = new Button[maxItmCnt];
        iImg = new Image[maxItmCnt];

        //インベントリ初期化
        for (int i = 0; i < maxItmCnt; i++) {
            //ボタン情報取得
            objName = "Item_" + i.ToString();
            imgName = "Icon_" + i.ToString();
            iBtn[i] = GameObject.Find(objName).GetComponent<Button>();
            iImg[i] = GameObject.Find(objName + "/" + imgName).GetComponent<Image>();
            //Debug.Log(iImg[i].name);

            //Texture2D tex = Resources.Load("icon/green") as Texture2D;
            //iImg[i].sprite = Sprite.Create(tex, new Rect(0, 0, 80, 80), Vector2.zero);

            //初期化
            iBtn[i].interactable = false;
            ItemInventory[i] = "none";

            //Debug.Log("アイテム["+ i +"] : "+ItemInventory[i]);
            //Debug.Log(iBtn[i]);

        }

        //空アイテム追加テスト　ところどころ埋まってる感
        ItemInventory[0] = "item_0";
        ItemInventory[1] = "item_1";
        ItemInventory[3] = "item_3";
        ItemInventory[4] = "item_4";
        iBtn[0].interactable = true;
        iBtn[1].interactable = true;
        iBtn[3].interactable = true;
        iBtn[4].interactable = true;

        //Debug.Log("Item : " + MasterDataLoader.ItemDic["itm_key_01"]);
        //Debug.Log("Icon : " + MasterDataLoader.IconDic["itm_key_01"]);

    }

    void Update() {

        //AddInventoryに移行
        //for (int i = 0; i < maxItmCnt; i++) {
            //if (ItemInventory[i] != "none") {

                //ボタン有効化
                //iBtn[i].interactable = true;
                //Debug.Log(ItemInventory[i] + " ok!");

                //アイテムアイコンを表示する
                
            //}
            //else {

                //アイテムアイコンを非表示にする

                //ボタン無効化
                //iBtn[i].interactable = false;
                //Debug.Log("Item_" + ItemInventory[i]);

            //}
        //}

    }

    //アイテムモデルをクリックするとアイテム欄に追加される
    public void AddInventory(string iName) {

        //追加処理中フラグ
        bool isAdd = false;

        //空いてるスロットを探す
        for (int i = 0; i < maxItmCnt; i++) {
            if (ItemInventory[i] == "none" && isAdd == false)
            {
                //アイテム名（オブジェクト名）をインベントリに
                ItemInventory[i] = iName;

                //ボタン表示
                iBtn[i].interactable = true;

                //アイテムアイコン表示
                string iconName = MasterDataLoader.IconDic[iName];
                Texture2D texture = Resources.Load("icon/" + iconName) as Texture2D;
                iImg[i].sprite = Sprite.Create(texture, new Rect(0, 0, 80, 80), Vector2.zero);

                //追加処理完了
                isAdd = true;

                Debug.Log(objName);
                Debug.Log(iName);
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


    
    //アイテム詳細
    public void ItemDetailEnable()
    {
        //iDtail = GameObject.Find("ItemDetail").GetComponent<>
        Debug.Log("アイテム詳細：表示");
        iDetail.SetActive(true);

        //アイテムモデル表示
        //アイテム名＋"_Detail"
    }

    public void ItemDetailDisable()
    {
        //iDtail = GameObject.Find("ItemDetail").GetComponent<>
        iDetail.SetActive(false);
        Debug.Log("アイテム詳細：非表示");
    }

    //アイテム詳細画面で何かした
    public void UseItem()
    {
    }




}