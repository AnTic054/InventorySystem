using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolTip : MonoBehaviour
{
    private TextMeshProUGUI toolTipText;

    private void Start()
    {
        toolTipText = GetComponentInChildren<TextMeshProUGUI>();
        gameObject.SetActive(false);
    }

    public void GenerateToolTipText(Item item)
    {
        
        string statsText = "";
        foreach (var stat in item.stats)
        {
            statsText += "\n " + stat.Key.ToString() + ": " + stat.Value.ToString();
        }
        
        string toolTip = string.Format("<b>{0}<b>\n{1}\n<b>{2}</b>", item.name, item.description, statsText);
        toolTipText.text = toolTip;
        gameObject.SetActive(true);
    }
}
