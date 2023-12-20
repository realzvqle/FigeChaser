module types


open Raylib_cs



type transform = {
    mutable x: float32
    mutable y: float32
}

type window = {
    size: transform
    mutable name: string
}

type player = {
    size: transform
    position: transform
    mutable color: Color
}

type enemy = {
    size: transform
    position: transform
    mutable color: Color
    mutable speed: float32
}

type target = {
    size: transform
    position: transform
    mutable color: Color
}

type gameState = {
    player: player
    window: window
    enemy: enemy
    target: target
    mutable sceneManager: int
    mutable counter: int
}