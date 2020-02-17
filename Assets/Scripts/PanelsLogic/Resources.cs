using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
    //Ссылки на счётчики
    [Header("Counters")]
    public Text MoneyCo;
    public Text FoodCo;
    public Text StoneCo;
    public Text WoodCo;
    public Text CattleCo;
    public Text MetalCo;
    public Text PlantsCo;
    public Text NatResCo;
    public Text EquipmentCo;




    private const int id = 1;



    public GameObject GameLogic;//Игровая логика


    // Start is called before the first frame update
    void Start()
    {
        //Приравниваем счётчики к дейсвительному числу ресурсов. Так как изменения происходят 
        //только каждый ход, то менять их через Апдейт только в особых случаях
        WoodCo.text = GameLogic.GetComponent<GameLogic>().Wood.ToString();
        StoneCo.text = GameLogic.GetComponent<GameLogic>().Stone.ToString();
        FoodCo.text = GameLogic.GetComponent<GameLogic>().Food.ToString();
        MoneyCo.text = GameLogic.GetComponent<GameLogic>().Money.ToString();
        CattleCo.text = GameLogic.GetComponent<GameLogic>().Cattle.ToString();
        MetalCo.text = GameLogic.GetComponent<GameLogic>().Metal.ToString();
        PlantsCo.text = GameLogic.GetComponent<GameLogic>().Plants.ToString();
        NatResCo.text = GameLogic.GetComponent<GameLogic>().NatRes.ToString();
        EquipmentCo.text = GameLogic.GetComponent<GameLogic>().Equipment.ToString();
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
