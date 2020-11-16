using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.ID == id);
    }

    public Item GetItem(string name)
    {
        return items.Find(item => item.name == name);
    }

    void BuildItemDatabase()
    {
        
        items = new List<Item>()
        {
            new Item(1,"Circle","this is an apple, its good for eating",
            new Dictionary<string, int>
            {
                {"food",5 },
                {"Spoil time",100 }
            }),
            new Item(2,"Square","this is an axe, its good for chopping",
            new Dictionary<string, int>
            {
                {"Power",7 },
                {"Durability",100 }
            }),
            new Item(3,"Triangle","this is an Rock, its good for throwing",
            new Dictionary<string, int>
            {
                {"Weight",10 },
                {"Spoil time",100 }
            })
        };
        
    }
}
