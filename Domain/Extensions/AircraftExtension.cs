using Domain.Services;
using Model.Entities;
using Model.Playground;
using MudBlazor;

namespace Domain.Extensions;

public static class AircraftExtension{
    public static void ChangeAltitude(this Aircraft aircraft, int newAltitude, Map map){
        var currentField = map.GetFieldsWithAircraft().Find(field => field.Aircraft == aircraft);
        if (currentField == null) return;
        var newField = map.GameMap[currentField.X, currentField.Y, newAltitude];
        if (newField.Aircraft != null){
            Logger.GetInstance().Log(Severity.Error, "Field is not empty");
            return;
        }
        if (aircraft.Speed < newAltitude - currentField.Z){
            Logger.GetInstance().Log(Severity.Error, "Aircraft is too slow");
            return;
        }
        map.RemoveAircraftFromField(currentField);
        map.SetAircraftOnField(aircraft, newField);
        aircraft.Altitude = newAltitude;
        aircraft.Speed -= newAltitude - currentField.Z;
        Logger.GetInstance().Log(Severity.Success, "Altitude changed");
    }
    
    public static bool MoveAircraft(this Aircraft aircraft, Point point, Map map){
        var currentField = map.GetFieldsWithAircraft().Find(field => field.Aircraft == aircraft);
        if (currentField == null) return false;
        var newField = map.GameMap[point.X, point.Y, currentField.Z];
        if (newField.Aircraft != null){
            Logger.GetInstance().Log(Severity.Error, "Field is not empty");
            return false;
        }
        if (aircraft.Speed < point.Distance(currentField.X, currentField.Y)){
            Logger.GetInstance().Log(Severity.Error, "Aircraft is too slow");
            return false;
        }
        map.RemoveAircraftFromField(currentField);
        map.SetAircraftOnField(aircraft, newField);
        aircraft.Speed -= point.Distance(currentField.X, currentField.Y);
        Logger.GetInstance().Log(Severity.Success, "Aircraft moved");
        return true;
    }
    
    public static int Distance(this Point point, int x, int y){
        return (int) Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));
    }
    
    public static bool CanMoveAircraft(this Aircraft aircraft, Point point, Map map){
        var currentField = map.GetFieldsWithAircraft().Find(field => field.Aircraft == aircraft);
        if (currentField == null) return false;
        var newField = map.GameMap[point.X, point.Y, currentField.Z];
        if (newField.Aircraft != null) return false;
        return aircraft.Speed >= point.Distance(currentField.X, currentField.Y);
    }
    
}