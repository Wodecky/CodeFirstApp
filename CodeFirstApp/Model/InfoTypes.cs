using System.ComponentModel;

namespace CodeFirstApp.Model
{
    public enum InfoTypes : ushort
    {
        [Description("Osobiste")]
        PersonalInfo,
        [Description("Rodzinne")]
        FamilyInfo,
        [Description("Firmowe")]
        CompanyInfo
    }
}