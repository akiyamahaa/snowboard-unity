using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoreScript : MonoBehaviour
{
    public PlayerScript player;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindWithTag("Player"))
        {
            player = GameObject.FindWithTag("Player").GetComponent<PlayerScript>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player"))
        {
            GetComponent<TextMeshProUGUI>().SetText(player.points.ToString());
        }
    }
}
