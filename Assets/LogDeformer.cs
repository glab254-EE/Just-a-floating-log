using UnityEngine;

public class LogDeformer : MonoBehaviour
{
    [SerializeField] private Transform Water;
    [SerializeField] private float GeneralWaterPower = 0.5f;
    [SerializeField] private float RotationXTimeSpeed = 1.3f;
    [SerializeField] private float RotationYTimeSpeed = 1.3f;
    [SerializeField] private float UpDownTimeSpeed = 1.5f;
    [SerializeField] private float UpDownAmmountMultiplier = 0.25f;
    [SerializeField] private float GeneralRotationPower = 5f;
    Vector3 basepos;
    void Start()
    {
        basepos = new Vector3(transform.position.x,Water.position.y,transform.position.z);
    }
    float tick = 0;
    void Update()
    {
        tick += Time.deltaTime;
        float rotx = Mathf.Sin(tick* RotationXTimeSpeed) * GeneralRotationPower * GeneralWaterPower;
        float roty = Mathf.Cos(tick* RotationYTimeSpeed) * GeneralRotationPower * GeneralWaterPower;
        float moveTD = Mathf.Sin(tick * UpDownTimeSpeed) * GeneralWaterPower* UpDownAmmountMultiplier;
        transform.rotation = Quaternion.Euler(rotx, 0, roty);
        transform.position = basepos + transform.up * moveTD;
    }
}
