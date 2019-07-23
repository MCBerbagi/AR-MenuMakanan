using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Ingredient1, Ingredient2, Ingredient3, Ingredient4, Ingredient5, Ingredient6, Ingredient7, Ingredient8, Ingredient9;

    public GameObject FoodInfo1, FoodInfo2, FoodInfo3, FoodInfo4, FoodInfo5, FoodInfo6, FoodInfo7, FoodInfo8, FoodInfo9;

    // Set Aktif Nonaktif Objek
    public GameObject Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7, Scene8, Scene9;

    //Variable Array Game Object
    public GameObject[] object3D = new GameObject[9];
    public int no = 1;

    void Start()
    {
        object3D[0] = Scene1;
        object3D[1] = Scene2;
        object3D[2] = Scene3;
        object3D[3] = Scene4;
        object3D[4] = Scene5;
        object3D[5] = Scene6;
        object3D[6] = Scene7;
        object3D[7] = Scene8;
        object3D[8] = Scene9;

    }

    public void SwitchNextObject()
    {
        NextObject();
    }

    public void SwitchPrevObject()
    {
        PrevObject();
    }

    private void NextObject()
    {
        if (no < 9)
        {
            no++;
        }
    }

    private void PrevObject()
    {
        if (no > 1)
        {
            no--;
        }
    }

    void Update()
    {
        if (no == 1)
        {
            Scene1.SetActive(true);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(true);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(true);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 2)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(true);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(true);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(true);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 3)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(true);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(true);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(true);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 4)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(true);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(true);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(true);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 5)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(true);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(true);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(true);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 6)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(true);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(true);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(true);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 7)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(true);
            Scene8.SetActive(false);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(true);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(true);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(false);

        }

        if (no == 8)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(true);
            Scene9.SetActive(false);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(true);
            Ingredient9.SetActive(false);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(true);
            FoodInfo9.SetActive(false);

        }

        if (no == 9)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(false);
            Scene3.SetActive(false);
            Scene4.SetActive(false);
            Scene5.SetActive(false);
            Scene6.SetActive(false);
            Scene7.SetActive(false);
            Scene8.SetActive(false);
            Scene9.SetActive(true);

            Ingredient1.SetActive(false);
            Ingredient2.SetActive(false);
            Ingredient3.SetActive(false);
            Ingredient4.SetActive(false);
            Ingredient5.SetActive(false);
            Ingredient6.SetActive(false);
            Ingredient7.SetActive(false);
            Ingredient8.SetActive(false);
            Ingredient9.SetActive(true);

            FoodInfo1.SetActive(false);
            FoodInfo2.SetActive(false);
            FoodInfo3.SetActive(false);
            FoodInfo4.SetActive(false);
            FoodInfo5.SetActive(false);
            FoodInfo6.SetActive(false);
            FoodInfo7.SetActive(false);
            FoodInfo8.SetActive(false);
            FoodInfo9.SetActive(true);

        }

    }

    public void Scene1Aktif()
    {
        if (no > 1)
        {
            no = 1;
        }
    }

    public void Scene2Aktif()
    {
        if (no < 9)
        {
            no = 2;
        }

    }

    public void Scene3Aktif()
    {
        if (no < 9)
        {
            no = 3;
        }
    }

    public void Scene4Aktif()
    {
        if (no < 9)
        {
            no = 4;
        }
    }

    public void Scene5Aktif()
    {
        if (no < 9)
        {
            no = 5;
        }
    }

    public void Scene6Aktif()
    {
        if (no < 9)
        {
            no = 6;
        }
    }

    public void Scene7Aktif()
    {
        if (no < 9)
        {
            no = 7;
        }
    }

    public void Scene8Aktif()
    {
        if (no < 9)
        {
            no = 8;
        }
    }

    public void Scene9Aktif()
    {
        if (no < 9)
        {
            no = 9;
        }
    }

}
