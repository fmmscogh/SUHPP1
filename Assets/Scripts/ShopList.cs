using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopList : MonoBehaviour
{
    public Sprite[] itemImage;
    public Image[] shopItemImage;
    public TextMeshProUGUI[] shopItemName;
    public TextMeshProUGUI[] shopItemDescription;
    public Image[] itemOptionType;
    public Sprite[] itemOptionTyeList;
    public TextMeshProUGUI[] itemOptionValue;
    public TextMeshProUGUI[] goldValue;
    public GameObject purchasePanel;
    public GameObject itemInstance;
    public int itemLN { get; set; }
    int itemBtnNum;
    BtnGather button;

    void Awake()
    {
        button = GetComponent<BtnGather>();
    }
    private void Start()
    {
        for (int i = 0; i < itemImage.Length; i++)
        {
            shopItemImage[i].sprite = itemImage[i];
        }
        
        itemInfo(0, "낡은 검", "백골시체가 쥐고 있던 검", 0, "+30", "2000");
        itemInfo(1, "스태프", "던전에서 죽은 마법사의 스태프", 0, "+65", "4000");
        itemInfo(2, "한손 도끼", "산적 두목이 쓰던 한손 도끼", 0, "+80", "5000");
        itemInfo(3, "판금 투구", "기사들이 쓰던 판금 투구", 2, "+200", "7000");
        itemInfo(4, "판금 견갑", "기사들이 차던 판금 견갑", 3, "+20", "7000");
        itemInfo(5, "판금 하의", "기사들이 입던 판금 하의", 1, "+80", "10000");
    }

    void itemInfo(int itmeListNum, string itemName, string ItemDescription, int itemType, string optionValue, string goldPoint)
    {
        itemLN = itmeListNum;
        shopItemName[itmeListNum].text = itemName;
        shopItemDescription[itmeListNum].text = ItemDescription;
        itemOptionType[itmeListNum].sprite = itemOptionTyeList[itemType];
        itemOptionValue[itmeListNum].text = optionValue;
        goldValue[itmeListNum].text = goldPoint;
    }

    public void BuyBtn(int itemNum)
    {
        purchasePanel.SetActive(true);
        itemBtnNum = itemNum;
    }

    public void PurchaseConfirmBtn()
    {
        purchasePanel.SetActive(false);
        if(itemLN == itemBtnNum)
        {
            GameObject _obj = Instantiate(itemInstance);
            button.InventoryList.Add(_obj);
        }
    }
}
