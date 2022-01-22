﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Teachers/Create new move")]

public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] TeacherType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
}
