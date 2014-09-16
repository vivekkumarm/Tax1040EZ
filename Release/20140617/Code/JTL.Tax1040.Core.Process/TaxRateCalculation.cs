//*10/3/14 Vincent Changed the path as "TaxCalculationXml.TaxRateSlabs.xml" */
//12/3/14 Vincent added the TaxRateSlabs.xml path in the connection string */
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using System.Configuration;

namespace JTL.Tax1040.Core.Process
{
    public class TaxRateCalculation
    {
       
        public static double TaxCalculation(FilingStatus filingStatus, double taxableIncome)
        {
                    
            //Loading Xml file to Xdocument 
            var xdoc =
                XDocument.Load(
                    Assembly.GetExecutingAssembly()
                            .GetManifestResourceStream(ConfigurationManager.AppSettings["TaxSlabRate"]));

            //Identifying the Slabs based on the Filing Status
            var slabs =
                xdoc.Descendants("FilingStatus")
                    .Single(a => a.Attribute("Type").Value == filingStatus.ToString())
                    .Elements();

            //Loading all the slabs range values to a List
            var allSlabs = slabs.Select(s => new TaxRateSlabRange()
                {
                    StartRange = s.Attribute("StartRange").Value.ConvertToDouble(),
                    EndRange = s.Attribute("EndRange").Value.ConvertToDouble(),
                    TaxRate = s.Attribute("TaxRate").Value.ConvertToDouble()
                }).ToList();

            //Endrange Values for Slabs with 0 will be set to Maximum value of double
            allSlabs.Single(asl => asl.EndRange == 0.0).EndRange = double.MaxValue;

            //Identifying the Slab in which the Taxable amount falls
            var matchingSlab = allSlabs.Single(sla => sla.StartRange <= taxableIncome && sla.EndRange >= taxableIncome);
            
            //Calculating Tax amount
            var calculatedTax =
                (allSlabs.Where(sla => sla.EndRange < taxableIncome)
                         .Sum(su =>((su.EndRange - ((su.StartRange > 0) ? (su.StartRange - 1) : su.StartRange))*su.TaxRate))) +
                (matchingSlab.TaxRate*(taxableIncome -((matchingSlab.StartRange > 0) ? (matchingSlab.StartRange - 1) : matchingSlab.StartRange)));

            return calculatedTax.RoundDouble();
        }
    }
    
}

