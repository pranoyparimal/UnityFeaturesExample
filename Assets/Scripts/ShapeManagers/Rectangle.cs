using UnityEngine;

public class Rectangle : Shape
{
    [Header("Rectangle Parameters")]
    [Tooltip("This is the length of the Rectangle.")]
    [SerializeField] private float _length;
    [Tooltip("This is the breadth of the Rectangle.")]
    [SerializeField] private float _breadth;

    public override float GetArea()
    {
        return _length * _breadth;
    }

    public override float GetPerimeter()
    {
        return 2*(_length+_breadth);
    }
}
