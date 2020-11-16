﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICraftResult : MonoBehaviour
{
    public SlotPanel slotPanel;
    public Inventory inventory;


    public void PickItem()
    {
        inventory.inventoryItems.Add(GetComponent<UIItem>().item);
    }

    public void ClearSlots()
    {
        slotPanel.EmptyAllSlots();
    }
}
