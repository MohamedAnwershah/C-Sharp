UnitConverter feetToInches = new UnitConverter(12);
UnitConverter kmToFeet = new UnitConverter(3280);

Console.WriteLine(feetToInches.Convert(6)); //Feets to inches

Console.WriteLine(kmToFeet.Convert(2)); //Kilo Meters to feets

Console.WriteLine(feetToInches.Convert(kmToFeet.Convert(2))); //Kilo meters to feets and then Feets to Inches

//Custom Type
public class UnitConverter
{	
	int ratio;
	public UnitConverter (int unitRatio){
		ratio = unitRatio;
	}
	public int Convert (int unit){
		return ratio * unit;
	}
}


