/* 
   Copyright (C) codepoet
   
   This is free software; you can redistribute it and/or
   modify it under the terms of the GNU Library General Public
   License as published by the Free Software Foundation; either
   version 2 of the License, or (at your option) any later version.
   
   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Library General Public License for more details.
   
   You should have received a copy of the GNU Library General Public
   License along with this software; if not, write to the Free
   Software Foundation, Inc., 59 Temple Place - Suite 330, Boston,
   MA 02111-1307, USA

  Don't use it to find and eat babies ... unless you're really REALLY hungry ;-)

*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Heracles
{
    /// <summary>
    /// The starting state for the automaton
    /// </summary>
    public class InitialState : AbstractState
    {
        public override void ExecuteState()
        {
            base.OnExecutingState(new StateMachineEventArgs());
            int responseCode = -1;
            string responseString = string.Empty;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please select from the following menu:");
                Console.WriteLine("======================================");
                Console.WriteLine("[0] File ingestion");
                Console.WriteLine("[1] Reconnaissance");
                Console.WriteLine("[2] Resource development");
                Console.WriteLine("[3] Initial access");
                Console.WriteLine("[4] Execution");
                Console.WriteLine("[5] Persistence");
                Console.WriteLine("[6] Privilege escalation");
                Console.WriteLine("[7] Defense evasion");
                Console.WriteLine("[8] Credential access");
                Console.WriteLine("[9] Discovery");
                Console.WriteLine("[10] Lateral movement");
                Console.WriteLine("[11] Collection");
                Console.WriteLine("[12] Command and collection");
                Console.WriteLine("[13] Exfiltration");
                Console.WriteLine("[14] Impact");
                Console.WriteLine(". . .");
                Console.WriteLine("[99] Exit");
                Console.Write("Enter choice: ");
                responseString = Console.ReadLine()!;
                if (!int.TryParse(responseString, out responseCode))
                {
                    Debug.WriteLine($"Request for global function: {responseString}");
                    continue;
                }

            }
            while (responseCode != 99);
        }

        public override void SetupState()
        {
            base.OnEnteringState(new StateMachineEventArgs());
        }

        public override void TearDownState()
        {
            base.OnExitingState(new StateMachineEventArgs());
        }
    }
}