﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotPanel : MonoBehaviour
{
    public List<UIItem> uiItems = new List<UIItem>();
    public int numberOfSlots;
    public GameObject slotPrefab;

    private void Awake()
    {
        for (int i = 0; i < numberOfSlots; i++)
        {
                GameObject instance = Instantiate(slotPrefab);
                instance.transform.SetParent(transform);
                uiItems.Add(instance.GetComponentInChildren<UIItem>());
            uiItems[i].item = null;
        }
    }

    public void UpdateSlot(int slot,Item item)
    {
        uiItems[slot].UpdateItem(item);
    }

    public void AddNewItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(i => i.item == null),item);
    }

    public void RemoveItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(i => i.item == item), null);
    }

    public bool ContainsEmptySlot()
    {
        foreach (UIItem uiI in uiItems)
        {
            if (uiI.item == null) return true;
        }
            return false;
    }

    public void EmptyAllSlots()
    {
        uiItems.ForEach(i => i.UpdateItem(null));
    }
}
