namespace MyLibrary
{
	public class FiggleWriter
	{
		public void Write(string message)
		{
			//Uso de Figgle
			Console.WriteLine(Figgle.FiggleFonts.Standard.Render(message));
		}

	}
}
