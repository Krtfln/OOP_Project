using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryYellow : Bush
{
    private static float _timeToGrow = 2f;
    public static float TimeToGrow { get { return _timeToGrow; } set { _timeToGrow = value; } }

    private static int _pointsToAdd = 1;
    public static int PointsToAdd { get { return _pointsToAdd; } set { _pointsToAdd = value; } }

    private static int _speedMultiplier = 8;

    public static int SpeedMultiplier { get { return _speedMultiplier; } set { _speedMultiplier = value; } }

    public BerryYellow() : base(timeToGrow: TimeToGrow, pointsToAdd: PointsToAdd, speedMultiplier: SpeedMultiplier)
    {
    }
}
