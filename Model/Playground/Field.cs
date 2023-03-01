using Model.Entities;

namespace Model.Playground;

public class Field : Point{

    public Field(int x, int y, int z, Aircraft? aircraft = null) : base(x, y, z){
        Aircraft = aircraft;
    }
    public Aircraft? Aircraft{ get; set; }
}