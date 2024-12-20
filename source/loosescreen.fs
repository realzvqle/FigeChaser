﻿module loosescreen

open Raylib_cs
open types
open player
open enemy
open target



let looseMenu (gameState: gameState) =
    Raylib.DrawText("You Loose!", (int (Raylib.GetScreenWidth()) - Raylib.MeasureText("You Loose!", 70)) / 2, (int (Raylib.GetScreenHeight()) - 70) / 2, 70, Color.RED)
    Raylib.DrawText(string gameState.counter, (int (Raylib.GetScreenWidth()) - Raylib.MeasureText(string gameState.counter, 30)) / 2, (int (Raylib.GetScreenHeight()) - 70) / 2 + 90, 30, Color.GOLD)
    Raylib.DrawText("Press Space To Restart", (int (Raylib.GetScreenWidth()) - Raylib.MeasureText("Press Space To Restart", 20)) / 2, ((int (Raylib.GetScreenHeight()) - 40) / 2) + 120, 20, Color.WHITE)
    if Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) = true then 
        playerSetup gameState.player
        enemySetup gameState.enemy
        targetSetup gameState.target
        gameState.counter <- 0
        gameState.sceneManager <- 1
