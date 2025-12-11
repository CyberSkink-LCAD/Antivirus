using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambience : MonoBehaviour
{
    public Collider Area;
    public GameObject Player;
    
    void Update()
    {
        Vector3 closestpPoint = Area.ClosestPoint(Player.transform.position);
        transform.position = closestpPoint;
        
    }
}
