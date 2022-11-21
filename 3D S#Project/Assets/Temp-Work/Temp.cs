using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewUser
{
    private string _name;
    private int _health;
    private int _id;

    public NewUser(string name, int health, int id)
    {
        Name = name;
        Health = health;
        Id = id;
        Debug.Log(Name);

    }

    public string Name 
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }
    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            if(value <= 100&&value >= 0)
            {
                _health = value;
            }
            else
            {
                Debug.Log("Wrong Number");
            }
        }
    }
    public int Id { get => _id; set => _id = value; }

    public void Move()
    {

    }
}

public class Temp : MonoBehaviour
{
    struct User
    {
        public string name;
        public int health;
        public int id;
    }

    NewUser myClass;

    void Start()
    {
        User user1= new User();
        user1.name = "Imperator";
        user1.health = 99;
        Debug.Log(user1.name);

        myClass = new NewUser("My Imperator", 200, 1);
        myClass.Health = 999;
    }

    void Update()
    {
        
    }
}
