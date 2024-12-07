module window

open types
open Raylib_cs
open scenemanager
open player
open enemy
open target



let WindowSetup (window: window) =
    window.size.x <- 1600.0f
    window.size.y <- 900.0f
    window.name <- "FigeChaser"

    



let StartWindow (gameState: gameState) =
    WindowSetup gameState.window
    Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE)
    Raylib.SetTraceLogLevel(TraceLogLevel.LOG_ERROR)
    Raylib.InitWindow(int gameState.window.size.x, int gameState.window.size.y, gameState.window.name)
    Raylib.SetWindowIcon(Raylib.LoadImage("icon.png"))
    Raylib.SetExitKey(KeyboardKey.KEY_Q)
    printfn "[+] Started Window"
    Raylib.SetTargetFPS(60)
    playerSetup gameState.player
    enemySetup gameState.enemy
    targetSetup gameState.target
    while not (Raylib.WindowShouldClose()) do
        Raylib.BeginDrawing()
        SceneManager gameState
        Raylib.ClearBackground(Color.BLACK)

        Raylib.EndDrawing()

    Raylib.CloseWindow()


    
