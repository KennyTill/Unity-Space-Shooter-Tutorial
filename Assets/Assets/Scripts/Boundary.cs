
/*Pulling this class out of the player class. Single class per file is better convention*/
[System.Serializable]
public class Boundary {

	//One line for each declaration. It makes it more readable!
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;
}