# FlappyBird--Unity3D-2022 :

Game made during my bachelor 3 year (2022/2023) for a Unity3D module at Ynov Bordeaux.

## Summary :

- Presentation
- Game keys
- Main mechanics
- How to open the project
- How to build the project

## Presentation :

In this flappy bird realized under unity, you will have to **dodge the pipes which arrives** not your right while pressing on the space key. The pipes can arrive with different heights. **You score points** when you manage to cross pipes **without colliding with one**, if you **collide with one**, **you lose**.

![](https://i.imgur.com/VMR7sgS.png)

![](https://i.imgur.com/elKRdOZ.png)

![](https://i.imgur.com/tqoTHiG.png)

## Game keys :

- _Movement_:

  - Give the impulse to fly : **Space**

- _Pause menu_:
  - Pause the game: **Escape**

## Main mechanics :

### Avoiding incoming pipes :

You must **avoid colliding with the pipes coming** from the right by **passing in the free space** in the middle. Beware that this one **can arrive at different heights**.

## How to open the project :

- Clone the git repository to your computer with the following command :

```
git@github.com:LeoSery/FlappyBird--Unity3D-2022.git
```

or

```
https://github.com/LeoSery/FlappyBird--Unity3D-2022.git
```

- open Unity Hub and do "_Add project from disk_"

  Select "`..\FlappyBird--Unity3D-2022`"

- Check that the project opens with the Unity editor in version "**2022.1.21f1**"

## How to build the project :

- Once the project is open in Unity, do _"File" > "Build Settings"_

- In the window that has just appeared, in the _"Scenes In Build"_ section, make sure that _"scenes/Game"_ is checked.

- for the platform choose: _"PC, Mac & Linux Standalone"_

- then choose your platform in _"Target Platform"_

- and finally press _"Build And Run"_
