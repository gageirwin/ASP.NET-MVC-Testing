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

        private string pRICEField;

        private ushort yEARField;

        private string sPECIALField;

        private CATALOGCDTHING[] oPTIONSField;

        private string nEWNEWField;

        private byte[] nEWField;

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
        public string PRICE
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
        [System.Xml.Serialization.XmlArrayItemAttribute("THING", IsNullable = false)]
        public CATALOGCDTHING[] OPTIONS
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

        /// <remarks/>
        public string NEWNEW
        {
            get
            {
                return this.nEWNEWField;
            }
            set
            {
                this.nEWNEWField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("ITEM", IsNullable = false)]
        public byte[] NEW
        {
            get
            {
                return this.nEWField;
            }
            set
            {
                this.nEWField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CATALOGCDTHING
    {

        private uint indexField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
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
