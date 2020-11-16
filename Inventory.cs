using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> inventoryItems = new List<Item>();
    ItemDatabase itemDatabase;

    [SerializeField] private UIInventory uiInventory;

    private void Awake()
    {
        itemDatabase = FindObjectOfType<ItemDatabase>();
    }

    private void Start()
    {
        AddItem(1);
        AddItem(2);
    }

    public void AddItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        uiInventory.AddItemToUI(itemToAdd);
        inventoryItems.Add(itemToAdd);
    }

    public void AddItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        uiInventory.AddItemToUI(itemToAdd);
        inventoryItems.Add(itemToAdd);
    }

    public Item CheckForItem(int id)
    {
        return inventoryItems.Find(item => item.ID == id);
    }
    public Item CheckForItem(string name)
    {
        return inventoryItems.Find(item => item.name == name);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);

        if (itemToRemove != null)
        {
            inventoryItems.Remove(itemToRemove);
        }
    }
}
