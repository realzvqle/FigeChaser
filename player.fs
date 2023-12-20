module player


open types
open Raylib_cs




let playerSetup (player: player) =
    player.color <- Color.BLUE
    player.position.x <- 1600.0f / 2.0f
    player.position.y <- 900.0f / 2.0f
    player.size.x <- 30f
    player.size.y <- 30f
    //player.rect = Rectangle(player.position.x, player.position.y, player.size.x, player.size.y)


    

    
let drawPlayer (player: player) =
    Raylib.DrawRectangle(int player.position.x,int player.position.y, int player.size.x, int player.size.y, player.color)






let playerControl (player: player) =
    if Raylib.IsKeyDown(KeyboardKey.KEY_S) = true then 
        player.position.y <- player.position.y + 500f * Raylib.GetFrameTime()
    if Raylib.IsKeyDown(KeyboardKey.KEY_W) = true then 
        player.position.y <- player.position.y - 500f * Raylib.GetFrameTime()
    if Raylib.IsKeyDown(KeyboardKey.KEY_A) = true then 
        player.position.x <- player.position.x - 500f * Raylib.GetFrameTime()
    if Raylib.IsKeyDown(KeyboardKey.KEY_D) = true then 
        player.position.x <- player.position.x + 500f * Raylib.GetFrameTime()



let checkPlayerBorder(player: player) =
    if player.position.x <= float32 -7 then
        player.position.x <- float32 -7
    if player.position.x >= float32 1577 then
        player.position.x <- float32 1577
    if player.position.y <= float32 -7 then
        player.position.y <- float32 -7
    if player.position.y >= float32 868 then
        player.position.y <- float32 868


