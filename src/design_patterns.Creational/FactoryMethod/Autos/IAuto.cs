
namespace design_patterns.Creational.FactoryMethod.Autos
{
    public interface IAuto
    {
		string Name { get; }

		bool SwitchedOn { get; }

		void SetName(string name);

		void TurnOn();

		void TurnOff();
	}
}
