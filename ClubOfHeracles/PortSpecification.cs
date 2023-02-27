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

namespace ClubOfHeracles
{
    /// <summary>
    /// Open port details
    /// </summary>
    /// <remarks>Encapsulates the key data provided by nmap for a single open port</remarks>
    public class PortSpecification
    {
        public string Protocol { get; set; } = string.Empty;
        public string PortNumber { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string TTL { get; set; } = string.Empty;
        public string Service { get; set; } = string.Empty;
        public string IdMethod { get; set; } = string.Empty;
        public string Confidence { get; set; } = string.Empty;
    }
}