using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCmdArgs
{
    public class CmdArgsOptionPage : DialogPage
    {
        private bool _useMonospaceFont = false;
        //private string _uniqueArgsFilename = "";

        [Category( "General" )]
        [DisplayName( "Use Monospace Font" )]
        [Description( "If enabled the fontfamily is changed to 'Consolas'." )]
        [DefaultValue( false )]
        public bool UseMonospaceFont
        {
            get => _useMonospaceFont;
            set
            {
                if (_useMonospaceFont != value)
                {
                    _useMonospaceFont = value;
                    UseMonospaceFontChanged?.Invoke(this, value);
                }
            }
        }

        //[Category( "General" )]
        //[DisplayName( "Unique arguments file" )]
        //[Description( "All solution arguments are saved in one file." )]
        //[DefaultValue( "" )]
        //public string UniqueArgsFilename
        //{
        //    get => _uniqueArgsFilename;
        //    set
        //    {
        //        if ( _uniqueArgsFilename != value )
        //        {
        //            _uniqueArgsFilename = value;
        //            UniqueArgsFilenameChanged?.Invoke( this, value );
        //        }
        //    }
        //}

        public override void ResetSettings()
        {
            base.ResetSettings();
            
            UseMonospaceFont = false;
            //UniqueArgsFilename = "";
        }
        
        public event EventHandler<bool> UseMonospaceFontChanged;
        //public event EventHandler<string> UniqueArgsFilenameChanged;
    }
}
