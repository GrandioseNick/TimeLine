using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorAction
{
    //public void Simulate();
}

public sealed class ActorMoveAction : ActorAction
{

    public ActorMoveAction(Vector2Int from, Vector2Int to)
    {

    }

    public void Simulate()
    {
        Debug.Log("We are going to simulate this move now");
    }
}
