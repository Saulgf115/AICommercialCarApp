using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{

    [SerializeField] GameObject[] carList;
    [SerializeField] int currentCar = 0;
    //public List<>

    // Start is called before the first frame update
    void Start()
    {
        carList = new GameObject[transform.childCount];


        //loop through the child ietms and fill the list in the correct slots
        for(int i=0;i<transform.childCount;i++)
        {
            carList[i] = transform.GetChild(i).gameObject;
        }

        //deactivate all the game objects in the list
        foreach(GameObject obj in carList)
        {
            obj.SetActive(false);
        }


        //set the inital game object in active
        if(carList[0])
        {
            carList[0].SetActive(true);
        }
    }

    public void ToggleCars(string direction)
    {
        carList[currentCar].SetActive(false);

        if(direction == "Right")
        {
            currentCar++;

            if(currentCar > carList.Length - 1)
            {
                currentCar = 0;
            }


        }
        else if(direction == "Left")
        {
            currentCar--;

            if(currentCar < 0)
            {
                currentCar = carList.Length - 1;
            }

        }

        //set the current car to be activate from the list
        carList[currentCar].SetActive(true);


    }
}
