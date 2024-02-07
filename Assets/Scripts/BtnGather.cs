using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnGather : MonoBehaviour
{
    public GameObject StatusPanel;
    public GameObject InventoryPanel;
    public GameObject ShopPanel;
    public GameObject backBtn;
    public GameObject EquipPanel;
    public GameObject[] equipMark;
    public List<GameObject> InventoryList = new List<GameObject>();
    public TextMeshProUGUI equipTxt;
    public TextMeshProUGUI itemCount;
    public TextMeshProUGUI itemFullCount;    
    ItemEx itemEx;

    public bool[] equipTrue;
    public int equipIndex;

    void Awake()
    {
        itemEx = GetComponent<ItemEx>();        
    }
    public void OnItemButtonClick(int itemIndex)
    {
        equipIndex = itemIndex;
        itemEx.EquipItemEx(equipIndex);
        EquipBtnOn();        
    }
    public void StatusBtnOn()
    {
        StatusPanel.SetActive(true);
        backBtn.SetActive(true);
    }

    public void InventoryBtnOn()
    {
        itemCount.text = InventoryList.Count(item => item != null).ToString();
        itemFullCount.text = InventoryList.Count.ToString();
        InventoryPanel.SetActive(true);
        backBtn.SetActive(true);
    }

    public void ShopBtnOn()
    {
        ShopPanel.SetActive(true);
    }

    public void ShopBtnOff()
    {
        ShopPanel.SetActive(false);
    }

    public void backBtnOn()
    {
        StatusPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        backBtn.SetActive(false);
    }

    public void EquipBtnOn()
    {        
        if (InventoryList[equipIndex] != null)
        {            
            EquipPanel.SetActive(true);
            if (equipTrue[equipIndex] == false)
            {
                equipTxt.text = "장착 하시겠습니까??";                
            }
            else if (equipTrue[equipIndex] != false)
            {
                equipTxt.text = "장착 해제 하시겠습니까??";                
            }
        }        
    }

    public void EquipBtnOff()
    {
        EquipPanel.SetActive(false);
    }

    public void ConfirmBtn()
    {
        EquipPanel.SetActive(false);
        if (InventoryList[equipIndex] != null)
        {
            if (equipTrue[equipIndex] == false)
            {                
                equipMark[equipIndex].SetActive(true);
                equipTrue[equipIndex] = true;
            }
            else if (equipTrue[equipIndex] != false)
            {
                equipMark[equipIndex].SetActive(false);
                equipTrue[equipIndex] = false;
            }
        }        
    }
}
