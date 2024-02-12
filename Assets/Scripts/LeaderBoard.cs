using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    public Text AllScores;

    // Start is called before the first frame update
    void Start()
    {
        AllScores.text = GameHandler.instance.player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
