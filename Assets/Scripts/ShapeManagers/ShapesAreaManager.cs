using UnityEngine;

public class ShapesAreaManager : MonoBehaviour
{
#region Unity Callbacks
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateSquareArea();
        CalculateSquarePerimeter();

        CalculateRectangleArea();
        CalculateRectanglePerimeter();
    }

#endregion

#region Square Shape based methods
    void CalculateSquareArea()
    {
        Debug.Log($"<color=green>The area of square is {GetComponent<Square>().GetArea()} </color>");
    }

    void CalculateSquarePerimeter()
    {
        Debug.Log($"<color=green>The Perimeter of square is {GetComponent<Square>().GetPerimeter()}</color>");
    }
#endregion
    
#region Rectangle Shape based methods
    void CalculateRectangleArea()
    {
        Debug.Log($"<color=yellow>The area of rectangle is {GetComponent<Rectangle>().GetArea()}</color>");
    }

    void CalculateRectanglePerimeter()
    {
        Debug.Log($"<color=yellow>The Perimeter of rectangle is {GetComponent<Rectangle>().GetPerimeter()}</color>");
    }
#endregion
    
}
