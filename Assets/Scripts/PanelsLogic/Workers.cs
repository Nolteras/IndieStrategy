using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Workers : MonoBehaviour
{

    //Ссылки на счётчики
    [Header("Counters")]
    public Text AllWorkersCo;
    public Text FoodWorkersCo;

    private const int id = 2;


    public GameObject GameLogic;//Игровая логика


    // Start is called before the first frame update
    void Start()
    {
        //Приравниваем счётчики к дейсвительному числу ресурсов. Так как изменения происходят 
        //только каждый ход, то менять их через Апдейт только в особых случаях
        AllWorkersCo.text = GameLogic.GetComponent<GameLogic>().Workers.ToString();
        FoodWorkersCo.text = GameLogic.GetComponent<GameLogic>().FoodWorkers.ToString();
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
