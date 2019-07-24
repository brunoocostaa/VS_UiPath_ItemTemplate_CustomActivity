using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;

namespace $rootnamespace$
{
    /// <summary>
    /// This custom activity does something.
    /// </summary>
    public sealed class $safeitemname$  : CodeActivity
    {
        #region .    Activity Name    .
        //Use this section to define how the activity name will be displayed
        public $safeitemname$()
        {
             this.DisplayName = "$safeitemname$";
        }
	    #endregion
        
        #region .    UiPath Properties    .
        
        [RequiredArgument, Category("Input"), Description("{Your description}")]
        public InArgument<string> Input
        {
            get;
            set;
        }

        [Category("Output"), Description("{Your description}")]
        public OutArgument<string> Output
        {
            get;
            set;
        }

        #endregion           

        #region .    Methods    .

        protected override void Execute(CodeActivityContext context)
        {
            try
            {                
                string input = this.Input.Get(context);

                // Your code goes here. ** Do not include many logic here. Use external standard classes instead. **                                

                this.Output.Set(context, string.Empty);
            }
            catch (Exception e)
            {
                // Your custom message and exception handling goes here.
                throw e;
            }
        }

        #endregion
    }

}
