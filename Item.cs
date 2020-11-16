using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public enum Type
    {
        Consumable,
        Tool,
        Weapon,
        Raw_Material
    }

    public Type type;
    public int ID;
    public string name = "my new item";
    public string description = "my item description";
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id,string title,string description,Dictionary<string,int> stats)
    {
        this.ID = id;
        this.name = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Items/Sprites/" + name);
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.ID = item.ID;
        this.name = item.name;
        this.description = item.description;
        this.icon = item.icon;
        this.stats = item.stats;
    }
}
