using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryRed : Bush
{
    private static float _timeToGrow = 5f;
    public static float TimeToGrow { get { return _timeToGrow; } set { _timeToGrow = value; } }

    private static int _pointsToAdd = 10;
    public static int PointsToAdd { get { return _pointsToAdd; } set { _pointsToAdd = value; } }

    public BerryRed() : base(timeToGrow: TimeToGrow, pointsToAdd: PointsToAdd, 2)
    {
    }
}
