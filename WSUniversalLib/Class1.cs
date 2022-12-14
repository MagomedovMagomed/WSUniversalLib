using WSUniversalLib;

namespace WSUniversalLib
{
    public static class Class1
    {
        public static double Test(double productType, double materialType, double count, double width, double length)
        {
           double a, Type, Material;
            switch (productType)
            {
                case 1:
                    Type = 1.1;
                    break;
                case 2:
                    Type = 2.5;
                    break;
                case 3:
                    Type = 8.43;
                    break;
                default:
                    Type = 0;
                    break;
            }
            switch (materialType)
            {
                case 1:
                    Material = 0.003009;
                    break;
                case 2:
                    Material = 0.0012014;
                    break;
                default:
                    Material = 0;
                    break;
            }
            if (Material == 0 || Type == 0)
            {
                a = -1;
            }
            else
            {
                a = Type * count * width * length * (1 + Material);
            }
            return Math.Ceiling(a);
        }
    }
}