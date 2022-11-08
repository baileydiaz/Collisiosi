using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Objects = new List<fallingObjects>();
            var Random = new Random();
            var Score = new Score();
            var PlayerRectangle = new Rectangle(ScreenWidth / 2, ScreenHeight - 30 , 20, 20);
            var MovementSpeed = 4;
            int ReturnScore = Score.ReturnScore();

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                var whichType = Random.Next(2);

                // Generate a random x for this object
                var RandomX = Random.Next(1, 800);

                // Each object will start about the center of the screen
                var position = new Vector2(RandomX, 0);

                
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                if (PlayerRectangle.x < 780)
                PlayerRectangle.x += MovementSpeed;
                }
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                if (PlayerRectangle.x > 0)
                PlayerRectangle.x -= MovementSpeed;
                }


                switch (whichType) {
                    case 0:
                        Console.WriteLine("Creating a square");
                        var square = new Rock(Color.YELLOW, 20);
                        square.Position = position;
                        square.Velocity = new Vector2(0, 1);
                        Objects.Add(square);
                        break;
                    case 1:
                        Console.WriteLine("Creating a circle");
                         var circle = new Gem(Color.RED, 20);
                        circle.Position = position;
                        circle.Velocity = new Vector2(0, 1);
                        Objects.Add(circle);
                        break;
                    default:
                        break;
                }

                

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                

                // Draw all of the objects in their current location
                foreach (var obj in Objects) {
                    obj.Draw();
                    Raylib.DrawText($"Score: {ReturnScore}", 12, 12, 20, Color.GREEN);
                }

                // foreach (var obj in Objects) {
                //     if (obj.position.RandomX > 801){
                //     }

                Raylib.DrawRectangleRec(PlayerRectangle, Color.WHITE);

                Raylib.EndDrawing();

                // Move all of the objects to their next location
                foreach (var obj in Objects) {
                    obj.Move();
                }
                
            }

            Raylib.CloseWindow();
        }
    }
}

