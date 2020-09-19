//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class TreasureData : MonoBehaviour
{
    private const int MAX_VALUE = 500;
    private const int MIN_VALUE = 5;

    public int Value;

    public void Awake()
    {
        Value = Random.Range(MIN_VALUE, MAX_VALUE);
    }
}
