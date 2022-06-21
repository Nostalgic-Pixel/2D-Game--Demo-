# Overview

## *2D Game (Demo)*
## By: Joseph Wilson

![Image](Assets\Images\Unity.jpg)

### Description:
> This software is a 2D platformer demo that uses Unity and the C# language. In this software, the user has to learn how to apply teachings from C# and execute commands when connecting with the VS Code files and Unity when creating entities such as a player, platform, etc. 
```
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    // "awake" is called when the script instance is being laoded.
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // This is for movement (kind of like awake).
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y); // (x, y, z)

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);
    }
}
```

### Purpose:
> The purpose of this software is to help the users understand the basic concepts of using Unity and apply C# learning tools to create a simple 2D platformer game. This software is a fun way to experiment ideas and creativity when working with Unity and VS Code. 

# Development Environment

### Platform(s) used:
> 1. Visual Studio Code
> 2. Github
> 3. Unity

### Programming Language(s):
> 1. C#
> 2. Unity (platform terms/application)

### Youtube Video Link:
> [Hello World Demo Video](https://www.youtube.com/watch?v=1q8xlN7HwS8)

# Useful Websites

{Make a list of websites that you found helpful in this project}
* [Youtube](http://youtube.com)
* [Github](http://github.com)
* [Unity](http://unity.com)