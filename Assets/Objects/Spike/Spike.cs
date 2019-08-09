using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : TriggerAction
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PlayerTriggered(Player p)
    {
        lc.KillPlayer();
    }
}
