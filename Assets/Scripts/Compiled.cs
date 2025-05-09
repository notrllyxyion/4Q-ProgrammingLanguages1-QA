using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compiled : MonoBehaviour
{
    public InputField AddInventory;
    public InputField RemoveInventory;
    public Text Inventory;

    static List<string> inventory = new List<string>();

    public void Additem()
    {
      string item = AddInventory.text;
        if (!string .IsNullOrEmpty(item) )
        {
            inventory.Add(item);
            AddInventory.text = "";
            ViewInventory();

        }
    }
    public void RemoveItem()
    {
        string item = RemoveInventory.text;
        if (!string.IsNullOrEmpty(item) && inventory.Contains(item))
        {
            inventory.Remove(item);
            RemoveInventory.text = "";
            ViewInventory();

        }
    }
    public void ViewInventory()
    {
        if (inventory.Count > 0)
        {
            Inventory.text = "";
            for (int i = 0; i < inventory.Count; i++)
            {
                Inventory.text += $"{i + 1}. {inventory[i]}\n";
            }
        }
        else
        {
            Inventory.text = "Inventory is empty.";
        }
    }

}
