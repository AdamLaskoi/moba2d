using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy_AI : MonoBehaviour
{
    [SerializeField] float movment_speed;

    [SerializeField] GameObject target;
    


  
    void Update()
    {
        Vector3 Myposition = transform.position;
        Vector3 tragetPoz = target.transform.position;
        Vector3 direction = Myposition - tragetPoz;
        Vector3 Velocity = direction* movment_speed * Time.deltaTime;
        transform.position = Velocity;
       
        

        transform.position = Velocity;
    }
}
