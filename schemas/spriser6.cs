﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace SPriser6 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.realkreditnettet.dk/SPriser6")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6", IsNullable=false)]
    public partial class SPriser6 {
        
        private DOCINF dOCINFField;
        
        private FJLTXT[] fJLTXTField;
        
        private INSTIT[] iNSTITField;
        
        /// <remarks/>
        public DOCINF DOCINF {
            get {
                return this.dOCINFField;
            }
            set {
                this.dOCINFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FJLTXT")]
        public FJLTXT[] FJLTXT {
            get {
                return this.fJLTXTField;
            }
            set {
                this.fJLTXTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INSTIT")]
        public INSTIT[] INSTIT {
            get {
                return this.iNSTITField;
            }
            set {
                this.iNSTITField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class DOCINF {
        
        private Meddelelsens_navn meddelelsens_navnField;
        
        private bool meddelelsens_navnFieldSpecified;
        
        private Meddelelsens_type meddelelsens_typeField;
        
        private bool meddelelsens_typeFieldSpecified;
        
        private string sender_versionField;
        
        private string modtager_versionField;
        
        private string onsket_versionField;
        
        private string informationsstromsnavnField;
        
        private string meddelelsens_nummerField;
        
        private string meddelelsesnr_for_foresporgselenField;
        
        private Kodeliste5 meddelelsens_funktionField;
        
        private Kodeliste26 meddelelsensstatusField;
        
        private bool meddelelsensstatusFieldSpecified;
        
        private string niveaudelingField;
        
        private string datoField;
        
        private string afsender_partidField;
        
        private string iDkodeField;
        
        private string virksomhedsIDField;
        
        private string afdelingsidField;
        
        private string personidField;
        
        private string modtager_partidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Meddelelsens_navn Meddelelsens_navn {
            get {
                return this.meddelelsens_navnField;
            }
            set {
                this.meddelelsens_navnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Meddelelsens_navnSpecified {
            get {
                return this.meddelelsens_navnFieldSpecified;
            }
            set {
                this.meddelelsens_navnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Meddelelsens_type Meddelelsens_type {
            get {
                return this.meddelelsens_typeField;
            }
            set {
                this.meddelelsens_typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Meddelelsens_typeSpecified {
            get {
                return this.meddelelsens_typeFieldSpecified;
            }
            set {
                this.meddelelsens_typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sender_version {
            get {
                return this.sender_versionField;
            }
            set {
                this.sender_versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Modtager_version {
            get {
                return this.modtager_versionField;
            }
            set {
                this.modtager_versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Onsket_version {
            get {
                return this.onsket_versionField;
            }
            set {
                this.onsket_versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Informationsstromsnavn {
            get {
                return this.informationsstromsnavnField;
            }
            set {
                this.informationsstromsnavnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meddelelsens_nummer {
            get {
                return this.meddelelsens_nummerField;
            }
            set {
                this.meddelelsens_nummerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meddelelsesnr_for_foresporgselen {
            get {
                return this.meddelelsesnr_for_foresporgselenField;
            }
            set {
                this.meddelelsesnr_for_foresporgselenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste5 Meddelelsens_funktion {
            get {
                return this.meddelelsens_funktionField;
            }
            set {
                this.meddelelsens_funktionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("Meddelelsens-status")]
        public Kodeliste26 Meddelelsensstatus {
            get {
                return this.meddelelsensstatusField;
            }
            set {
                this.meddelelsensstatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeddelelsensstatusSpecified {
            get {
                return this.meddelelsensstatusFieldSpecified;
            }
            set {
                this.meddelelsensstatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Niveaudeling {
            get {
                return this.niveaudelingField;
            }
            set {
                this.niveaudelingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Dato {
            get {
                return this.datoField;
            }
            set {
                this.datoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Afsender_partid {
            get {
                return this.afsender_partidField;
            }
            set {
                this.afsender_partidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ID-kode")]
        public string IDkode {
            get {
                return this.iDkodeField;
            }
            set {
                this.iDkodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VirksomhedsID {
            get {
                return this.virksomhedsIDField;
            }
            set {
                this.virksomhedsIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Afdelingsid {
            get {
                return this.afdelingsidField;
            }
            set {
                this.afdelingsidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Personid {
            get {
                return this.personidField;
            }
            set {
                this.personidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Modtager_partid {
            get {
                return this.modtager_partidField;
            }
            set {
                this.modtager_partidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Meddelelsens_navn {
        
        /// <remarks/>
        Z05,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Meddelelsens_type {
        
        /// <remarks/>
        MORDOC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste5 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste26 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        Z01,
        
        /// <remarks/>
        Z02,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class PRIS {
        
        private Kodeliste22 gebyr_prField;
        
        private decimal beloebField;
        
        private string valutakodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste22 Gebyr_pr {
            get {
                return this.gebyr_prField;
            }
            set {
                this.gebyr_prField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Beloeb {
            get {
                return this.beloebField;
            }
            set {
                this.beloebField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Valutakode {
            get {
                return this.valutakodeField;
            }
            set {
                this.valutakodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste22 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class GEBTYP {
        
        private PRIS[] pRISField;
        
        private Kodeliste21 gebyrtypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRIS")]
        public PRIS[] PRIS {
            get {
                return this.pRISField;
            }
            set {
                this.pRISField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste21 Gebyrtype {
            get {
                return this.gebyrtypeField;
            }
            set {
                this.gebyrtypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste21 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("45")]
        Item45,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("46")]
        Item46,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("47")]
        Item47,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48")]
        Item48,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        Item57,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68")]
        Item68,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("69")]
        Item69,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class KUNTYP {
        
        private GEBTYP[] gEBTYPField;
        
        private Kodeliste47 kundetypeField;
        
        private bool kundetypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GEBTYP")]
        public GEBTYP[] GEBTYP {
            get {
                return this.gEBTYPField;
            }
            set {
                this.gEBTYPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste47 Kundetype {
            get {
                return this.kundetypeField;
            }
            set {
                this.kundetypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KundetypeSpecified {
            get {
                return this.kundetypeFieldSpecified;
            }
            set {
                this.kundetypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste47 {
        
        /// <remarks/>
        Z01,
        
        /// <remarks/>
        Z02,
        
        /// <remarks/>
        Z03,
        
        /// <remarks/>
        Z04,
        
        /// <remarks/>
        Z05,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class FOROMR {
        
        private KUNTYP[] kUNTYPField;
        
        private Kodeliste12 forretningsomraadeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KUNTYP")]
        public KUNTYP[] KUNTYP {
            get {
                return this.kUNTYPField;
            }
            set {
                this.kUNTYPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste12 Forretningsomraade {
            get {
                return this.forretningsomraadeField;
            }
            set {
                this.forretningsomraadeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste12 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("76")]
        Item76,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("84")]
        Item84,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("85")]
        Item85,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("86")]
        Item86,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("87")]
        Item87,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("88")]
        Item88,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("89")]
        Item89,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("91")]
        Item91,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("92")]
        Item92,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("93")]
        Item93,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("94")]
        Item94,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("95")]
        Item95,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("96")]
        Item96,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("97")]
        Item97,
        
        /// <remarks/>
        AA,
        
        /// <remarks/>
        AB,
        
        /// <remarks/>
        AC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class GYLDAT {
        
        private string priser_gaelder_fraField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Priser_gaelder_fra {
            get {
                return this.priser_gaelder_fraField;
            }
            set {
                this.priser_gaelder_fraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class INSTIT {
        
        private GYLDAT gYLDATField;
        
        private FOROMR[] fOROMRField;
        
        private Kodeliste4 institutField;
        
        /// <remarks/>
        public GYLDAT GYLDAT {
            get {
                return this.gYLDATField;
            }
            set {
                this.gYLDATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FOROMR")]
        public FOROMR[] FOROMR {
            get {
                return this.fOROMRField;
            }
            set {
                this.fOROMRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste4 Institut {
            get {
                return this.institutField;
            }
            set {
                this.institutField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public enum Kodeliste4 {
        
        /// <remarks/>
        PRI,
        
        /// <remarks/>
        EJP,
        
        /// <remarks/>
        SKA,
        
        /// <remarks/>
        SPK,
        
        /// <remarks/>
        STA,
        
        /// <remarks/>
        STK,
        
        /// <remarks/>
        BRF,
        
        /// <remarks/>
        DLR,
        
        /// <remarks/>
        DK,
        
        /// <remarks/>
        HKK,
        
        /// <remarks/>
        LRF,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        RD,
        
        /// <remarks/>
        TOT,
        
        /// <remarks/>
        UNI,
        
        /// <remarks/>
        FK,
        
        /// <remarks/>
        GI,
        
        /// <remarks/>
        IHF,
        
        /// <remarks/>
        IRF,
        
        /// <remarks/>
        JK,
        
        /// <remarks/>
        KI,
        
        /// <remarks/>
        PRF,
        
        /// <remarks/>
        ALL,
        
        /// <remarks/>
        BGK,
        
        /// <remarks/>
        NOR,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/SPriser6")]
    public partial class FJLTXT {
        
        private string fejlkodeField;
        
        private string fejltekstField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fejlkode {
            get {
                return this.fejlkodeField;
            }
            set {
                this.fejlkodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fejltekst {
            get {
                return this.fejltekstField;
            }
            set {
                this.fejltekstField = value;
            }
        }
    }
}