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
using System.Linq;
using System.Text;

namespace Heracles
{
    /// <summary>
    /// The main automaton in the CLI
    /// </summary>
    public class StateMachineMain : AbstractState
    {
        List<AbstractState> _executableStates = new List<AbstractState>();
        List<AbstractState> _globalStates = new List<AbstractState>();

        public override void ExecuteState()
        {
            base.OnExecutingState(new StateMachineEventArgs());
            InitialState initialState = new InitialState();
            initialState.ExecuteState();
        }

        public override void SetupState()
        {
            base.OnEnteringState(new StateMachineEventArgs());
            CreateStates();

        }

        public override void TearDownState()
        {
            base.OnExitingState(new StateMachineEventArgs());
        }

        void CreateStates()
        {
            _executableStates.Add(new InitialState());
            _executableStates.Add(new FinalState());

            _globalStates.Add(new ConfigState());
        }
    }
}
