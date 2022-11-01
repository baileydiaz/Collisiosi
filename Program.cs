using Raylib_cs;
using System.Numerics;

if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
    PlayerRectangle.x += MovementSpeed;
    }

if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
    PlayerRectangle.x -= MovementSpeed;
    }

if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
    PlayerRectangle.y -= MovementSpeed;
    }

if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
    PlayerRectangle.y += MovementSpeed;
    }