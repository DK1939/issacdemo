using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinui : MonoBehaviour
{

    public int startcoin;
    public Text coinnumber;
    public static int currentcoinnum;
    // Start is called before the first frame update
    void Start()
    {
        currentcoinnum = startcoin;
    }

    // Update is called once per frame
    void Update()
    {
        coinnumber.text = currentcoinnum.ToString();
    }
}
