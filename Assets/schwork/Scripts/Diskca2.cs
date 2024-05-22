using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diskca2 : Collectibleca2
{
    public override void Collect(Player player)
    {
        Debug.Log("bye");
        base.Collect(player); 
    }
}
