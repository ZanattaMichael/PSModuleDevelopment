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
        public string Message;

        /// <summary>
        /// Help Message to Prompt the user when entered !?
        /// </summary>
        public string HelpMessage;

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
            string Message, 
            List<string> ExpectedResult,
            string ActionIfTrue,
            string ProcessIfTrue
        ) {
            this.Name = Name;
            this.GroupName = GroupName;
            this.Message = Message;
            this.ExpectedResult = ExpectedResult;
            this.ActionIfTrue = ActionIfTrue;
            this.ProcessIfTrue = ProcessIfTrue;
        }

        //
        // Builder Methods
        //

        /// <summary>
        /// Add Default Values to the object.
        /// </summary>
        public void AddDefaultValue(string s) {
            this.DefaultValue = s;
        }
        /// <summary>
        /// Add help statement to the object
        /// </summary>
        public void AddHelp(string s) {
            this.HelpMessage = s;
        }

        //
        // Helper Method
        //

        public [Dictionary] ConvertToDictonaryObject() {

            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters.Add("GroupName", this.GroupName);
            parameters.Add("ChoiceMessage", this.Message);
            parameters.Add("ExpectedResult", this.ExpectedResult);
            parameters.Add("ActionIfTrue", this.ActionIfTrue);
            parameters.Add("ProcessIfTrue", this.ProcessIfTrue);
            if (this.HelpMessage) { parameters.Add("HelpMessage", this.HelpMessage)}
            

        }

    }

}