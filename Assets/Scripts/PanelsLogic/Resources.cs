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



    public GameObject MainPanel;//Главная Панель


    // Start is called before the first frame update
    void Start()
    {
        //Приравниваем счётчики к дейсвительному числу ресурсов. Так как изменения происходят 
        //только каждый ход, то менять их через Апдейт только в особых случаях
        WoodCo.text = MainPanel.GetComponent<GameLogic>().Wood.ToString();
        StoneCo.text = MainPanel.GetComponent<GameLogic>().Stone.ToString();
        FoodCo.text = MainPanel.GetComponent<GameLogic>().Food.ToString();
        MoneyCo.text = MainPanel.GetComponent<GameLogic>().Money.ToString();
        CattleCo.text = MainPanel.GetComponent<GameLogic>().Cattle.ToString();
        MetalCo.text = MainPanel.GetComponent<GameLogic>().Metal.ToString();
        PlantsCo.text = MainPanel.GetComponent<GameLogic>().Plants.ToString();
        NatResCo.text = MainPanel.GetComponent<GameLogic>().NatRes.ToString();
        EquipmentCo.text = MainPanel.GetComponent<GameLogic>().Equipment.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Код кнопки закрытия
    public void Close()
    {
        MainPanel.GetComponent<GameLogic>().ClosePanel(id);
    }

}
