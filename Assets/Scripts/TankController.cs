using UnityEngine;


public class TankController 
{
    private TankView tankView;
    private TankModel tankModel;

    private Rigidbody rb;

    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetComponent<Rigidbody>();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeTheColor(tankModel.color);
    }

    public void Move(float movement , float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed) 
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
