using Raylib_cs;
using System.Numerics;

class fallingObjects {
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

class ColoredObject: fallingObjects {
    public Color Color { get; set; }

    public ColoredObject(Color color) {
        Color = color;
    }
}


class Rock: ColoredObject {
    public int Size { get; set; }

    public Rock(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }
}

class Gem: ColoredObject {

    public int Radius { get; set; }

    public Gem(Color color, int radius): base(color) {
        Radius = radius;}

    override public void Draw(){
        Raylib.DrawCircle((int)Position.X, (int)Position.Y, Radius, Color);
    }
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

    public int ReturnScore(){
        return score;
    }
}
class Player{

}
class Visuals{
    
}

    // get the score from the object and display it wit4h the raylib method
    // public void displayScore(){
    //     override public void Draw(){
    //     ;
//     }
// }