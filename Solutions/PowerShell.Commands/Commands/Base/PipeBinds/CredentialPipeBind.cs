﻿using OfficeDevPnP.PowerShell.Commands.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.PowerShell.Commands.Base.PipeBinds
{
    public sealed class CredentialPipeBind
    {
        private PSCredential _pscredential;
        public string _storedcredential;

        public CredentialPipeBind(PSCredential pscredential)
        {
            this._pscredential = pscredential;
        }

        public CredentialPipeBind(string id)
        {
            this._storedcredential = id;
        }

        public PSCredential Credential
        {
            get
            {
                if (_pscredential != null)
                {
                    return _pscredential;
                }
                else if (_storedcredential != null)
                {
                    return CredentialManager.GetCredential(_storedcredential);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
