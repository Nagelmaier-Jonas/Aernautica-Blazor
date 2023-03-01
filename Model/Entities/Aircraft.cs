namespace Model.Entities;

public class Aircraft{
    public int Structure{ get; set; }
    public int Speed{ get; set; }
    public int Throttle{ get; set; }
    public int MinSpeed{ get; set; }
    public int MaxSpeed{ get; set; }
    public int Maneuver{ get; set; }
    public int Handling{ get; set; }
    public int Altitude{ get; set; }
    public int MaxAltitude{ get; set; }
    public bool Spin{ get; set; }
    public ETeam Team{ get; set; }
    
    public EOrientation Orientation{ get; set; }
    public List<Weapon> Weapons{ get; set; } = new();
    
    public class AircraftBuilder{
        private int _structure;
        private int _speed;
        private int _throttle;
        private int _minSpeed;
        private int _maxSpeed;
        private int _maneuver;
        private int _handling;
        private int _altitude;
        private int _maxAltitude;
        private bool _spin;
        private ETeam _team;
        private EOrientation _orientation;
        private List<Weapon> _weapons = new();
        
        public AircraftBuilder WithStructure(int structure){
            _structure = structure;
            return this;
        }
        
        public int GetStructure() => _structure;
        
        public AircraftBuilder WithSpeed(int speed){
            _speed = speed;
            return this;
        }
        
        public int GetSpeed() => _speed;
        
        public AircraftBuilder WithThrottle(int throttle){
            _throttle = throttle;
            return this;
        }
        
        public int GetThrottle() => _throttle;
        
        public AircraftBuilder WithMinSpeed(int minSpeed){
            _minSpeed = minSpeed;
            return this;
        }
        
        public int GetMinSpeed() => _minSpeed;

        public AircraftBuilder WithMaxSpeed(int maxSpeed){
            _maxSpeed = maxSpeed;
            return this;
        }
        
        public int GetMaxSpeed() => _maxSpeed;
        
        public AircraftBuilder WithManeuver(int maneuver){
            _maneuver = maneuver;
            return this;
        }
        
        public int GetManeuver() => _maneuver;
        
        public AircraftBuilder WithHandling(int handling){
            _handling = handling;
            return this;
        }
        
        public int GetHandling() => _handling;
        
        public AircraftBuilder WithAltitude(int altitude){
            _altitude = altitude;
            return this;
        }
        
        public int GetAltitude() => _altitude;
        
        public AircraftBuilder WithMaxAltitude(int maxAltitude){
            _maxAltitude = maxAltitude;
            return this;
        }
        
        public int GetMaxAltitude() => _maxAltitude;
        
        public AircraftBuilder WithSpin(bool spin){
            _spin = spin;
            return this;
        }
        
        public bool GetSpin() => _spin;
        
        public AircraftBuilder WithTeam(ETeam team){
            _team = team;
            return this;
        }
        
        public ETeam GetTeam() => _team;
        
        public AircraftBuilder WithOrientation(EOrientation orientation){
            _orientation = orientation;
            return this;
        }
        
        public EOrientation GetOrientation() => _orientation;

        public AircraftBuilder WithWeapons(List<Weapon> weapons){
            _weapons = weapons;
            return this;
        }
        
        public AircraftBuilder WithWeapons(Weapon weapon){
            _weapons.Add(weapon);
            return this;
        }
        
        public List<Weapon> GetWeapons() => _weapons;

        public Aircraft Build(){
            return new Aircraft{
                Structure = _structure,
                Speed = _speed,
                Throttle = _throttle,
                MinSpeed = _minSpeed,
                MaxSpeed = _maxSpeed,
                Maneuver = _maneuver,
                Handling = _handling,
                Altitude = _altitude,
                MaxAltitude = _maxAltitude,
                Spin = _spin,
                Team = _team,
                Orientation = _orientation,
                Weapons = _weapons
            };
        }
    }
}