module target


open types
open Raylib_cs

let targetSetup (target: target) =
    target.color <- Color.GREEN
    target.position.x <- float32((Raylib.GetScreenWidth()) / 2 + 100)
    target.position.y <- float32((Raylib.GetScreenHeight()) / 2 + 100)
    target.size.x <- 30f
    target.size.y <- 30f



// x = -7, 1577
// y = -7, 868

    



    
let drawTarget (target: target) =
    Raylib.DrawRectangle(int target.position.x,int target.position.y, int target.size.x, int target.size.y, target.color)