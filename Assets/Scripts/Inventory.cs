using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] public TextMeshPro inventory_text;
    private SortedDictionary<string, int> inventory;

    private void Start()
    {
        inventory = new SortedDictionary<string, int>();
        inventory_text.text = "You have nothing in your cart";
    }
    
    private void Update() {}

    public void Add(string item)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += 1;
        }
        else
        {
            inventory[item] = 1;
        }
        Rewrite();
    }

    private void Rewrite()
    {
        string temp = "Your Cart:\n";
        foreach (KeyValuePair<string, int> item in inventory)
        {
            temp += item.Key + ": " + item.Value + "\n";
        }
        inventory_text.text = temp;
        Debug.Log("YOU ADDED SOMETHING TO YOUR CART");
    }
}