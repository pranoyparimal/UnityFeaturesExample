using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponDropDownManager : Subject<string>
{
#region Private Properties
    [SerializeField] private TMP_Dropdown dataDropdown; // Reference to the Dropdown
   
    // Example data to populate the dropdown
    private List<string> dropdownOptions = new()
    {
        "Select",
        "Weapon",
        "Potion",
        "Armor"
    };
#endregion

#region Unity Callbacks
    private void Start()
    {
        PopulateDropdown(dropdownOptions);
    }    
#endregion

#region Public Class Methods
    // Method to populate the dropdown with a list of strings
    public void PopulateDropdown(List<string> options)
    {
        // Clear existing options
        dataDropdown.ClearOptions();

        // Add new options
        dataDropdown.AddOptions(options);
    }
#endregion
 
#region DropDown Delegate Functions
    public void OnDropDownValueChanged(){
        Debug.Log("Selected: " + dataDropdown.value);
        Debug.Log("Selected: " + dataDropdown.captionText.text);
        Notify(dataDropdown.captionText.text);
    }
#endregion
    
}
