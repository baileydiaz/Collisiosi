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
            // var Objects = new List<fallingObjects>();
            var Random = new Random();
            var Score = new Score();
            var PlayerRectangle = new Rectangle(ScreenWidth / 2, ScreenHeight - 30 , 20, 20);
            var MovementSpeed = 4;
            Player player = new Player(MovementSpeed, PlayerRectangle);
            RandomObject Grandparent = new RandomObject();
            int CurrentScore = Score.score;
            int i = 0;

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                i += 1;

                Vector2 RandPosition = Grandparent.GenerateRandomPosition();
                int Case = Grandparent.GenerateRandomCase();

                int thing = i % 10;
                if (thing == 0){
                Grandparent.GenerateRandomObject(RandPosition, Case);
                }

                player.input();
                player.drawplayer();


                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                

                // Draw all of the objects in their current location
                
                Grandparent.DrawObjects(Grandparent.Objects, CurrentScore);

                // foreach (var obj in Objects) {
                //     if (obj.position.RandomX > 801){
                //     }
                foreach (var obj in Grandparent.Objects.ToList()){
                    if (obj is Rock){
                        var therock = (Rock)obj;
                        var Squarerectangle = new Rectangle (therock.Position.x, therock.Position.y, therock.Size, therock.Size);
                        if (Raylib.CheckCollisionRecs(PlayerRectangle, Squarerectangle)){
                            Score.AddtoScore();
                        }
                    }
                }
                foreach (var obj in Grandparent.Objects) {
                    obj.Move();
                }

                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();
        }
    }
}