using Model.Entities;
using Model.Interfaces;

namespace Model.Factories;

public class AircraftFactory : IAircraftFactory{

    private static AircraftFactory Instance{ get; } = new();
    
    private readonly WeaponFactory _weaponFactory = WeaponFactory.GetInstance();
    private AircraftFactory(){
    }
    
    public static AircraftFactory GetInstance(){
        return Instance;
    }

    public Aircraft CreateBigBurna(){
        var builder = new Aircraft.AircraftBuilder();
        builder.WithStructure(3)
            .WithThrottle(2)
            .WithMinSpeed(3)
            .WithMaxSpeed(7)
            .WithHandling(4)
            .WithMaxAltitude(4)
            .WithSpeed(3)
            .WithManeuver(4)
            .WithAltitude(1)
            .WithSpin(false)
            .WithTeam(ETeam.Orks)
            .WithOrientation(EOrientation.North)
            .WithWeapons(_weaponFactory.CreateQuadBigShootas())
            .WithWeapons(_weaponFactory.CreateTurretBigShootas())
            .WithWeapons(_weaponFactory.CreateTailGun());
            
        return builder.Build();
    }

    public Aircraft CreateVulture(){
        var builder = new Aircraft.AircraftBuilder();
        builder.WithStructure(2)
            .WithThrottle(2)
            .WithMinSpeed(3)
            .WithMaxSpeed(8)
            .WithHandling(3)
            .WithMaxAltitude(4)
            .WithSpeed(3)
            .WithManeuver(5)
            .WithAltitude(1)
            .WithSpin(false)
            .WithTeam(ETeam.Orks)
            .WithOrientation(EOrientation.North)
            .WithWeapons(_weaponFactory.CreateQuadBigShootas());
            
        return builder.Build();
    }

    public Aircraft CreateGrotBommer(){
        var builder = new Aircraft.AircraftBuilder();
        builder.WithStructure(6)
            .WithThrottle(1)
            .WithMinSpeed(2)
            .WithMaxSpeed(4)
            .WithHandling(5)
            .WithMaxAltitude(4)
            .WithSpeed(2)
            .WithManeuver(3)
            .WithAltitude(1)
            .WithSpin(false)
            .WithTeam(ETeam.Orks)
            .WithOrientation(EOrientation.North)
            .WithWeapons(_weaponFactory.CreateQuadBigShootas())
            .WithWeapons(_weaponFactory.CreatePortTurret())
            .WithWeapons(_weaponFactory.CreateStarboardTurret())
            .WithWeapons(_weaponFactory.CreateGrotBomms());
            
        return builder.Build();
    }

    public Aircraft CreateBlueDevil(){
        var builder = new Aircraft.AircraftBuilder();
        builder.WithStructure(5)
            .WithThrottle(1)
            .WithMinSpeed(2)
            .WithMaxSpeed(5)
            .WithHandling(3)
            .WithMaxAltitude(5)
            .WithSpeed(2)
            .WithManeuver(3)
            .WithAltitude(1)
            .WithSpin(false)
            .WithTeam(ETeam.Imperium)
            .WithOrientation(EOrientation.South)
            .WithWeapons(_weaponFactory.CreateLascannon())
            .WithWeapons(_weaponFactory.CreateDorsalTurret())
            .WithWeapons(_weaponFactory.CreateRearTurret())
            .WithWeapons(_weaponFactory.CreateBombBay());
            
        return builder.Build();
    }

    public Aircraft CreateHellion(){
        var builder = new Aircraft.AircraftBuilder();
        builder.WithStructure(2)
            .WithThrottle(3)
            .WithMinSpeed(2)
            .WithMaxSpeed(8)
            .WithHandling(2)
            .WithMaxAltitude(5)
            .WithSpeed(2)
            .WithManeuver(7)
            .WithAltitude(1)
            .WithSpin(false)
            .WithTeam(ETeam.Imperium)
            .WithOrientation(EOrientation.South)
            .WithWeapons(_weaponFactory.CreateTwinMultiLaser());
            
        return builder.Build();
    }

    public Aircraft CreateExecutioner(){
        var builder = new Aircraft.AircraftBuilder();
        builder.WithStructure(3)
            .WithThrottle(2)
            .WithMinSpeed(2)
            .WithMaxSpeed(7)
            .WithHandling(3)
            .WithMaxAltitude(5)
            .WithSpeed(2)
            .WithManeuver(6)
            .WithAltitude(1)
            .WithSpin(false)
            .WithTeam(ETeam.Imperium)
            .WithOrientation(EOrientation.South)
            .WithWeapons(_weaponFactory.CreateQuadAutocannon())
            .WithWeapons(_weaponFactory.CreateTwinLascannon());
            
        return builder.Build();
    }
}