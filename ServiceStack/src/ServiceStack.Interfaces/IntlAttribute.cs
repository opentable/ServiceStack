using System;

namespace ServiceStack;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class FormatAttribute : AttributeBase
{
    public string Method { get; set; }
    public string Options { get; set; }
    public string Locale { get; set; }
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class IntlAttribute : AttributeBase
{
    public Intl Type { get; set; }

    public IntlAttribute() {}
    public IntlAttribute(Intl type) => Type = type;

    public string Locale { get; set; }
    public string Options { get; set; }
    
    public DateStyle Date { get; set; }
    public TimeStyle Time { get; set; }
    public NumberStyle Number { get; set; }
    public RelativeTimeStyle RelativeTime { get; set; }
    /// <summary>
    /// Use <see cref="NumberCurrency"/> for typed values
    /// </summary>
    public string Currency { get; set; }
    /// <summary>
    /// Use <see cref="NumberUnit"/> for typed values
    /// </summary>
    public string Unit { get; set; }
    public int MinimumIntegerDigits { get; set; } = int.MinValue;
    public int MinimumFractionDigits { get; set; } = int.MinValue;
    public int MaximumFractionDigits { get; set; } = int.MinValue;
    public int MinimumSignificantDigits { get; set; } = int.MinValue;
    public int MaximumSignificantDigits { get; set; } = int.MinValue;
    public int FractionalSecondDigits { get; set; } = int.MinValue;
    
    public PartStyle Weekday { get; set; }
    public PartStyle Era { get; set; }
    public PartStyle Year { get; set; }
    public PartStyle Month { get; set; }
    public PartStyle Day { get; set; }
    public PartStyle Hour { get; set; }
    public PartStyle Minute { get; set; }
    public PartStyle Second { get; set; }
    public PartStyle TimeZoneName { get; set; }
    public string TimeZone { get; set; }
    public bool Hour12 { get; set; }
}

public enum Intl
{
    //Intl.NumberFormat
    Number,
    //Intl.DateTimeFormat
    DateTime,
    //Intl.RelativeTimeFormat
    RelativeTime,
}

public enum DateStyle { None=0, Full, Long, Medium, Short, }
public enum TimeStyle { None=0, Full, Long, Medium, Short, }
public enum NumberStyle { None=0, Decimal, Currency, Percent, Unit, }
public enum RelativeTimeStyle { None=0, Long, Short, Narrow, }

public enum PartStyle { None=0, Narrow, Short, Long, Digits2, }


public static class NumberCurrency
{
    public const string USD = nameof(USD);
    public const string EUR = nameof(EUR);
    public const string JPY = nameof(JPY);
    public const string GBP = nameof(GBP);
    public const string CHF = nameof(CHF);
    public const string CAD = nameof(CAD);
    public const string AUD = nameof(AUD);
    public const string ZAR = nameof(ZAR);
    public const string CNY = nameof(CNY);
    public const string HKD = nameof(HKD);
    public const string NZD = nameof(NZD);
    public const string SEK = nameof(SEK);
    public const string KRW = nameof(KRW);
    public const string SGD = nameof(SGD);
    public const string NOK = nameof(NOK);
    public const string MXN = nameof(MXN);
    public const string INR = nameof(INR);
    public const string RUB = nameof(RUB);
    public const string TRY = nameof(TRY);
    public const string BRL = nameof(BRL);
    public const string TWD = nameof(TWD);
    public const string DKK = nameof(DKK);
    public const string PLN = nameof(PLN);
    public const string THB = nameof(THB);
    public const string IDR = nameof(IDR);
    public const string HUF = nameof(HUF);
    public const string CZK = nameof(CZK);
    public const string ILS = nameof(ILS);
    public const string CLP = nameof(CLP);
    public const string PHP = nameof(PHP);
    public const string AED = nameof(AED);
    public const string COP = nameof(COP);
    public const string SAR = nameof(SAR);
    public const string MYR = nameof(MYR);
    public const string RON = nameof(RON);
}

public static class NumberUnit
{
    public const string Acre  = "acre";
    public const string Bit  = "bit";
    public const string Byte  = "byte";
    public const string Celsius  = "celsius";
    public const string Centimeter  = "centimeter";
    public const string Day  = "day";
    public const string Degree  = "degree";
    public const string Fahrenheit  = "fahrenheit";
    public const string Foot  = "foot";
    public const string Gallon  = "gallon";
    public const string Gigabit  = "gigabit";
    public const string Gigabyte  = "gigabyte";
    public const string Gram  = "gram";
    public const string Hectare  = "hectare";
    public const string Hour  = "hour";
    public const string Inch  = "inch";
    public const string Kilobit  = "kilobit";
    public const string Kilobyte  = "kilobyte";
    public const string Kilogram  = "kilogram";
    public const string Kilometer  = "kilometer";
    public const string Liter  = "liter";
    public const string Megabit  = "megabit";
    public const string Megabyte  = "megabyte";
    public const string Meter  = "meter";
    public const string Mile  = "mile";
    public const string Milliliter  = "milliliter";
    public const string Millimeter  = "millimeter";
    public const string Millisecond  = "millisecond";
    public const string Minute  = "minute";
    public const string Month  = "month";
    public const string Ounce  = "ounce";
    public const string Percent  = "percent";
    public const string Petabyte  = "petabyte";
    public const string Pound  = "pound";
    public const string Second  = "second";
    public const string Stone  = "stone";
    public const string Terabit  = "terabit";
    public const string Terabyte  = "terabyte";
    public const string Week  = "week";
    public const string Yard  = "yard";
    public const string Year  = "year";
}
