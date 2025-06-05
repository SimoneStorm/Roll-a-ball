---
title: "Blog 1 Roll-a-ball"
author: "Simone Storm Kristensen"
date: "11-03-2024"
version: "0.1"
---

# Setting up the Game

For this project, I used Unity 2022.3.19f1 with the "3D URP" project template.

I started by setting up the game environment with a board and maze made up of cubes. The board acts as the base, and the walls are built using individual cube objects to create a challenging maze layout.

To create a unique theme, I used the "Skybox Series Free" asset pack and selected the "Cosmic" skybox.

For the player/ball, I created a sphere and turned it into a shooting star by adding a Trail Renderer component. 

![Game Scene](/GameScene.png)

#Player controller
To make the player move, I created a simple script that uses Unity's new Input System. The `PlayerController` script listens for input and applies force to a Rigidbody component attached to the player. At the beginning, the `Start()` method gets a reference to the Rigidbody. Then, whenever the player presses a movement key (like WASD or the arrow keys), the `OnMove()` method is triggered, which updates the movement values based on the input. In the `FixedUpdate()` method, these values are used to create a Vector3 movement direction, which is applied to the Rigidbody as a force. 

Here’s the script I made:

```csharp
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; 
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    void FixedUpdate() 
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement); 
    }
}

```
#Conslusion/Idea
To wrap things up, my goal was simply to create a small and fun game. I’ve always liked space, so I wanted to bring that feeling into the game. The core idea was to turn a rolling ball into a shooting star that moves through the galaxy, avoiding obstacles and navigating a challenging path. Even though it’s a simple concept, I had fun building it and learning more about Unity along the way.



