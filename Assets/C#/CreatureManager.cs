using System.Collections;
using System.Collections.Generic;
using Assg26;
using UnityEngine;

public class CreatureManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        List<Creature> creatures = new List<Creature>{
            new Kangroo(),
            new Duck()

        };

        List<IRunnable> runnables = new List<IRunnable>();
        List<IJumpable> jumpables = new List<IJumpable>();
        List<ISwimmable>swimmables = new List<ISwimmable>();

        Kangroo kangroo = new Kangroo() ;

        Duck duck = new Duck();

        runnables.Add(kangroo);
        jumpables.Add(kangroo);

        runnables.Add(duck);
        swimmables.Add(duck);

        foreach(Creature creature in creatures) {

            creature.Speak() ;
        }


        foreach(IRunnable runnable in runnables) {

            runnable.Run() ;
        }

        foreach( IJumpable jumpable in jumpables) {

            jumpable.Jump() ;
        }

        foreach(ISwimmable swimmable in swimmables) {

            swimmable.Swim();
        }




    }

    // Update is called once per frame
    void Update()
    {

    }
}
