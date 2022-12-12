using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Maze;

public class Temp : MonoBehaviour
{
    struct User
    {
        public string name;
        public int health;
        public int id;
    }

    public delegate int TestDelegate(int val1, int val2);

    public TestDelegate summ;
    public TestDelegate substraction;
    public TestDelegate divide;
    public TestDelegate multiply;

    static int SomeMethod1(int a, int b)
    {
        Debug.Log("sum: " + (a + b));
        return a + b;
    }

    static int SomeMethod2(int a, int b)
    {
        Debug.Log("substraction: " + (a - b));
        return a + b;
    }

    static int SomeMethod3(int a, int b)
    {
        Debug.Log("divide: " + (a / b));
        return a + b;
    }

    static int SomeMethod4(int a, int b)
    {
        Debug.Log("multiply: " + (a * b));
        return a + b;
    }

    void Start()
    {
        User user1 = new User();
        user1.name = "Imperator";
        user1.health = 99;
        Debug.Log(user1.name);

        summ = SomeMethod1;
        substraction = SomeMethod2;
        divide = SomeMethod3;
        multiply = SomeMethod4;

        divide += SomeMethod1;
        divide += SomeMethod2;
        divide += SomeMethod3;
        divide += SomeMethod4;

        divide -= SomeMethod3;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) 
        {
            int temp = divide.Invoke(100, 50);
            Debug.Log(temp);
            temp = divide.Invoke(100, 50);
        }
    }
}
