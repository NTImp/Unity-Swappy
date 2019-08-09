using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAction : MonoBehaviour
{
    protected LevelController lc;

    // Start is called before the first frame update
    public void Start()
    {
        lc = GameObject.Find("Main Camera").GetComponent<LevelController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void PlayerTriggered(Player p)
    {

    }
}
