using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcOpen.Model
{
    class PlcOpenProject
    {
        private project projectField;


        public List<projectTypesDataType> DataTypes
        {
            get { return this.projectField.types.dataTypes.ToList(); }
        }


        public List<projectTypesPou> Pous
        {
            get { return this.projectField.types.pous.ToList(); }
        }

        public PlcOpenProject(project plcOpenProject)
        {
            this.projectField = plcOpenProject;
        }


    }
}
