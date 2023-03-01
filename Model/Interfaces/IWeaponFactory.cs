using Model.Entities;

namespace Model.Interfaces;

public interface IWeaponFactory{
    public Weapon CreateQuadBigShootas();
    
    public Weapon CreateTurretBigShootas();
    
    public Weapon CreateTailGun();
    
    public Weapon CreatePortTurret();
    
    public Weapon CreateStarboardTurret();
    
    public Weapon CreateGrotBomms();
    
    public Weapon CreateLascannon();
    
    public Weapon CreateDorsalTurret();
    
    public Weapon CreateRearTurret();
    
    public Weapon CreateBombBay();
    
    public Weapon CreateTwinMultiLaser();
    
    public Weapon CreateQuadAutocannon();
    
    public Weapon CreateTwinLascannon();
}