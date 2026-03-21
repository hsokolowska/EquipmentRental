namespace EquipmentRental.Models;

public class Camera : Equipment
{
    public int Megapixels { get; set; }
    public double Zoom { get; set; }
    
    public Camera(string name, int megapixels, double zoom) : base(name)
    {
        Megapixels = megapixels;
        Zoom = zoom;
    }
}