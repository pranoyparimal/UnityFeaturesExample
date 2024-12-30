using System.Collections.Generic;
using UnityEngine;

public abstract class Subject<T>: MonoBehaviour
{
    private readonly List<IObserver<T>> observers = new();

    public void Subscribe(IObserver<T> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    public void Unsubscribe(IObserver<T> observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void Notify(T data)
    {
        foreach (var observer in observers)
        {
            observer.OnNotify(data);
        }
    }
}

