using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerTown : MonoBehaviour
{

    public GameObject CommandPanel;//Главная панель
    public GameObject GameLog;//Логика игры
    private GameObject Tribe;//Ссылка на город в Логике игры

    // Start is called before the first frame update
    void Start()
    {
    Tribe = GameLog.GetComponent<GameLogic>().tribe;
    CommandPanel.SetActive(false);//Скрываем главную панель
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))//Как только происходит нажатие, получаем координаты, по которым сразу же ставим город
        {
            GameLog.GetComponent<GameLogic>().CreateEntity(Tribe);//Создаём первое поселение
            CommandPanel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
