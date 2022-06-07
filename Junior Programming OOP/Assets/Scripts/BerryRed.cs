using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryRed : Bush
{
    private static float _timeToGrow = 3f;
    public static float TimeToGrow { get { return _timeToGrow; } set { _timeToGrow = value; } }

    private static int _pointsToAdd = 3;
    public static int PointsToAdd { get { return _pointsToAdd; } set { _pointsToAdd = value; } }

    private static int _speed = 5;
    public static int Speed { get { return _speed; } set { _speed = value; } }

    private static string _speedText = "Speed >>";
    public static string SpeedText { get { return _speedText; } set { _speedText = value; } }

    public BerryRed() : base(timeToGrow: TimeToGrow, pointsToAdd: PointsToAdd, speed: Speed, speedText: SpeedText)
    {
    }
}
