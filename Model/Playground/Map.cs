using Model.Entities;

namespace Model.Playground;

public class Map{
    public Field[,,] GameMap{ get; set; } = new Field[10, 10, 10];

    public Map(){
        InitializeMap();
    }
    private void InitializeMap(){
        for (var x = 0; x < GameMap.GetLength(0); x++){
            for (var y = 0; y < GameMap.GetLength(1); y++){
                for (var z = 0; z < GameMap.GetLength(2); z++){
                    GameMap[x, y, z] = new Field(x, y, z);
                }
            }
        }
    }
    public void SetAircraftOnField(Aircraft aircraft, Point point){
        GameMap[point.X, point.Y, point.Z].Aircraft = aircraft;
    }

    public void RemoveAircraftFromField(Point point){
        GameMap[point.X, point.Y, point.Z].Aircraft = null;
    }
    
    public Aircraft? GetAircraftFromField(Point point){
        return GameMap[point.X, point.Y, point.Z].Aircraft;
    }
    
    public bool IsFieldEmpty(Point point){
        return GameMap[point.X, point.Y, point.Z].Aircraft == null;
    }
    public List<Field> GetFieldsWithAircraft(){
        var fieldsWithAircraft = new List<Field>();
        for (var x = 0; x < GameMap.GetLength(0); x++){
            for (var y = 0; y < GameMap.GetLength(1); y++){
                for (var z = 0; z < GameMap.GetLength(2); z++){
                    if (GameMap[x, y, z].Aircraft != null){
                        fieldsWithAircraft.Add(GameMap[x, y, z]);
                    }
                }
            }
        }
        return fieldsWithAircraft;
    }
}