using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace PSModuleDevelopment.Template
{
    /// <summary>
    /// A script used to calculate content to be inserted
    /// </summary>
    [Serializable]
    public class FileInterpolation
    {

        /// <summary>
        /// FileName of the Interpolation
        /// </summary>
        public string Name;

        /// <summary>
        /// Full File Path of the Interpolation
        /// </summary>
        public string FilePath;

        /// <summary>
        /// Default Constructor
        /// </summary>

        public FileInterpolation(){

        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>

        public FileInterpolation(string Name, string FilePath){
            this.Name = Name;
            this.FilePath = FilePath;
        }        

    }

}