using UnityEngine;

public class Player_Control : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 5;
    [SerializeField] float JumpForce = 5;
    


    private void Update()
    {
        bool Akey = Input.GetKey(KeyCode.A); //Left
        bool Dkey = Input.GetKey(KeyCode.D);//right
        bool Ekey = Input.GetKey(KeyCode.E);//Action
        bool spacekey = Input.GetKey(KeyCode.Space); //Combat
        bool crtlkey = Input.GetKey(KeyCode.LeftControl); // Defenz
        Vector2 MyPozition = transform.position; // jelenlegi pozició
        
        float y = 0;
        float x = 0;
    
        if (Akey)
            x -= 1;
        if (Dkey)
            x += 1;


        Vector2 rightdir = transform.right;
        Vector2 direction = new Vector2(x,y);
        Vector2 velocity = direction * MovementSpeed;
        MyPozition += velocity * Time.deltaTime;
        direction.y = 0;
        transform.position = MyPozition;
         
    }




}
