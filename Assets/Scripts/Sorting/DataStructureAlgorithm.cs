using UnityEngine;

public class DataStructureAlgorithm : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [ContextMenu("Find Fibonacci Series Number")]
    void FindFibonacciSeriesNumber(){
        Debug.Log("// Fibonacci series: 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610");
        Debug.Log(Fibonacci(9));
    }

    int Fibonacci(int n){
        if(n<0){
            Debug.LogError("Invalid sequebce number");
            return -1;
        }

        if(n<=1){
            return n;
        }
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
}
