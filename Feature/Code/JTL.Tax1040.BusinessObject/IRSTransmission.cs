//Vincent-10Jun2014- Added new Property for IRS Transmission

using System;
public class IRSTransmission
{



    public bool? IsFilingStateReturnElectronically { get; set; }
    public bool IsFilingFederalReturnElectronically { get; set; }



    public bool? HavePriorYearPIN { get; set; }
    public bool? HavePriorYearAGI { get; set; }
    public bool? HavePriorYearAGIAndPIN { get; set; }

    public DateTime? FilingDate { get; set; }

    public bool? HasReceivedIPINFromIRS { get; set; }
    public string PrimaryTaxPayerIPIN { get; set; }
    public string SpouseIPIN { get; set; }



    //Primary Tax Payer
    public string PrimaryPIN { get; set; }
    // public bool IsPrimaryPINSpecified { get; set; }

    public string PrimaryPriorYearPIN { get; set; }
    // public bool IsPrimaryPriorYearPINSpecified { get; set; }

    public double? PrimaryPriorYearAGI { get; set; }
    //    public bool IsPrimaryPriorYearAGISpecified { get; set; }

    public DateTime? PrimaryTaxPayerFilingDate { get; set; }

    public string PrimaryTaxpayerEFIN { get; set; }

    //Spouse
    public string SpousePIN { get; set; }
    //  public bool IsSpousePINSpecified { get; set; }

    public string SpousePriorYearPIN { get; set; }
    //  public bool IsSpousePriorYearPINspecified { get; set; }

    public double? SpousePriorYearAGI { get; set; }
    //public bool IsSpousePriorYearAGISpecified { get; set; }

    public string SpouseEFIN { get; set; }

    public DateTime? SpouseFilingDate { get; set; }

    public string DayTimePhone { get; set; }

    public byte[] Form8879 { get; set; }

    public string IPAddress { get; set; }

    public string TaxpayerEFINIssuedByIRS { get; set; }

    public string SpouseEFINIssuedByIRS { get; set; }

    //Vincent-10July2014 String Property to DateTime
    public DateTime? TaxpayerDateIssuedByIRS { get; set; }

    public DateTime? SpouseDateIssuedByIRS { get; set; }
}

