using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOut : MonoBehaviour {

    public GameObject[] FoodOrder;
    public GameObject[] PrintOrder;

    public void OrderFood1()
    {
        FoodOrder[0].SetActive(true);
        PrintOrder[0].SetActive(true);
    }

    public void OrderFood2()
    {
        FoodOrder[1].SetActive(true);
        PrintOrder[1].SetActive(true);
    }

    public void OrderFood3()
    {
        FoodOrder[2].SetActive(true);
        PrintOrder[2].SetActive(true);
    }

    public void OrderFood4()
    {
        FoodOrder[3].SetActive(true);
        PrintOrder[3].SetActive(true);
    }

    public void OrderFood5()
    {
        FoodOrder[4].SetActive(true);
        PrintOrder[4].SetActive(true);
    }

    public void OrderFood6()
    {
        FoodOrder[5].SetActive(true);
        PrintOrder[5].SetActive(true);
    }

    public void OrderFood7()
    {
        FoodOrder[6].SetActive(true);
        PrintOrder[6].SetActive(true);
    }

    public void OrderFood8()
    {
        FoodOrder[7].SetActive(true);
        PrintOrder[7].SetActive(true);
    }

    public void OrderFood9()
    {
        FoodOrder[8].SetActive(true);
        PrintOrder[8].SetActive(true);
    }

    public void ClearFoodOrder()
    {
        FoodOrder[0].SetActive(false);
        FoodOrder[1].SetActive(false);
        FoodOrder[2].SetActive(false);
        FoodOrder[3].SetActive(false);
        FoodOrder[4].SetActive(false);
        FoodOrder[5].SetActive(false);
        FoodOrder[6].SetActive(false);
        FoodOrder[7].SetActive(false);
        FoodOrder[8].SetActive(false);

        PrintOrder[0].SetActive(false);
        PrintOrder[1].SetActive(false);
        PrintOrder[2].SetActive(false);
        PrintOrder[3].SetActive(false);
        PrintOrder[4].SetActive(false);
        PrintOrder[5].SetActive(false);
        PrintOrder[6].SetActive(false);
        PrintOrder[7].SetActive(false);
        PrintOrder[8].SetActive(false);
    }

}
