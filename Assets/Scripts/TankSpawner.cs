using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public TankTypes tankType;
        public float movementSpeed;
        public float rotationSpeed;
        public Material color;
    }
    public List<Tank> tankList;

    public TankView tankView;

    void Start()
    {
      
    }

    public void CreateTank(TankTypes tankTypes)
    {
        if(tankTypes ==TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankTypes == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankTypes == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
    }

}
