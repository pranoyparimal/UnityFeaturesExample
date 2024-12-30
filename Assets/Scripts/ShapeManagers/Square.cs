using UnityEngine;

public class Square : Shape
{
    [Header("Square Parameters")]
    [Tooltip ("This is the side of the square.")]
    [SerializeField] private float _side;

    public override float GetArea()
    {
        return _side * _side;
    }

    public override float GetPerimeter()
    {
        return 4*_side;
    }
}
