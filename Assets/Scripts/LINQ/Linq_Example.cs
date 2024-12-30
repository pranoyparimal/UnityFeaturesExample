using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Linq_Example : MonoBehaviour, IObserver<string>
{
#region Private Properties
    readonly int[] scores = {12, 98, 45, 23, 87, 45};
    List<ItemProperty> items = new();
    [SerializeField] private WeaponDropDownManager _dropDowwnManager;
#endregion
    
#region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"<color=green>Start Executed</color>");
        PopulateItems();
    }

#endregion
    
#region Public Methods
    void WeaponsValueChanged(string _weapon){
        SearchItem(_weapon);
    }

    void CheckLinqDemo(){
          //Define  the query execution
        IEnumerable <int> scoreQuery = 
            from score in scores
            where score>80
            select score;

        //Execute the query
        foreach(var i in scoreQuery){
            Debug.Log($"<color=red><size=25>score: {i}</size></color>");
        }
    }

    void PopulateItems(){
        ClearItems();

        items.Add(new ItemProperty{ itemName = "Blade", itemType = "Weapon", itemPrice = 470 });
        items.Add(new ItemProperty{ itemName = "MP Potion 50", itemType = "Potion", itemPrice = 650 });
        items.Add(new ItemProperty{ itemName = "Chief Heavy Core", itemType = "Armor", itemPrice = 620 });
        items.Add(new ItemProperty{ itemName = "HP Potion 500", itemType = "Potion", itemPrice = 460 });
        items.Add(new ItemProperty{ itemName = "Saber", itemType = "Weapon", itemPrice = 390 });
        items.Add(new ItemProperty{ itemName = "MP Potion 500", itemType = "Potion", itemPrice = 1000 });
        items.Add(new ItemProperty{ itemName = "Bone Knife", itemType = "Weapon", itemPrice = 830 });
        items.Add(new ItemProperty{ itemName = "Katana", itemType = "Weapon", itemPrice = 730 });
        items.Add(new ItemProperty{ itemName = "Low Burn Core", itemType = "Armor", itemPrice = 950 });
        items.Add(new ItemProperty{ itemName = "Offence Potion", itemType = "Potion", itemPrice = 340 });
        items.Add(new ItemProperty{ itemName = "Hora Core", itemType = "Armor", itemPrice = 800 });
        items.Add(new ItemProperty{ itemName = "Temple Beam Core", itemType = "Armor", itemPrice = 710 });
        items.Add(new ItemProperty{ itemName = "HP Potion 50", itemType = "Potion", itemPrice = 970 });
        items.Add(new ItemProperty{ itemName = "Adrenaline Potion", itemType = "Potion", itemPrice = 740 });
        items.Add(new ItemProperty{ itemName = "Training Shirt", itemType = "Armor", itemPrice = 400 });
        items.Add(new ItemProperty{ itemName = "Cure Potion", itemType = "Potion", itemPrice = 340 });

        foreach(var _item in items){
            Debug.Log($"<color=green><size=15>item: {_item.itemName}, {_item.itemType}, {_item.itemPrice}</size></color>");
        }

    }

    void ClearItems() => items?.Clear();

    void SearchItem(string _type){
        IEnumerable<ItemProperty> data = (
            from item in items
            where item.itemType.Equals(_type)
            select item
        ).ToList();

        foreach (var _data in data){
            Debug.Log($"<color=green><size=15>item: {_data.itemName}, {_data.itemType}, {_data.itemPrice}</size></color>");
        }
    }

#endregion

#region IObserver Implementation
    public void OnNotify(string data)
    {
        Debug.Log($"<color=red><size=15>Item Type Changed: {data}</size></color>");
        SearchItem(data);
    }
#endregion

}

#region Custom Property Class
    public class ItemProperty
    {
        public string itemName {get; set;}
        public string itemType {get; set;}
        public int itemPrice {get; set;}
    }
#endregion

