# 3D World miniProject
# Marble racer


![Alt Text](https://jumpshare.com/s/u4U2R8dip3jotOMLar8S)

### Overview of the game

The idea of this game concept is a race to the finish line with mechanics inspired by Fallguys combined with marble racing. The idea is to take some of the obstacles from Fallguys and with the linear stage structure of a marble race, while also giving the player slight control over the ball but not too much as it is still a marble race. The genre of the game is a casual (obstacle) platformer.


The game consists of the following:

- **Player** - A ball, manipulated with WASD as you can only guide the ball with a gentle application of force.
- **Camera** - A camera that allows the player to follow the ball without getting nausea by preventing it from rotating with the ball player object.
- **Stage** - A linear stage that the player has to follow to the end to complete while weaving between obstacles.
- **Obstacles**  - Various obstacles to interchange positions or knock the player off the platform, stopping them from reaching the goal area.
- **Goal** - Once colliding with the goal the camera will be changed and a message congratulating the player is displayed.
- **Victory cam** - A view that the player gets to see once the Goal script is triggered.
- **Animation** - One of the obstacles namely the “Wrecking balls” seen on the 3 parts of the stage is made to move using animation, the animation is made by enabling and disabling the keyframe recorder and adding additional keyframes when needed.

**Running it requires the following**
- Download Unity >= 2022.3.8f1
- Clone or Download the project
- The game requires a computer with a keyboard

## Scripts:

- **BallController:** Used to control the ball character by allowing the player to apply force to the ball. 
- **CameraController:** Used to keep the camera on the player without rotating with the movement of the ball. 
- **FanSpin:** Makes the fans spin around themselves on the y-axis. 
- **BounceBackBumper:** Unleashes explosive force upon the player colliding with the object. 
- **WashingMachine:** Rotates the object around itself on the Z-Axis.
- **GoalCam:** Switches to the finish cam when the player reaches the goal line.

## Models and Prefabs:

Most things are made with primitives combined resulting in stages. I used Probuilder for its ability to make arcs, which seemed fitting for the tracks marbles run on in normal marble racing, and for making the final obstacle, the washing machine.


## Time Plan:

| Task                               | Time (hours) |
|------------------------------------|--------------|
| Creating project                   | 0.5          |
| Concept brainstorm and research    | 2.5          |
| Level creation                     | 3            |
| Obstacle prefabs                   | 2            |
| Terrain/ProBuilder learning        | 1            |
| ProBuilder level creation           | 0.5          |
| Player movement                    | 0.5          |
| Playing with gravity               | 0.5          |
| Combining player movement and gravity | 1          |
| Coding Bumper script               | 0.5          |
| WreckingBall animation             | 1            |
| Troubleshooting and fixing collision | 2          |
| Playtesting                        | 0.5          |
| Report                             | 1.5          |
| Read me                            | 0.5          |
| **Total**                          | **17.5**     |


References:

Ideas for mechanics
https://blog.hyperx.com/article/10654/all-maps-levels-and-minigames-in-fall-guys-ultimate-knockout

Create Bounce Bumper Game Mechanic in Unity https://www.youtube.com/watch?v=bdGn4J4HD_8

Texture for finish flag
https://www.vecteezy.com/vector-art/6628571-checkered-seamless-black-and-white-boxes-pattern-background-tablecloth-or-flag-racing-pattern-free-vector

ChatGPT
https://chat.openai.com/share/9164f6ca-5ace-4d53-b8a1-781841693ae2

Example project
https://github.com/IvanNik17/ExampleProjects/tree/main/Pi3D-Example%20Hand-in

Image source fallguys: https://www.google.com/url?sa=i&url=https%3A%2F%2Fstore.epicgames.com%2Fen-US%2Fp%2Ffall-guys&psig=AOvVaw1zOt63e7fwMj-8dPOEEEEm&ust=1701174653321000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCNicy8mX5IIDFQAAAAAdAAAAABAE

Image source marble: https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3DUI4FB-QKqI8&psig=AOvVaw0yphW96ng0V6hhixQTGFh7&ust=1701174805324000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCLidjJKY5IIDFQAAAAAdAAAAABAZ
