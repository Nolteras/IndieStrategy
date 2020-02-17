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
    private bool MainPanOpen = false;
    public GameObject ResPanel;//id - 1
    private bool ResPanOpen = false;
    public GameObject WorkersPanel;//id - 2
    private bool WorkPanOpen = false;
    public GameObject StatePanel;//id - 3
    private bool StatPanOpen = false;
    public GameObject EventsPanel;//id - 4
    private bool EventPanOpen = false;
    public GameObject ArmyPanel;//id - 5
    private bool ArmyPanOpen = false;



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


    //Разные объекты
    [Header("Entities")]
    public GameObject tribe; 




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Скрипт для создания объектов
    public void CreateEntity(GameObject entity)
    {
        Instantiate(entity, gameObject.transform).transform.position = MousePosition();//Создаём энтити, делаем дочерним объектом "мира"
    }

    //Скрипт для получения позиции курсора
    private Vector3 MousePosition()
    {
        return Input.mousePosition;
    }


    //Скрипт открытия панелей. От переменной зависит, какой именно открывать
    public void OpenPanel(int Type)
    {
        if (MainPanOpen || ResPanOpen || WorkPanOpen || StatPanOpen || EventPanOpen || ArmyPanOpen)
        {
            return;//Если какая-то панель открыта, выходим
        }

        switch (Type)
        {
            case 0:
                CommandPanel.SetActive(true);
                MainPanOpen = true;
                return;//Используется один раз в самом начале
            case 1:
                ResPanel.SetActive(true);
                ResPanOpen = true;
                return;//Активируем первую панель
            case 2:
                WorkersPanel.SetActive(true);
                WorkPanOpen = true;
                return;//Активируем вторую панель
            case 3:
                StatePanel.SetActive(true);
                StatPanOpen = true;
                return;//Активируем третью панель
            case 4:
                EventsPanel.SetActive(true);
                EventPanOpen = true;
                return;//Активируем четвёртрую панель
            case 5:
                ArmyPanel.SetActive(true);
                ArmyPanOpen = true;
                return;
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
            case 3:
                StatePanel.SetActive(false);
                StatPanOpen = false;
                return;//Закрываем третью панель
            case 4:
                EventsPanel.SetActive(false);
                EventPanOpen = false;
                return;//Закрываем четвёртрую панель
            case 5:
                ArmyPanel.SetActive(false);
                ArmyPanOpen = false;
                return;
        }
    }

}
