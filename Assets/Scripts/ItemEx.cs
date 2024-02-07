using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemEx : MonoBehaviour
{
    public Image equipImage;
    public TextMeshProUGUI equipItemName;
    public TextMeshProUGUI equipItemEx;
    public Sprite[] optionTypeList;
    public Image itemOptiontypeImage;
    public TextMeshProUGUI itemOptionType;
    public TextMeshProUGUI itemOptionValue;    
    BtnGather button;

    void Awake()
    {
        button = GetComponent<BtnGather>();        
    }
    public void EquipItemEx(int eIndex)
    {
        if (eIndex == 0)
        {
            equipImage.sprite = button.InventoryList[0].GetComponent<Image>().sprite;
            equipItemName.text = "³ª¹« È°";
            equipItemEx.text = "¹°Çª·¹ ³ª¹«·Î ¸¸µç È°";
            itemOptiontypeImage.sprite = optionTypeList[0];
            itemOptionType.text = "Attack";
            itemOptionValue.text = "50";
        }
        else if (eIndex == 1)
        {
            equipImage.sprite = button.InventoryList[1].GetComponent<Image>().sprite;
            equipItemName.text = "¹«¼è µµ³¢";
            equipItemEx.text = "ÅëÂ¥ ¹«¼è·Î ¸¸µç µµ³¢";
            itemOptiontypeImage.sprite = optionTypeList[0];
            itemOptionType.text = "Attack";
            itemOptionValue.text = "70";
        }
        else if (eIndex == 2)
        {
            equipImage.sprite = button.InventoryList[2].GetComponent<Image>().sprite;
            equipItemName.text = "Ã¶Åð";
            equipItemEx.text = "±ÝºÎÀåÀÌ ¾²´ø Ã¶Åð";
            itemOptiontypeImage.sprite = optionTypeList[0];
            itemOptionType.text = "Attack";
            itemOptionValue.text = "100";
        }
        else if (eIndex == 3)
        {
            equipImage.sprite = button.InventoryList[3].GetComponent<Image>().sprite;
            equipItemName.text = "ÇÃ·¹ÀÌÆ®¸ÞÀÏ";
            equipItemEx.text = "±â»çµéÀÌ ÀÔ´ø Ã¶ °©¿Ê";
            itemOptiontypeImage.sprite = optionTypeList[1];
            itemOptionType.text = "Defense";
            itemOptionValue.text = "100";
        }
        else if (eIndex == 4)
        {
            equipImage.sprite = button.InventoryList[4].GetComponent<Image>().sprite;
            equipItemName.text = "ºÓÀº ºÎÃ÷";
            equipItemEx.text = "¸¶¹ý»çµéÀÌ ½Å´ø ºÎÃ÷";
            itemOptiontypeImage.sprite = optionTypeList[3];
            itemOptionType.text = "Critical";
            itemOptionValue.text = "50";
        }
        else if (eIndex == 5)
        {
            equipImage.sprite = button.InventoryList[5].GetComponent<Image>().sprite;
            equipItemName.text = "°¡Á× Àå°©";
            equipItemEx.text = "¾ÆÃ³°¡ »ç¿ëÇÏ´Â ¼Ò°¡Á× Àå°©";
            itemOptiontypeImage.sprite = optionTypeList[2];
            itemOptionType.text = "Health";
            itemOptionValue.text = "200";
        }
        else if (eIndex == 6)
        {
            equipImage.sprite = button.InventoryList[6].GetComponent<Image>().sprite;
            equipItemName.text = "±ÍÁ· ¸ÁÅä";
            equipItemEx.text = "±ÍÁ·µéÀÌ »ç¿ëÇÏ´ø ¸ÁÅä";
            itemOptiontypeImage.sprite = optionTypeList[1];
            itemOptionType.text = "Defense";
            itemOptionValue.text = "50";
        }              
    }
}
