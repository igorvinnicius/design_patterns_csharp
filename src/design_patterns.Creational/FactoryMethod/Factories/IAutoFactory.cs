using design_patterns.Creational.FactoryMethod.Autos;

namespace design_patterns.Creational.FactoryMethod.Factories
{
    public interface IAutoFactory
    {
		 IAuto CreateAutoMobile();
    }
}
