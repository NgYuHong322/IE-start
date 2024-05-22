using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibleca2 : MonoBehaviour
{
    protected Player currenplayer;

    public virtual void Collect(Player player)
    {
        Debug.Log("hi");
        Destroy(gameObject);
    }

}
