module checkCollision



open types
open Raylib_cs

let checkDistance (first: transform) (second: transform) : float32 =
    let deltaX = first.x - second.x
    let deltaY = first.y - second.y
    let distance = sqrt(deltaX * deltaX + deltaY * deltaY)

    distance


let checkCollision(first: transform) (second: transform) (third: transform) (gameState: gameState) =
    if checkDistance first third < 35f then
        gameState.target.position.x <- float32(Raylib.GetRandomValue(0, Raylib.GetScreenWidth()))
        gameState.target.position.y <- float32(Raylib.GetRandomValue(0, Raylib.GetScreenHeight()))
        gameState.counter <- gameState.counter + 1
    if checkDistance first second < 35f then
        gameState.sceneManager <- 2
        gameState.enemy.speed <- 200f
    if checkDistance second third < 35f then
        gameState.sceneManager <- 2 
        gameState.enemy.speed <- 200f

        
        