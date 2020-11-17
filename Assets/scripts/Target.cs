using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 10f;
    public ExplosiveBarrelScript boolBoy;
    public TimeController timeStopScript;

  
    public DWGDestroyer wallDestroyer;
    [SerializeField]
    private string ObstacleType;


    void Start()
    {
        

        ExplosiveBarrelScript g = GetComponent<ExplosiveBarrelScript>();
        timeStopScript = FindObjectOfType<TimeController>();//Find("Canvas").GetComponent<TimeController>();//GetComponent<TimeController>();
        //print(timeStopScript);
       
        DWGDestroyer h = GetComponent<DWGDestroyer>();

        //boolBoy = g.GetComponent<ExplosiveBarrelScript> ();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && ObstacleType == "ExplosiveBarrel")
        {
            ExplodeBarrel();
        }

        else if (health <= 0f && ObstacleType == "EnemyTarget")
        {
            //TimeController timeStopScript = GameObject.Find("Canvas").GetComponent<TimeController>();//GetComponent<TimeController>();
            // print(timeStopScript);
            
            timeStopScript.ReduceEnemyCounter();
            die();
            // timeStopScript.ReduceEnemyCounter();//ReduceEnemyCounter();
            

        }

        else if (health <=0f && ObstacleType == "DestroyableWall")
        {
            //DWGDestroyer.OnTriggerEnter();
        }


    }

    void ExplodeBarrel()
    {
        boolBoy.explode = true;
        //Destroy(gameObject);

    }

    void die()
    {
        Destroy(gameObject);
    }


    void Update()
    {

    }

}
    