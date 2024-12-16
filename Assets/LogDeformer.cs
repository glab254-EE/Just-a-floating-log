using UnityEngine;

public class LogDeformer : MonoBehaviour
{
    [SerializeField] Transform water;
    [SerializeField] float wavepower;
    float rotxdif = 1f;
    float rotydif = 1f;
    Vector3 basepos;
    void Start()
    {
        basepos = new Vector3(transform.position.x,water.position.y,transform.position.z);
        rotxdif = Random.Range(0.8f, 1.4f);
        rotydif = Random.Range(0.8f, 1.4f);
    }
    float tick = 0;
    private void Update()
    {
        tick += Time.deltaTime;
        float rotx = Mathf.Sin(tick*rotxdif)*5* wavepower;
        float roty = Mathf.Cos(tick*rotydif)*5* wavepower;
        float moveTD = Mathf.Sin(tick * 1.5f)* wavepower*0.25f;
        transform.rotation = Quaternion.Euler(rotx, 0, roty);
        transform.position = basepos + transform.up * moveTD;
    }
}
