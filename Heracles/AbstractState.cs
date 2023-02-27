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
    /// State base class
    /// </summary>
    /// <remarks>Provides commonality for both automata and executable states in the machine</remarks>
    public abstract class AbstractState
    {
        public event System.EventHandler<StateMachineEventArgs>? EnteringState;
        public event System.EventHandler<StateMachineEventArgs>? ExitingState;
        public event System.EventHandler<StateMachineEventArgs>? ExecutingStateStarted;
        public event System.EventHandler<StateMachineEventArgs>? ExecutingStateFinished;

        public abstract void SetupState();

        public abstract void TearDownState();

        public abstract void ExecuteState();

        protected virtual void OnEnteringState(StateMachineEventArgs smea)
        {
            EnteringState?.Invoke(this, smea);
        }

        protected virtual void OnExecutingState(StateMachineEventArgs smea)
        {
            ExecutingStateStarted?.Invoke(this, smea);
        }

        protected virtual void OnExecutingStateFinished(StateMachineEventArgs smea)
        {
            ExecutingStateFinished?.Invoke(this, smea);
        }

        protected virtual void OnExitingState(StateMachineEventArgs smea)
        {
            ExitingState?.Invoke(this, smea);
        }
    }
}