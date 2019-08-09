using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMovement pm;
    public LevelController lc;

    public GameObject redSpr, blueSpr;

    public Animator animatorRed;
    public Animator animatorBlue;

    // Start is called before the first frame update
    void Start()
    {
        lc = GameObject.Find("Main Camera").GetComponent<LevelController>();
        pm = gameObject.GetComponent<PlayerMovement>();
        TurnRed();

    }

    public void TurnRed()
    {
        pm.red = true;
        redSpr.SetActive(true);
        blueSpr.SetActive(false);
    }

    public void TurnBlue()
    {
        pm.red = false;
        redSpr.SetActive(false);
        blueSpr.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        pm.Active = !lc.Paused;
        if(!lc.Paused)
        {
            UpdatePlaying();
            if (Input.GetKeyDown(KeyCode.R))
            {
                lc.KillPlayer();
            }
        } else
        {
            animatorBlue.speed = 0;
            animatorRed.speed = 0;
        }
    }

    void UpdatePlaying()
    {
        PlayerMovingState state = pm.MovingState;

        animatorBlue.speed = 1;
        animatorRed.speed = 1;

        if (!pm.FacingRight)
        {
            redSpr.transform.localScale = new Vector3(-1, 1, 1);
            blueSpr.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (pm.FacingRight)
        {
            blueSpr.transform.localScale = new Vector3(1, 1, 1);
            redSpr.transform.localScale = new Vector3(1, 1, 1);
        }

        if (state == PlayerMovingState.Iddle)
        {
            animatorRed.SetBool("Jumping", false);
            animatorRed.SetBool("Moving", false);

            animatorBlue.SetBool("Jumping", false);
            animatorBlue.SetBool("Running", false);
        }
        else if (state == PlayerMovingState.Moving)
        {
            animatorRed.SetBool("Jumping", false);
            animatorRed.SetBool("Moving", true);

            animatorBlue.SetBool("Jumping", false);
            animatorBlue.SetBool("Running", true);
        }
        else if (state == PlayerMovingState.Jumping)
        {
            animatorRed.SetBool("Jumping", true);

            animatorBlue.SetBool("Jumping", true);
        }
    }
}
