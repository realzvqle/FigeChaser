module loosescreen

open Raylib_cs
open types
open player
open enemy
open target



let looseMenu (gameState: gameState) =
    Raylib.DrawText("You Loose!", (int gameState.window.size.x - Raylib.MeasureText("You Loose!", 70)) / 2, (int gameState.window.size.y - 70) / 2, 70, Color.RED)
    Raylib.DrawText(string gameState.counter, (int gameState.window.size.x - Raylib.MeasureText(string gameState.counter, 30)) / 2, (int gameState.window.size.y - 70) / 2 + 90, 30, Color.GOLD)
    Raylib.DrawText("Press Space To Restart", (int gameState.window.size.x - Raylib.MeasureText("Press Space To Restart", 20)) / 2, ((int gameState.window.size.y - 40) / 2) + 120, 20, Color.WHITE)
    if Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) = true then 
        playerSetup gameState.player
        enemySetup gameState.enemy
        targetSetup gameState.target
        gameState.counter <- 0
        gameState.sceneManager <- 1
