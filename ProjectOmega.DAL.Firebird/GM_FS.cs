//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOmega.DAL.Firebird
{
    using System;
    using System.Collections.Generic;
    
    public partial class GM_FS
    {
        public int ID { get; set; }
        public int MAGNUM { get; set; }
        public string TYP_DOK_MAGAZYNOWEGO { get; set; }
        public string KOD { get; set; }
        public System.DateTime DATA_WYSTAWIENIA { get; set; }
        public short ROK { get; set; }
        public short MIESIAC { get; set; }
        public int NR { get; set; }
        public string NUMER { get; set; }
        public short BLOKADA { get; set; }
        public short FISKALNY { get; set; }
        public short SPOSOB_LICZENIA { get; set; }
        public Nullable<int> RODZAJ_CENY { get; set; }
        public Nullable<int> RODZAJ_RABATU { get; set; }
        public Nullable<int> ID_TABELI_KURSOWEJ { get; set; }
        public int ID_WALUTY { get; set; }
        public Nullable<decimal> KURS { get; set; }
        public Nullable<System.DateTime> DATA_PLATNOSCI { get; set; }
        public Nullable<System.DateTime> DATA_SPRZEDAZY { get; set; }
        public string NUMER_TABELI_KURSOWEJ { get; set; }
        public string NAZWA_DOKUMENTU { get; set; }
        public Nullable<int> ID_PLATNIKA { get; set; }
        public Nullable<int> ID_ODBIORCY { get; set; }
        public string NAZWA_SKROCONA_PLATNIKA { get; set; }
        public string NAZWA_PELNA_PLATNIKA { get; set; }
        public string NIP_PLATNIKA { get; set; }
        public string KOD_KRESKOWY_PLATNIKA { get; set; }
        public string ULICA_PLATNIKA { get; set; }
        public string NRDOMU_PLATNIKA { get; set; }
        public string NRLOKALU_PLATNIKA { get; set; }
        public string MIEJSCOWOSC_PLATNIKA { get; set; }
        public string KOD_PLATNIKA { get; set; }
        public string PANSTWO_PLATNIKA { get; set; }
        public string NAZWA_SKROCONA_ODBIORCY { get; set; }
        public string NAZWA_PELNA_ODBIORCY { get; set; }
        public string NIP_ODBIORCY { get; set; }
        public string KOD_KRESKOWY_ODBIORCY { get; set; }
        public string ULICA_ODBIORCY { get; set; }
        public string NRDOMU_ODBIORCY { get; set; }
        public string NRLOKALU_ODBIORCY { get; set; }
        public string MIEJSCOWOSC_ODBIORCY { get; set; }
        public string KOD_ODBIORCY { get; set; }
        public string PANSTWO_ODBIORCY { get; set; }
        public Nullable<int> ID_AKWIZYTORA { get; set; }
        public Nullable<decimal> PROWIZJA_AKWIZYTORA { get; set; }
        public string NAZWISKO_PRZEDSTAWICIELA { get; set; }
        public decimal WAL_WARTOSC_NETTO { get; set; }
        public decimal WAL_KWOTA_VAT { get; set; }
        public decimal WAL_WARTOSC_BRUTTO { get; set; }
        public decimal PLN_WARTOSC_NETTO { get; set; }
        public decimal WARTOSC_ZAKUPU { get; set; }
        public decimal WARTOSC_ZAKUPU_KAUCJ { get; set; }
        public decimal WAL_WARTOSC_KAUCJ { get; set; }
        public decimal PLN_WARTOSC_KAUCJ { get; set; }
        public string OPERATOR { get; set; }
        public System.DateTime DATAREJESTRACJI { get; set; }
        public string ZMIENIL { get; set; }
        public System.DateTime DATAZMIANY { get; set; }
        public Nullable<System.DateTime> DATA_FS_DO_PA { get; set; }
        public short ROK_FS_DO_PA { get; set; }
        public short MIESIAC_FS_DO_PA { get; set; }
        public Nullable<int> NR_FS_DO_PA { get; set; }
        public string NUMER_FS_DO_PA { get; set; }
        public string NAZWA_FS_DO_PA { get; set; }
        public decimal WARTOSC_ROZRACHUNKU { get; set; }
        public string SYGNATURA { get; set; }
        public string ZNACZNIKI { get; set; }
        public string GRUPOWANIE { get; set; }
        public decimal PLN_KWOTA_VAT { get; set; }
        public decimal PLN_WARTOSC_BRUTTO { get; set; }
        public short MAGAZYNOWY { get; set; }
        public byte[] UWAGI { get; set; }
        public short TRANSAKCJA_TROJSTRONNA { get; set; }
        public Nullable<int> KOD_KRAJU_PRZEZNACZENIA { get; set; }
        public Nullable<int> KOD_WARUNKOW_DOSTAWY { get; set; }
        public Nullable<int> KOD_RODZAJU_TRANSPORTU { get; set; }
        public Nullable<int> KOD_RODZAJU_TRANSAKCJI { get; set; }
        public Nullable<int> ID_WNTT { get; set; }
        public string GUID { get; set; }
        public string DF_NAME { get; set; }
        public Nullable<int> ID_RDS { get; set; }
        public Nullable<int> ID_SPOSOBU_PLATNOSCI { get; set; }
        public string NAZWA_SPOSOBU_PLATNOSCI { get; set; }
        public Nullable<int> DOSTAWA_ID_ADRESU { get; set; }
        public string DOSTAWA_ULICA { get; set; }
        public string DOSTAWA_NR_DOMU { get; set; }
        public string DOSTAWA_NR_LOKALU { get; set; }
        public string DOSTAWA_KOD_POCZTOWY { get; set; }
        public string DOSTAWA_MIEJSCOWOSC { get; set; }
        public string DOSTAWA_PANSTWO { get; set; }
        public Nullable<int> ID_SP_DOSTAWY { get; set; }
        public Nullable<System.DateTime> TERMIN_DOSTAWY { get; set; }
        public string DOSTAWA_INCOTERMS_SKROT { get; set; }
        public string DOSTAWA_INCOTERMS_CEL { get; set; }
        public Nullable<short> DD_NUMERU { get; set; }
        public string GLN_PLATNIKA { get; set; }
        public string GLN_ODBIORCY { get; set; }
        public string DOSTAWA_GLN { get; set; }
        public short CZY_METODA_KASOWA { get; set; }
        public Nullable<int> ID_PODSTAWY_ZWOL_VAT { get; set; }
    
        public virtual R3_CONTACTS R3_CONTACTS { get; set; }
        public virtual R3_CONTACTS R3_CONTACTS1 { get; set; }
        public virtual R3_CONTACTS R3_CONTACTS2 { get; set; }
    }
}
