using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftRecipe
{
    public enum Type
    {
        Consumable,
        Tool,
        Weapon,
        Raw_Material
    }

    public int[] requiredItems;
    public int itemToCraft;
    public Type type;

    public CraftRecipe(int itemToCraft,int[] requiredItems)
    {
        this.requiredItems = requiredItems;
        this.itemToCraft = itemToCraft;
    }
}
