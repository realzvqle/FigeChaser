module gameloop


open types
open Raylib_cs
open player
open enemy
open target
open checkCollision

let gameLoop (gameState: gameState) =
    drawPlayer gameState.player
    playerControl gameState.player
    checkPlayerBorder gameState.player
    drawTarget gameState.target
    if checkDistance gameState.enemy.position gameState.target.position < checkDistance gameState.enemy.position gameState.player.position  then
        followY gameState.enemy.position gameState.target.position gameState
        followX gameState.enemy.position gameState.target.position gameState
    else
        followY gameState.enemy.position gameState.player.position gameState
        followX gameState.enemy.position gameState.player.position gameState
        
    if Raylib.IsKeyDown(KeyboardKey.KEY_ESCAPE) = true then 
        gameState.sceneManager <- 3
    drawEnemy gameState.enemy
    checkCollision gameState.player.position gameState.enemy.position gameState.target.position gameState
   
       
        
        
       
    Raylib.DrawText(string gameState.counter, (Raylib.GetScreenWidth()) / 2, 10, 40, Color.PINK);
   
        
    
    
    //enemyControl enemy
    
    

   




// x = -7, 1577
// y = -7, 868