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
using System.Threading.Tasks;

namespace ClubOfHeracles
{
	/// <summary>
	/// Common types
	/// </summary>
	/// <remarks>Provides enums for common types such as supported input file types</remarks>
	public static class Constants
	{
		public enum SupportedInputTypes
		{
			NONE,
			NMAP,
			NETDISCOVER,
			MASSCAN,
			NESSUS,
			NESSUS_HSH,
			OPENVAS_XML,
			OPENVAS_ANONYMOUS_XML,
			BURP_PROJECT,
			BURP_ISSUES,
			BURP_ITEMS,
			OWASPZAP,
			AXFR_DIG,
			AXFR_NS_WIN,
			AXFR_NS_LIN,
			SSLSCAN,
			METASPLOIT,
			HASHES_PWDUMP,
			NUM_SUPPORTED_TYPES
		};
		public enum NmapNodeRoles
		{
			NONE,
			ROOT,
			SUBNET,
			ACLASS,
			BCLASS,
			CCLASS,
			LEAF,
			NUM_ROLES
		}
		public enum ProcessorStates
		{
			NONE,
			START_STATE_CREATED
		}
		public enum NessusIssueSeverity
		{
			UNKNOWN,
			INFO,
			LOW,
			MEDUIM,
			HIGH,
			CRITICAL,
			NUM_SEVERITIES
		}
		public enum NessusPluginCategory
		{
			UNKNOWN,
			WINDOWS,
			LINUX,
			NETWORK_DEVICES,
			POLICY,
			DATABASE,
			WEB,
			SERVICES,
			MOBILE,
			P2P,
			SCADA,
			DOS,
			REMOTE_CONTROL,
			MISCELLANEOUS,
			NUM_CATEGORIES
		}
	}
}
