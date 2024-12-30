using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStateDropDownManager : Subject<GameState>
{
   #region Private Properties
    [SerializeField] private TMP_Dropdown dataDropdown; // Reference to the Dropdown
   
    // Example data to populate the dropdown
    private List<string> dropdownOptions = new()
    {
        "Select",
        "Start",
        "Playing",
        "End"
    };
#endregion

#region Unity Callbacks
    private void Start()
    {
        PopulateDropdown(dropdownOptions);
    }    
#endregion

#region Public Class Methods+
    // Method to populate the dropdown with a list of strings
    public void PopulateDropdown(List<string> options)
    {
        // Clear existing options
        dataDropdown.ClearOptions();

        // Add new options
        dataDropdown.AddOptions(options);
    }

    void SelectGameState(string state){
        switch (state)
        {
            case "Start":
                Notify(new GameState{_gamestate = MGameState.Start, name = MGameState.Start.ToString()});
                break;

            case "Playing":
                Notify(new GameState{_gamestate = MGameState.Playing, name = MGameState.Playing.ToString()});
                break;

            case "End":
                Notify(new GameState{_gamestate = MGameState.End, name = MGameState.End.ToString()});
                break;
            
            default:
                break;
        }
    }

#endregion

#region DropDown Delegate Functions
    public void OnDropDownValueChanged(){
        Debug.Log("Selected: " + dataDropdown.value);
        Debug.Log("Selected: " + dataDropdown.captionText.text);

        SelectGameState(dataDropdown.captionText.text);
    }
#endregion
}
