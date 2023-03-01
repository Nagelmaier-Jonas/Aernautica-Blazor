using Model.Entities;
using Model.Interfaces;

namespace Model.Factories;

public class WeaponFactory : IWeaponFactory{
    
    private static WeaponFactory Instance{ get; } = new();
    private WeaponFactory(){
        
    }
    
    public static WeaponFactory GetInstance(){
        return Instance;
    }

    public Weapon CreateQuadBigShootas(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Quad Big Shootas")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Front })
            .WithFirePower(EFirePower.Short, 8)
            .WithFirePower(EFirePower.Medium, 4)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateTurretBigShootas(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Turret Big Shootas")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Rear, EFireArc.Right, EFireArc.Left, EFireArc.Up })
            .WithFirePower(EFirePower.Short, 3)
            .WithFirePower(EFirePower.Medium, 1)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateTailGun(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Tail Gun")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Rear })
            .WithFirePower(EFirePower.Short, 1)
            .WithFirePower(EFirePower.Medium, 0)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(6)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreatePortTurret(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Port Turret")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Left, EFireArc.Up })
            .WithFirePower(EFirePower.Short, 2)
            .WithFirePower(EFirePower.Medium, 1)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateStarboardTurret(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Starboard Turret")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Right, EFireArc.Up })
            .WithFirePower(EFirePower.Short, 2)
            .WithFirePower(EFirePower.Medium, 1)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateGrotBomms(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Grot Bomms")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Left, EFireArc.Front, EFireArc.Right })
            .WithFirePower(EFirePower.Short, 1)
            .WithFirePower(EFirePower.Medium, 1)
            .WithFirePower(EFirePower.Long, 1)
            .WithDamage(2)
            .WithAmmo(2);
        return builder.Build();
    }

    public Weapon CreateLascannon(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Lascannon")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Front })
            .WithFirePower(EFirePower.Short, 0)
            .WithFirePower(EFirePower.Medium, 2)
            .WithFirePower(EFirePower.Long, 1)
            .WithDamage(2)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateDorsalTurret(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Dorsal Turret")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Rear, EFireArc.Right, EFireArc.Left, EFireArc.Up, EFireArc.Front })
            .WithFirePower(EFirePower.Short, 3)
            .WithFirePower(EFirePower.Medium, 2)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateRearTurret(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Rear Turret")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Rear })
            .WithFirePower(EFirePower.Short, 3)
            .WithFirePower(EFirePower.Medium, 2)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateBombBay(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Bomb Bay")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Rear })
            .WithFirePower(EFirePower.Short, 8)
            .WithFirePower(EFirePower.Medium, 0)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateTwinMultiLaser(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Twin Multi Laser")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Front })
            .WithFirePower(EFirePower.Short, 4)
            .WithFirePower(EFirePower.Medium, 6)
            .WithFirePower(EFirePower.Long, 2)
            .WithDamage(5)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateQuadAutocannon(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Quad Autocannon")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Front })
            .WithFirePower(EFirePower.Short, 2)
            .WithFirePower(EFirePower.Medium, 6)
            .WithFirePower(EFirePower.Long, 0)
            .WithDamage(4)
            .WithUnlimitedAmmo();
        return builder.Build();
    }

    public Weapon CreateTwinLascannon(){
        var builder = new Weapon.WeaponBuilder();
        builder.WithName("Twin Lascannon")
            .WithFireArcs(new List<EFireArc>(){ EFireArc.Front })
            .WithFirePower(EFirePower.Short, 0)
            .WithFirePower(EFirePower.Medium, 2)
            .WithFirePower(EFirePower.Long, 1)
            .WithDamage(2)
            .WithUnlimitedAmmo();
        return builder.Build();
    }
}