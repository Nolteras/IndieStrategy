using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{



    //!!! ЛОГИКИ ИЗМЕНЕНИЯ РЕСУРСОВ, КАК И РАБОЧИХ, НЕТ !!!




    //Панели интерфейса. Каждой панели по состоянию и по айди
    [Header("Game Panels")]
    public GameObject CommandPanel;//id - 0
    //private bool MainPanOpen = true;
    public GameObject ResPanel;//id - 1
    private bool ResPanOpen = false;
    public GameObject WorkersPanel;//id - 2
    private bool WorkPanOpen = false;



    //Переменные основных ресурсов
    [Header("Main Resources")]
    public int Money = 0;
    public int Food = 0;
    public int Wood = 0;
    public int Stone = 0;
    public int Metal = 0;
    public int Cattle = 0;
    public int NatRes = 0;
    public int Equipment = 0;
    public int Plants = 0;


    //Переменные основных работ
    [Header("Main Workers")]
    public int Workers = 0;
    public int FoodWorkers = 0;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Скрипт открытия панелей. От переменной зависит, какой именно открывать
    public void OpenPanel(int Type)
    {
        if (ResPanOpen || WorkPanOpen)
        {
            return;//Если какая-то панель открыта, выходим
        }

        switch (Type)
        {
            case 0:
                return;//Нулевой айди у главной панели, она не должна закрываться
            case 1:
                ResPanel.SetActive(true);
                ResPanOpen = true;
                return;//Активируем первую панель
            case 2:
                WorkersPanel.SetActive(true);
                WorkPanOpen = true;
                return;//Активируем вторую панель
        }
    }

    //Скрипт закрытие панелей. От переменной зависит, какую именно закрывать
    public void ClosePanel(int Type)
    {

        switch (Type)
        {
            case 0:
                return;//Нулевой айди у главной панели, она не должна закрываться
            case 1:
                ResPanel.SetActive(false);
                ResPanOpen = false;
                return;//Закрываем первую панель
            case 2:
                WorkersPanel.SetActive(false);
                WorkPanOpen = false;
                return;//Закрываем вторую панель
        }
    }

}
