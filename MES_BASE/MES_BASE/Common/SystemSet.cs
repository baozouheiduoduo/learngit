using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MES_BASE.Common
{
    [XmlRoot("SystemSet")]
    public class SystemSet
    {

        private string sqlName;
        private string bigX;
        private string bigY;
        private string qualityX;
        private string qualityY;
        /// <summary>
        /// 端口名称
        /// </summary>
        [XmlElement("SQLName")]
        public string SQLName
        {
            get { return sqlName; }
            set { sqlName = value; }
        }

        [XmlElement("BigX")]
        public string BigX
        {
            get { return bigX; }
            set { bigX = value; }
        }

        [XmlElement("BigY")]
        public string BigY
        {
            get { return bigY; }
            set { bigY = value; }
        }

        [XmlElement("QualityX")]
        public string QualityX
        {
            get { return qualityX; }
            set { qualityX = value; }
        }

        [XmlElement("QualityY")]
        public string QualityY
        {
            get { return qualityY; }
            set { qualityY = value; }
        }
    }
}
