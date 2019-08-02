using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Parsing_C_Sharp_LINQ
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class root
    {

        private rootElement[] elementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("element")]
        public rootElement[] element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class rootElement
    {

        private rootElementElement[] wEEKField;

        private string wHOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
        public rootElementElement[] WEEK
        {
            get
            {
                return this.wEEKField;
            }
            set
            {
                this.wEEKField = value;
            }
        }

        /// <remarks/>
        public string WHO
        {
            get
            {
                return this.wHOField;
            }
            set
            {
                this.wHOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class rootElementElement
    {

        private rootElementElementElement[] eXPENSEField;

        private byte nUMBERField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
        public rootElementElementElement[] EXPENSE
        {
            get
            {
                return this.eXPENSEField;
            }
            set
            {
                this.eXPENSEField = value;
            }
        }

        /// <remarks/>
        public byte NUMBER
        {
            get
            {
                return this.nUMBERField;
            }
            set
            {
                this.nUMBERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class rootElementElementElement
    {

        private decimal aMOUNTField;

        private string wHATField;

        /// <remarks/>
        public decimal AMOUNT
        {
            get
            {
                return this.aMOUNTField;
            }
            set
            {
                this.aMOUNTField = value;
            }
        }

        /// <remarks/>
        public string WHAT
        {
            get
            {
                return this.wHATField;
            }
            set
            {
                this.wHATField = value;
            }
        }
    }


}
