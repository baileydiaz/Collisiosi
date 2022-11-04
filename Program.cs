using Raylib_cs;
using System.Numerics;


    static class Program{
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var RectangleSize = 50;

            var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
            // var MovementSpeed = 4;


            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Ball");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                var player = new Player();
                player.inputs();

                Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

                // if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
                //     Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
                // }

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }