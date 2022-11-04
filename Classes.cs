// Here we addded the proper libraries for the classes to work

using Raylib_cs;
using System.Numerics;

public class fallingObject{
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }

    public void Move() {
        Vector2 NewPosition = this.Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
}}



public class ColoredObject: fallingObject {
    public Color Color { get; set; }

    public ColoredObject(Color color) {
        Color = color;
    }
}

public class Gems: ColoredObject {
    public int Size { get; set; }

    public Gems(Color color, int size): base(color) {
        Size = size;
    }

public class Rocks: ColoredObject {
    public int Size { get; set; }

    public Rocks(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }
}
    // set the shape to rectangle 
    
}


//     override public void Draw() {
//         Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
//     }
// }


public class Player{
    // creates a circle for the "player"
    int ScreenHeight = 480;
    int ScreenWidth = 800;
    int RectangleSize = 50;
    int MovementSpeed = 5;
    Rectangle PlayerRectangle;

    public Player(){
        PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
    }


    public void inputs(){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
            PlayerRectangle.x += MovementSpeed;
            }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
            PlayerRectangle.x -= MovementSpeed;
            }}

}
    
class Score{
    // set score attribute to 0 and use a constructor to do so
    int score = 0;
    
    public Score(){
    }

    // methods to add or subtract from score
    public void AddtoScore(int score){
        score +=1;
    }

    // it is a method that will subtract 1 from the score if that happens
    public void SubtractfromScore(int score){
    score += 1;
    }

    // get the score from the object and display it wit4h the raylib method
    public void displayScore(){
        Console.Write("Score:${score}");
    }
}