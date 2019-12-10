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
    public class ChoiceInterpolation
    {

        /// <summary>
        /// Name of the choice (auto-assigned or specified)
        /// </summary>
        public string Name;

        /// <summary>
        /// Name of the GroupName
        /// </summary>
        public string GroupName;

        /// <summary>
        /// Message to Prompt the user
        /// </summary>
        public string ChoiceMessage;

        /// <summary>
        /// Expected Result
        /// </summary>
        List<string> ExpectedResult = new List<string>();

        /// <summary>
        /// Default Value
        /// </summary>
        public string DefaultValue;

        /// <summary>
        /// Value inputted to be true
        /// </summary>
        public string ActionIfTrue;

        /// <summary>
        /// Value inputted to be true
        /// </summary>
        public string ProcessIfTrue;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChoiceInterpolation() {
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChoiceInterpolation(
            string Name, 
            string GroupName, 
            string ChoiceMessage, 
            List<string> ExpectedResult,
            string ActionIfTrue,
            string ProcessIfTrue
        ) {
            this.Name = Name;
            this.GroupName = GroupName;
            this.ChoiceMessage = ChoiceMessage;
            this.ExpectedResult = ExpectedResult;
            this.ActionIfTrue = ActionIfTrue;
            this.ProcessIfTrue = ProcessIfTrue;
        }


    }

}