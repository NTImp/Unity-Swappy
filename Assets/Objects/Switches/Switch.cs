using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : TriggerAction
{
    public bool Red = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PlayerTriggered(Player p)
    {
        if (Red) p.TurnRed();
        else p.TurnBlue();
    }
}
