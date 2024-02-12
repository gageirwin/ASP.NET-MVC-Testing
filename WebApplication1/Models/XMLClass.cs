// Copy xml -> Edit -> Paste Scpecial -> Paste XML as Classes

namespace WebApplication1.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CATALOG
    {

        private CATALOGCD[] cdField;

        private CATALOGScript scriptField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CD")]
        public CATALOGCD[] CD
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }

        /// <remarks/>
        public CATALOGScript script
        {
            get
            {
                return this.scriptField;
            }
            set
            {
                this.scriptField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CATALOGCD
    {

        private string tITLEField;

        private string aRTISTField;

        private string cOUNTRYField;

        private string cOMPANYField;

        private decimal pRICEField;

        private ushort yEARField;

        private string sPECIALField;

        private CATALOGCDOPTIONS oPTIONSField = new CATALOGCDOPTIONS();

        /// <remarks/>
        public string TITLE
        {
            get
            {
                return this.tITLEField;
            }
            set
            {
                this.tITLEField = value;
            }
        }

        /// <remarks/>
        public string ARTIST
        {
            get
            {
                return this.aRTISTField;
            }
            set
            {
                this.aRTISTField = value;
            }
        }

        /// <remarks/>
        public string COUNTRY
        {
            get
            {
                return this.cOUNTRYField;
            }
            set
            {
                this.cOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string COMPANY
        {
            get
            {
                return this.cOMPANYField;
            }
            set
            {
                this.cOMPANYField = value;
            }
        }

        /// <remarks/>
        public decimal PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }

        /// <remarks/>
        public ushort YEAR
        {
            get
            {
                return this.yEARField;
            }
            set
            {
                this.yEARField = value;
            }
        }

        /// <remarks/>
        public string SPECIAL
        {
            get
            {
                return this.sPECIALField;
            }
            set
            {
                this.sPECIALField = value;
            }
        }

        /// <remarks/>
        public CATALOGCDOPTIONS OPTIONS
        {
            get
            {
                return this.oPTIONSField;
            }
            set
            {
                this.oPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CATALOGCDOPTIONS
    {

        private string tHING1Field;

        private string tHING2Field;

        /// <remarks/>
        public string THING1
        {
            get
            {
                return this.tHING1Field;
            }
            set
            {
                this.tHING1Field = value;
            }
        }

        /// <remarks/>
        public string THING2
        {
            get
            {
                return this.tHING2Field;
            }
            set
            {
                this.tHING2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CATALOGScript
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }


}
