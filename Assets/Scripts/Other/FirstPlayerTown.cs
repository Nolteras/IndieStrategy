using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerTown : MonoBehaviour
{

    public GameObject CommandPanel;//Главная панель
    public GameObject GameLog;//Логика игры
    Vector3 PointFTown;//Координаты будущего города

    // Start is called before the first frame update
    void Start()
    {
        CommandPanel.SetActive(false);//Скрываем главную панель
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))//Как только происходит нажатие, получаем координаты, по которым сразу же ставим город
        {
            PointFTown = Input.mousePosition;
            Instantiate(GameLog.GetComponent<GameLogic>().tribe).transform.position = PointFTown;//Создаём первое поселение
            CommandPanel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
