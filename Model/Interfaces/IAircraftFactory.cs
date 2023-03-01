using Model.Entities;

namespace Model.Interfaces;

public interface IAircraftFactory{
    
    public Aircraft CreateBigBurna();
    
    public Aircraft CreateVulture();
    
    public Aircraft CreateGrotBommer();

    public Aircraft CreateBlueDevil();
    
    public Aircraft CreateHellion();
    
    public Aircraft CreateExecutioner();
}