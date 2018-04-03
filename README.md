# AI-Shooting
This program is showing how to make an AI unit find and shoots its target. This is very common in all kinds of video games. Therefore, I made it as a reference for future's developments.

Platform: Unity 3D Game Engine

Language: C#

Goal: AI unit finds and shoots its target

Step1: Setup the shooter and targets' game objects.

Step2: Create an empty game object and rename it as the enemy list.

Step3: Every time a target object is spawned, add it to the enemy list.

Step4: The shooter uses a for loop to get the distance to every enemy target. Store the closet one as the current target as the shooter.

Step5: Rotate the shooter toward its target and shoot.

Step7: If enemies get hit by a bullet, destroy the enemy's game object. And remove it from the enemy list.

See the code for detailed info.
