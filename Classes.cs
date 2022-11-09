using Raylib_cs;
using System.Numerics;

public class RandomObject{
    public List<fallingObjects> Objects {get; set;} = new List<fallingObjects>();
    public RandomObject(){

    }

    public Vector2 GenerateRandomPosition(){
        var Random = new Random();
        var RandomX = Random.Next(1, 800);
        var position = new Vector2(RandomX, 0);
        return position;
    }

    public int GenerateRandomCase(){
        var Random = new Random();
        int whichType = Random.Next(2);
        return whichType;
    }

    public void GenerateRandomObject(Vector2 position, int whichType){
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
    }


    public void DrawObjects(List<fallingObjects> Objects, int Score){
        foreach (var obj in Objects) {
                Raylib.DrawText($"Score: {Score}", 12, 12, 20, Color.GREEN);
                obj.Draw();
                }
    }



}

public class fallingObjects {
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
    public int score = 0;
    
    public Score(){
    }

    // methods to add or subtract from score
    public void AddtoScore(int score){
        score +=1;
    }

    // it is a method that will subtract 1 from the score if that happens
    public void SubtractfromScore(int score){
    score += 1;
    }}

public class Player{
    public Player(int MovementSpeed, Rectangle PlayerRectangle){
        Playerrec = PlayerRectangle;
        Speed = MovementSpeed;
    }
    Rectangle Playerrec;
    int Speed;
    public void input(){
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                if (Playerrec.x < 780)
                Playerrec.x += Speed;
                }
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                if (Playerrec.x > 0)
                Playerrec.x -= Speed;
                }
    }

    public void drawplayer(){
        Raylib.DrawRectangleRec(Playerrec, Color.WHITE);
    }
}

class Visuals{
    
}

    // get the score from the object and display it wit4h the raylib method
    // public void displayScore(){
    //     override public void Draw(){
    //     ;
//     }
// }