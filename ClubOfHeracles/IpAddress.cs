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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClubOfHeracles
{
	public class IpAddress
	{
		public IpAddress(string ipAddress, string dnsName = "")
		{
			IPAddress = ipAddress;
			DNSName = dnsName;
			HasIpForwarding = false;
			HasGeoLocation = false;
			ParseAddress();
			ComputeDotEntry();
		}
		public IpAddress() { }
		#region Public methods
		public string ComputeDotEntry()
		{
			string s = RootToAClassDotEntry() + AClassToBClassDotEntry() + BClassToCClassDotEntry() + CClassToLeafDotEntry();
			DotEntry = s;
			return (DotEntry);
		}
		public void ParseAddress()
		{
			int[] oa = new int[4];
            StaticNetworkFunctions.ParseIpAddress(IPAddress, ref oa);
			aClass = oa[0];
			bClass = oa[1];
			cClass = oa[2];
			Node = oa[3];
		}
		public string ParentSubnet()
		{
			string ret = "";
			ret = aClass.ToString() + "." + bClass.ToString() + "." + cClass.ToString() + ".*";
			return (ret);
		}
		public string ParentSubnetClean()
		{
			string ret = "";
			ret = aClass.ToString() + "." + bClass.ToString() + "." + cClass.ToString() + ".";
			return (ret);
		}
		#endregion Public methods
		#region Operator overloads
		public static bool operator ==(IpAddress lh, IpAddress rh) { return (lh.IPAddress).Equals(rh.IPAddress); }
		public static bool operator !=(IpAddress lh, IpAddress rh) { return (lh.IPAddress.Equals(rh.IPAddress) ? true : false); }

		public override bool Equals(object? o)
		{
			IpAddress? ia = o as IpAddress;
			return (this == ia!);
		}

		public override int GetHashCode()
		{
			return (System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this));
		}

		#endregion
		#region Properties
		public bool HasIpForwarding { get; set; } = false;
		public bool HasGeoLocation { get; set; } = false;
		public string Longitude { get; set; } = string.Empty;
		public string Latitude { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public string TimeZone { get; set; } = string.Empty;
		public string MacAddress { get; set; } = string.Empty;
		public string IPAddress { get; set; } = string.Empty;
		public string DNSName { get; set; } = string.Empty;
		public string DotEntry { get; set; } = string.Empty;
		public int aClass { get; private set; } = -1;
		public int bClass { get; private set; } = -1;
		public int cClass { get; private set; } = -1;
		public int Node { get; private set; } = -1;

		bool _fromNmap = false;
		public bool FromNmap
		{
			get
			{
				return (_fromNmap);
			}
			set
			{
				_fromNmap = value;
			}
		}
		bool _fromAxfr = false;
		public bool FromAXFR
		{
			get
			{
				return (_fromAxfr);
			}
			set
			{
				_fromAxfr = value;
			}
		}
		string _osGuess = "";
		public string OSGuess
		{
			get
			{
				return (_osGuess);
			}
			set
			{
				_osGuess = value;
			}
		}
		bool _isNs = false;
		public bool IsNameServer
		{
			get
			{
				return (_isNs);
			}
			set
			{
				_isNs = value;
			}
		}
		//public Constants.NessusIssueSeverity HighestSeverity { get; set; }
		#endregion
		#region Public Dot entry methods
		public string RootToAClassDotEntry()
		{
			/*
			attack_machine [shape=box,fontcolor="Black",color="Black",fontname="Verdana",fontsize="10",label="Attack Machine"];
			59 [shape=box,fontcolor="Black",color="Black",fontname="Verdana",fontsize="10",label="59.*.*.*"];
			attack_machine->59 [color="Black"];
			*/
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("attack_machine [shape=box,fontcolor=\"Black\",color=\"Black\",fontname=\"%FONT%\",fontsize=\"10\",label=\"Analyst\nMachine\"];");
			sb.AppendFormat("{0} [shape=box,fontcolor=\"Black\",color=\"Black\",fontname=\"%FONT%\",fontsize=\"10\",label=\"{0}.*.*.*\"];\r\n", aClass.ToString());
			sb.AppendFormat("attack_machine->{0} [color=\"Black\"];\r\n", aClass.ToString());
			return (sb.ToString());
		}
		public string AClassToBClassDotEntry()
		{
			/*
			61100 [shape=box,fontcolor="Black",color="Black",fontname="Verdana",fontsize="10",label="61.100.*.*"];
			61->61100 [color="Black"];
			*/
			StringBuilder sb = new StringBuilder();
			string a2b = aClass.ToString() + bClass.ToString();
			string adotb = aClass.ToString() + "." + bClass.ToString();
			sb.AppendFormat("{0} [shape=box,fontcolor=\"Black\",color=\"Black\",fontname=\"%FONT%\",fontsize=\"10\",label=\"{1}.*.*\"];\r\n", a2b, adotb);
			sb.AppendFormat("{0}->{1} [color=\"Black\"];\r\n", aClass.ToString(), a2b);
			return (sb.ToString());
		}
		public string BClassToCClassDotEntry()
		{
			/*
			59100100 [shape=box,fontcolor="Black",color="Black",fontname="Verdana",fontsize="10",label="59.100.100.*"];
			59100->59100100 [color="Black"];
			*/
			StringBuilder sb = new StringBuilder();
			string a2b = aClass.ToString() + bClass.ToString();
			string a2c = aClass.ToString() + bClass.ToString() + cClass.ToString();
			string adotc = aClass.ToString() + "." + bClass.ToString() + "." + cClass.ToString();
			sb.AppendFormat("{0} [shape=box,fontcolor=\"Black\",color=\"Black\",fontname=\"%FONT%\",fontsize=\"10\",label=\"{1}.*\"];\r\n", a2c, adotc);
			sb.AppendFormat("{0}->{1} [color=\"Black\"];\r\n", a2b, a2c);
			return (sb.ToString());
		}
		public string CClassToLeafDotEntry()
		{
			StringBuilder sb = new StringBuilder();
			//string os = this.
			string a2c = aClass.ToString() + bClass.ToString() + cClass.ToString();
			string a2l = aClass.ToString() + bClass.ToString() + cClass.ToString() + Node.ToString();
			string adotl = aClass.ToString() + "." + bClass.ToString() + "." + cClass.ToString() + "." + Node.ToString();
			sb.AppendFormat("{0} [shape=box,fontcolor=%COLOUR%,color=%COLOUR%,fontname=\"%FONT%\",fontsize=\"10\",style=%STYLE%,label=\"{1}\\l{2}\\l\"];\r\n"
				, a2l
				, adotl
				, _osGuess);
			sb.AppendFormat("{0}->{1} [color=\"Black\"];\r\n", a2c, a2l);
			return (sb.ToString());
		}
		#endregion
		
	}
}
