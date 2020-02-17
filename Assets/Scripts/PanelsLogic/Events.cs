using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{

    private const int id = 4;


    public GameObject GameLogic;//Игровая логика

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Код кнопки закрытия
    public void Close()
    {
        GameLogic.GetComponent<GameLogic>().ClosePanel(id);
    }
}
