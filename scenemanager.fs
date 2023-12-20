module scenemanager

open Raylib_cs
open types
open mainmenu
open gameloop
open loosescreen
open pause


let SceneManager(gameState: gameState) =
    // printfn "[!] In Scene %d" gameState.sceneManager
    match gameState.sceneManager with
        | 0 -> mainMenu gameState
        | 1 -> gameLoop gameState
        | 2 -> looseMenu gameState
        | 3 -> pauseMenu gameState
        | _ -> Raylib.DrawText("INVALID SCENE, PLEASE CONTACT ZVQLE!", 10, 10, 70, Color.BLUE)
