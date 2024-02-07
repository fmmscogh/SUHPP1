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
            equipItemName.text = "���� Ȱ";
            equipItemEx.text = "��Ǫ�� ������ ���� Ȱ";
            itemOptiontypeImage.sprite = optionTypeList[0];
            itemOptionType.text = "Attack";
            itemOptionValue.text = "50";
        }
        else if (eIndex == 1)
        {
            equipImage.sprite = button.InventoryList[1].GetComponent<Image>().sprite;
            equipItemName.text = "���� ����";
            equipItemEx.text = "��¥ ����� ���� ����";
            itemOptiontypeImage.sprite = optionTypeList[0];
            itemOptionType.text = "Attack";
            itemOptionValue.text = "70";
        }
        else if (eIndex == 2)
        {
            equipImage.sprite = button.InventoryList[2].GetComponent<Image>().sprite;
            equipItemName.text = "ö��";
            equipItemEx.text = "�ݺ����� ���� ö��";
            itemOptiontypeImage.sprite = optionTypeList[0];
            itemOptionType.text = "Attack";
            itemOptionValue.text = "100";
        }
        else if (eIndex == 3)
        {
            equipImage.sprite = button.InventoryList[3].GetComponent<Image>().sprite;
            equipItemName.text = "�÷���Ʈ����";
            equipItemEx.text = "������ �Դ� ö ����";
            itemOptiontypeImage.sprite = optionTypeList[1];
            itemOptionType.text = "Defense";
            itemOptionValue.text = "100";
        }
        else if (eIndex == 4)
        {
            equipImage.sprite = button.InventoryList[4].GetComponent<Image>().sprite;
            equipItemName.text = "���� ����";
            equipItemEx.text = "��������� �Ŵ� ����";
            itemOptiontypeImage.sprite = optionTypeList[3];
            itemOptionType.text = "Critical";
            itemOptionValue.text = "50";
        }
        else if (eIndex == 5)
        {
            equipImage.sprite = button.InventoryList[5].GetComponent<Image>().sprite;
            equipItemName.text = "���� �尩";
            equipItemEx.text = "��ó�� ����ϴ� �Ұ��� �尩";
            itemOptiontypeImage.sprite = optionTypeList[2];
            itemOptionType.text = "Health";
            itemOptionValue.text = "200";
        }
        else if (eIndex == 6)
        {
            equipImage.sprite = button.InventoryList[6].GetComponent<Image>().sprite;
            equipItemName.text = "���� ����";
            equipItemEx.text = "�������� ����ϴ� ����";
            itemOptiontypeImage.sprite = optionTypeList[1];
            itemOptionType.text = "Defense";
            itemOptionValue.text = "50";
        }              
    }
}
