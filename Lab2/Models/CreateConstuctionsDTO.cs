namespace LAB2.Models
{
    public class CreateConstuctionsDTO
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialType BuildMaterial { get; set; }
    }
}