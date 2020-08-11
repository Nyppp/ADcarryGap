using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlggagiManager : MonoBehaviour
{
    public static bool shoot = false;
    public enum Turn {BlackEgg, WhiteEgg };
    public static Turn turn = Turn.BlackEgg;

    private int BlackEggnum = 5;
    private int WhiteEggnum = 5;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AlggagiManager.turn == AlggagiManager.Turn.BlackEgg)
        {
            if(Drag.Egg.tag == "BlackEgg")
            {
                shoot = true;
                turn = Turn.WhiteEgg;
                Debug.Log(turn);
            }
        }

        if(AlggagiManager.turn == AlggagiManager.Turn.WhiteEgg)
        {
            if (Drag.Egg.tag == "WhiteEgg")
            {
                shoot = true;
                turn = Turn.BlackEgg;
                Debug.Log(turn);
            }
        }
    }

    
}
