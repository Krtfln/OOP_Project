using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryPurple : Bush
{
    private static float _timeToGrow = 5f;
    public static float TimeToGrow { get { return _timeToGrow; } set { _timeToGrow = value; } }

    private static int _pointsToAdd = 6;
    public static int PointsToAdd { get { return _pointsToAdd; } set { _pointsToAdd = value; } }

    private static int _speedMultiplier = 2;

    public static int SpeedMultiplier { get { return _speedMultiplier; } set { _speedMultiplier = value; } }

    public BerryPurple() : base(timeToGrow: TimeToGrow, pointsToAdd: PointsToAdd, speedMultiplier: SpeedMultiplier)
    {
    }
}
