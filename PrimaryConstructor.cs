/// <summary>
/// This class converts units of measurement.
/// </summary>
/// <param name="ratio"></param>
/// <remarks>
/// This class uses Primary Constructor Syntax to create a UnitConverter object.
/// </remarks>
public class UnitConverter(int ratio){
//     int ratio;

//     public UnitConverter(int unitRatio){
//         ratio = unitRatio;
//     }   

    public int Convert(int unit){
        return unit * ratio;
    }
}