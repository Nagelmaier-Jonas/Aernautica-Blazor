namespace Model.Entities;

public class Weapon{
    
    public string Name{ get; set; } = string.Empty;

    public List<EFireArc> FireArcs{ get; set; } = new();

    public Dictionary<EFirePower,int> FirePowers{ get; set; } = new ();

    public int Damage{ get; set; }
    
    public int Ammo{ get; set; }
    
    public class WeaponBuilder{
        
        private string _name = string.Empty;
        private List<EFireArc> _fireArcs = new();
        private Dictionary<EFirePower,int> _firePowers = new();
        private int _damage;
        private int _ammo;

        public WeaponBuilder WithName(string name){
            _name = name;
            return this;
        }

        public string GetName() => _name;
        
        public WeaponBuilder WithFireArcs(List<EFireArc> fireArcs){
           _fireArcs = fireArcs;
            return this;
        }

        public List<EFireArc> GetFireArcs() => _fireArcs;
        
        public WeaponBuilder WithFirePower(EFirePower firePower, int value){
            _firePowers[firePower] = value;
            return this;
        }
        
        public Dictionary<EFirePower,int> GetFirePowers() => _firePowers;
        
        public WeaponBuilder WithDamage(int damage){
            _damage = damage;
            return this;
        }
        
        public int GetDamage() => _damage;
        
        public WeaponBuilder WithAmmo(int ammo){
            _ammo = ammo;
            return this;
        }
        
        public WeaponBuilder WithUnlimitedAmmo(){
            _ammo = -1;
            return this;
        }
        
        public int GetAmmo() => _ammo;

        public Weapon Build(){
            var weapon = new Weapon();
            weapon.Name = _name;
            weapon.FireArcs = _fireArcs;
            weapon.FirePowers = _firePowers;
            weapon.Damage = _damage;
            weapon.Ammo = _ammo;
            return weapon;
        }
    }
}