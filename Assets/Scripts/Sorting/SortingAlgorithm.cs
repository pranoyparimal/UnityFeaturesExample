using UnityEngine;
using UnityEngine.UIElements;

public class SortingAlgorithm : MonoBehaviour
{
    [SerializeField] int[] _numbers = new int[]{2,1,4,7};
    private void Start() {
        
    }

    #region Bubble Sort
    [ContextMenu("Bubble Sort")]
    void BubbleSort(){
        for(int i = 0; i<_numbers.Length; i++){
            for(int j=0; j<_numbers.Length-i-1; j++){
                if(_numbers[j]>_numbers[j+1]){
                    int _temp = _numbers[j];
                    _numbers[j] = _numbers[j+1];
                    _numbers[j+1] = _temp;
                }
            }
        }
    }
    #endregion

    #region Selection Sort
    [ContextMenu("Selection Sort")]
    void SelectionSort(){
        Debug.Log("Select Sorting");

        for(int i =0; i<_numbers.Length-1; i++){
            int _minIndex = i;
            for(int j=i+1; j<_numbers.Length; j++){
                if(_numbers[j] < _numbers[_minIndex]){
                    _minIndex = j;
                }
            } 

            int _temp = _numbers[_minIndex];
            _numbers[_minIndex] = _numbers[i];
            _numbers[i] = _temp;

        }
    }
    #endregion

    #region Insertion Sort
    [ContextMenu("Insertion Sort")]
    void InsertionSort(){
        //[4, 3, 2, 10, 12, 1, 5, 6]
        for(int i=1; i<_numbers.Length; i++){
            int _key = _numbers[i];
            int j = i-1;

            while(j>=0 && _numbers[j]>_key){
                _numbers[j+1] = _numbers[j];
                j = j-1;
            }
            _numbers[j+1] = _key;
        }
    }
    #endregion

    #region Merge Sort
    void MergeSort(){
        
    }
    #endregion
    
    
}
