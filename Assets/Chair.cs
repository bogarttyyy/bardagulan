using UnityEngine;

public class Chair : Trash
{
    [SerializeField]
    private float points = 2f;

    public override float pointValue{
        get{
            return points;
        }
    }
}
