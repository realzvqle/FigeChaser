module enemy

open types
open Raylib_cs

let enemySetup (enemy: enemy) =
    enemy.color <- Color.RED
    enemy.position.x <- 1600.0f / 3.0f
    enemy.position.y <- 900.0f / 3.0f
    enemy.size.x <- 30f
    enemy.size.y <- 30f


    

    
let drawEnemy (enemy: enemy) =
    Raylib.DrawRectangle(int enemy.position.x,int enemy.position.y, int enemy.size.x, int enemy.size.y, enemy.color)



let followY (first: transform) (second: transform) (gameState: gameState) =
    let speed = gameState.enemy.speed * Raylib.GetFrameTime()
    let targetY = second.y
    match compare first.y targetY with
    | 0 -> printfn "Equal Y wise"
    | c when c < 0 -> first.y <- min (first.y + speed) targetY
    | c when c > 0 -> first.y <- max (first.y - speed) targetY
    | _ -> ()




let followX (first: transform) (second: transform) (gameState: gameState) =
    let speed = gameState.enemy.speed * Raylib.GetFrameTime()
    let targetX = second.x
    match compare first.x targetX with
    | 0 -> printfn "Equal X wise"
    | c when c < 0 -> first.x <- min (first.x + speed) targetX
    | c when c > 0 -> first.x <- max (first.x - speed) targetX
    | _ -> ()



