open window
open types
open Raylib_cs





[<EntryPoint>]
let main argv =

    printfn "--------------------------------------------------------"
    printfn "FigeChaser Debug Console, (c) zvqle, All Rights Reserved"
    printfn "--------------------------------------------------------"

    let mutable window: window = {size = {x = 0f; y = 0f;}; name = ""}
    let mutable player: player = {size = {x = 0f; y = 0f;}; color=Color.BLUE; position = {x = 0f; y = 0f;}}
    let mutable enemy: enemy = {size = {x = 0f; y = 0f;}; color=Color.BLUE; position = {x = 0f; y = 0f;}; speed = 200f}
    let mutable target: target = {size = {x = 0f; y = 0f;}; color=Color.BLUE; position = {x = 0f; y = 0f;}}



    let mutable gameState = {player=player; window = window; enemy = enemy; target = target; sceneManager = 0; counter = 0}

    StartWindow gameState

    printfn "[+] Closed Window"

    0
