using LAB2.Models;

namespace LAB2.Constructions
{
    class Construction
    {
        public Construction(float height, float width, int entrances,
            int humanCapacity, BuildMaterialType buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public Construction()
        {
            Height = 23;
            Width = 32;
            Entrances = 1;
            HumanCapacity = 1;
            BuildMaterial = BuildMaterialType.Wood;
        }
        public Construction(CreateConstuctionsDTO dto)
        {
            Height = dto.Height;
            Width = dto.Width;
            Entrances = dto.Entrances;
            HumanCapacity = dto.HumanCapacity;
            BuildMaterial = dto.BuildMaterial;
        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialType BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                // if (value == BuildMaterialType.Wood) // Assuming Unknown is an undefined value in your enumeration.
                // {
                //     throw new ArgumentNullException();
                // }
                _buildMaterial = value;
            }
        }
        private BuildMaterialType _buildMaterial { get; set; }

        public double GetSquareCost()
        {
            var x = 0.0;
            if (_buildMaterial == BuildMaterialType.Concrete)
            {
                x = 0.87;
            } 
            if (_buildMaterial == BuildMaterialType.Wood)
            {
                x = 0.8;
            } 
            if (_buildMaterial == BuildMaterialType.Brik)
            {
                x = 0.78;
            }

            return Width * Height * 0.9 * x;
        }
    }
}