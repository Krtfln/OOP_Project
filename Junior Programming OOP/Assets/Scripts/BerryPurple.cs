using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryPurple : Bush
{
    private static float _timeToGrow = 5f;
    public static float TimeToGrow { get { return _timeToGrow; } set { _timeToGrow = value; } }

    private static int _pointsToAdd = 6;
    public static int PointsToAdd { get { return _pointsToAdd; } set { _pointsToAdd = value; } }

    private static int _speed = 2;

    public static int Speed { get { return _speed; } set { _speed = value; } }

    private static string _speedText = "Speed >";
    public static string SpeedText { get { return _speedText; } set { _speedText = value; } }

    public BerryPurple() : base(timeToGrow: TimeToGrow, pointsToAdd: PointsToAdd, speed: Speed, speedText: SpeedText)
    {
    }
}
