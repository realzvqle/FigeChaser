module pause



open Raylib_cs
open types
open player
open enemy
open target



let pauseMenu (gameState: gameState) =
    Raylib.DrawText("Paused", (int gameState.window.size.x - Raylib.MeasureText("Paused", 70)) / 2, (int gameState.window.size.y - 70) / 2, 70, Color.GREEN)
    Raylib.DrawText(string gameState.counter, (int gameState.window.size.x - Raylib.MeasureText(string gameState.counter, 30)) / 2, (int gameState.window.size.y - 70) / 2 + 90, 30, Color.GOLD)
    Raylib.DrawText("Press Space To Continue", (int gameState.window.size.x - Raylib.MeasureText("Press Space To Continue", 20)) / 2, ((int gameState.window.size.y - 40) / 2) + 120, 20, Color.WHITE)
    if Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) = true then 
        gameState.sceneManager <- 1