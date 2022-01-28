namespace Fortuna.Generator
{
	internal abstract class GeneratorBase
	{
		internal abstract void GenerateBytes(byte[] data);

		internal abstract void Reseed(byte[] seed);
	}
}