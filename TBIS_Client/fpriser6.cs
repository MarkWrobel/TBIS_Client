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
namespace FPriser6 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.realkreditnettet.dk/FPriser6")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6", IsNullable=false)]
    public partial class FPriser6 {
        
        private DOCINF dOCINFField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
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
        
        private Kodeliste5 meddelelsens_funktionField;
        
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
        public Kodeliste5 Meddelelsens_funktion {
            get {
                return this.meddelelsens_funktionField;
            }
            set {
                this.meddelelsens_funktionField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
    public enum Meddelelsens_navn {
        
        /// <remarks/>
        Z05,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
    public enum Meddelelsens_type {
        
        /// <remarks/>
        REQDOC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
    public partial class FOROMR {
        
        private Kodeliste12 forretningsomraadeField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
    public partial class GYLDAT {
        
        private string datoField;
        
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
    public partial class INSTIT {
        
        private GYLDAT gYLDATField;
        
        private FOROMR fOROMRField;
        
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
        public FOROMR FOROMR {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.realkreditnettet.dk/FPriser6")]
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
}