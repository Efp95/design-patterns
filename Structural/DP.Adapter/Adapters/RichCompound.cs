using DP.Adapter.Adaptees;
using DP.Adapter.Targets;
using System;

namespace DP.Adapter.Adapters
{
    public class RichCompound : Compound
    {
        public ChemicalDatabank Bank { get; }

        public RichCompound(Chemical chemical)
        {
            Chemical = chemical;

            Bank = new ChemicalDatabank();
        }

        public override void Display()
        {
            BoilingPoint = Bank.GetCriticalPoint(Chemical, State.Boiling);
            MeltingPoint = Bank.GetCriticalPoint(Chemical, State.Melting);
            MolecularWeight = Bank.GetMolecularWeight(Chemical);
            MolecularFormula = Bank.GetMolecularStructure(Chemical);
            
            Console.WriteLine($"\nCompound: {Chemical} ------ ");
            Console.WriteLine($" Formula: {MolecularFormula}");
            Console.WriteLine($" Weight : {MolecularWeight}");
            Console.WriteLine($" Melting Pt: {MeltingPoint}");
            Console.WriteLine($" Boiling Pt: {BoilingPoint}");
        }
    }
}
