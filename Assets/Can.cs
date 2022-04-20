using UnityEngine;

public class Can : Trash
{
    [SerializeField]
    private float points = 1f;
    public override float pointValue
    {
        get
        {
            return points;
        }
    }
}
