using Domain.Extensions;
using Model.Entities;
using Model.Playground;

namespace View.Game;

public class GameEngine{

    private static GameEngine Instance{ get; } = new();

    private GameEngine(){
    }
    
    public static GameEngine GetInstance() => Instance;
    
    public Map Map { get; set; } = new();
    
    public void ChangeAltitude(Aircraft aircraft, int altitude){
        aircraft.ChangeAltitude(altitude, Map);
    }
    
    public bool MoveAircraft(Aircraft aircraft, Point point){
        return aircraft.MoveAircraft(point, Map);
    }
    
    public bool CanMoveAircraft(Aircraft aircraft, Point point){
        return aircraft.CanMoveAircraft(point, Map);
    }
}