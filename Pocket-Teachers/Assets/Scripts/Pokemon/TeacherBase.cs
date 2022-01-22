using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Teachers", menuName = "Teachers/Create new Teacher")]

public class TeacherBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] TeacherType type1;
    [SerializeField] TeacherType type2;

    //Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public string Name
    {
        get { return name; }
    }
    public string Description 
    {
        get { return description; }
    }
    public Sprite FrontSprite 
    {
        get { return frontSprite; }
    }
    public Sprite BackSprite 
    {
        get { return backSprite; }
    }
    public TeacherType Type1 
    {
        get { return type1; }
    }
    public TeacherType Type2 
    {
        get { return type2; }
    }
    public int MaxHP 
    {
        get { return maxHP; }
    }
    public int Attack 
    {
        get { return attack; }
    }
    public int Defense 
    {
        get { return defense; }
    }
    public int SpAttack 
    {
        get { return spAttack; }
    }
    public int SpDefense 
    {
        get { return spDefense; }
    }
    public int Speed 
    {
        get { return speed; }
    }
}

public enum TeacherType
{
    None,
    Dutch,
    English,
    French,
    German,
    Biology,
    Chemistry,
    PE,
    Geology,
    Physics,
    Philosophy,
    Classic_Languages,
    Math
}
