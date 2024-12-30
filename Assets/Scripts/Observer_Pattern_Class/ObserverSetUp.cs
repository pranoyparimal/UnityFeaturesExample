using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ObserverSetUp : MonoBehaviour
{
    [SerializeField] private Subject<string> mWeaponDropDownManager;
    [SerializeField] private Subject<GameState> mGameStateDropDownManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       AddWeaponChangeObservers();
       AddGameStateChangeObservers();
    }

    private void OnDestroy() {
        RemoveWeaponChangeObservers();
        RemoveGameStateChangeObservers();
    }

    void AddWeaponChangeObservers(){
        var observers = FindObjectsImplementingInterface<IObserver<string>>();

        foreach (var observer in observers){
            mWeaponDropDownManager.Subscribe(observer);
        }
    }

    void AddGameStateChangeObservers(){
        var observers = FindObjectsImplementingInterface<IObserver<GameState>>();

        foreach (var observer in observers){
            mGameStateDropDownManager.Subscribe(observer);
        }
    }

    void RemoveWeaponChangeObservers(){
        var observers = FindObjectsImplementingInterface<IObserver<string>>();

        foreach (var observer in observers){
            mWeaponDropDownManager.Unsubscribe(observer);
        }
    }

    void RemoveGameStateChangeObservers(){
        var observers = FindObjectsImplementingInterface<IObserver<GameState>>();

        foreach (var observer in observers){
            mGameStateDropDownManager.Unsubscribe(observer);
        }
    }

   static IEnumerable<T> FindObjectsImplementingInterface<T>() where T : class
    {
        // Find all MonoBehaviour components in the scene
        MonoBehaviour[] allComponents = (MonoBehaviour[])FindObjectsByType (typeof(MonoBehaviour), FindObjectsSortMode.None);

        // Filter components that implement the specified interface
        List<T> results = allComponents
            .Where(component => component is T)
            .Cast<T>()
            .ToList();

        return results;
    }
}
