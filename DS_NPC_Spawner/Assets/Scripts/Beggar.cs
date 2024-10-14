using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner
}

public class Beggar : INPC
{
    public void Speak()
    {
        Debug.Log("Do you have some change to spare?");
    }
}

public class Shopowner : INPC
{
    public void Speak()
    {
        Debug.Log("Do you wish to purchase something?");
    }
}

public class Farmer : INPC
{
    public void Speak()
    {
        Debug.Log("You reap what you sow...");
    }
}
