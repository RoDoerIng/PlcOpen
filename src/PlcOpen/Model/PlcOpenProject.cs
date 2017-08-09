using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcOpen.Model
{
    class PlcOpenProject
    {
        
        private List<projectTypesDataType> dataTypes;

        public List<projectTypesDataType> DataTypes
        {
            get { return dataTypes; }
            set { dataTypes = value; }
        }

        private List<projectTypesPou> pous;

        public List<projectTypesPou> Pous
        {
            get { return pous; }
            set { pous = value; }
        }


    }
}
