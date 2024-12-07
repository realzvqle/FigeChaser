module mainmenu

open types
open Raylib_cs




let mainMenu (gameState: gameState) =
    Raylib.DrawText("FigeChaser", (int (Raylib.GetScreenWidth()) - Raylib.MeasureText("FigeChaser", 70)) / 2, (int (Raylib.GetScreenHeight()) - 70) / 2, 70, Color.WHITE)
    Raylib.DrawText("Press Space To Start", (int (Raylib.GetScreenWidth()) - Raylib.MeasureText("Press Space To Start", 40)) / 2, ((int (Raylib.GetScreenHeight()) - 40) / 2) + 90, 40, Color.BLUE)
    Raylib.DrawText("Build PROTOTYPE -|- (c) zvqle, All Rights Reserved", 10, 10, 20, Color.GOLD)
    if Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) = true then 
        gameState.sceneManager <- 1

