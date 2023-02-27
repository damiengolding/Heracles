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

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClubOfHeracles
{
    // ALLMIG too much null forgiveness going on here; made it work, now make it good
    /// <summary>
    /// Input file recognition
    /// </summary>
    /// <remarks>Attempts to identify the source tool for a scan or other output file</remarks>
    public class InputFileRecog
    {
        public record InputFileRecord(Constants.SupportedInputTypes Type, String Description);
        public InputFileRecog(string inputFile)
        {
            InputFile = inputFile;
            BuildRecords();
            FileRecog();
        }

        private string InputFile;
        //private Constants.SupportedInputTypes FileType;
        public string FileTypeString = "NONE";
        public string ExceptionMessage = string.Empty;
        private List<InputFileRecord> inputFileRecords = new List<InputFileRecord>();

        void BuildRecords()
        {
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.NMAP, "NMAP"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.MASSCAN, "MASSCAN"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.NETDISCOVER, "NETDISCOVER"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.NESSUS, "NESSUS"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.AXFR_NS_WIN, "AXFR_NS_WIN"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.AXFR_NS_LIN, "AXFR_NS_LIN"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.HASHES_PWDUMP, "HASHES_PWDUMP"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.SSLSCAN, "SSLSCAN"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.BURP_PROJECT, "BURP_PROJECT"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.BURP_ITEMS, "BURP_ITEMS"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.BURP_ISSUES, "BURP_ISSUES"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.METASPLOIT, "METASPLOIT"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.OPENVAS_XML, "OPENVAS_XML"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.OPENVAS_ANONYMOUS_XML, "OPENVAS_ANONYMOUS_XML"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.OWASPZAP, "OWASPZAP"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.NESSUS_HSH, "NESSUS_HSH"));
            inputFileRecords.Add(new InputFileRecord(Constants.SupportedInputTypes.NONE, "NONE"));
        }

        public Constants.SupportedInputTypes GetFileType()
        {
            foreach (InputFileRecord ifr in inputFileRecords)
            {
                if (ifr.Description == FileTypeString) return (ifr.Type);
            }

            return (Constants.SupportedInputTypes.NONE);
        }


        bool FailedBasicFileTest()
        {
            if (string.IsNullOrEmpty(InputFile)) return (true);
            if (!File.Exists(InputFile)) return (true);
            // TODO find a way to usefully test whether the file is binary
            return (false);
        }

        bool FileRecog()
        {
            if (FailedBasicFileTest()) return (false);
            if (ReadXmlFile()) return (true);
            if (ReadTextFile()) return (true);
            return (false);
        }
        bool ReadTextFile()
        {
            bool ret = true;
            Debug.WriteLine("Entering ReadTextFile");
            if (!File.Exists(InputFile))
            {
                FileTypeString = "NONE";
                return (false);
            }
            try
            {
                string[] lines = File.ReadAllLines(InputFile);
                if (lines.Length < 2)
                {
                    FileTypeString = "NONE";
                    return (false);
                }
                string l0 = lines[0], l1 = lines[1];
                if (l0.StartsWith("[[") && l0.EndsWith("]]"))
                {
                    FileTypeString = "AXFR_NS_WIN";
                }
                else if (l0.ToLower().StartsWith("server:") && l1.ToLower().StartsWith("address:"))
                {
                    FileTypeString = "AXFR_NS_LIN";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Exception caught in ReadTextFile: {0}", ex.Message);
                return (false);
            }
            return (ret);
        }
        bool ReadXmlFile()
        {
            bool ret = true;
            Debug.WriteLine("Entering ReadXmlFile");
            if (!File.Exists(InputFile))
            {
                FileTypeString = "NONE";
                return (false);
            }
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.DtdProcessing = System.Xml.DtdProcessing.Ignore;// DtdProcessing.Parse;
                XmlReader reader = XmlReader.Create(InputFile, settings);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Debug.WriteLine("Element name: {0}", reader.Name);
                        if (reader.Name.ToLower() == "nmaprun")
                        {
                            FileTypeString = "NMAP";
                            if (reader.HasAttributes)
                            {
                                string scanner = reader.GetAttribute("scanner")!.ToLower();
                                if (scanner.Equals("nmap"))
                                {
                                    FileTypeString = "NMAP";
                                    Debug.WriteLine("Confirmed as Nmap");
                                    break;
                                }
                                else if (scanner.Equals("masscan"))
                                {
                                    FileTypeString = "MASSCAN";
                                    Debug.WriteLine("Confirmed as masscan");
                                    break;
                                }
                            }
                            break;
                        }
                        else if (reader.Name.ToLower() == "nessusclientdata_v2")
                        {
                            FileTypeString = "NESSUS";
                            Debug.WriteLine("Confirmed as nessus");
                            break;
                        }
                        else if (reader.Name.ToLower() == "ssltest")
                        {
                            FileTypeString = "SSLSCAN";
                            Debug.WriteLine("Confirmed as SSLScan");
                            break;
                        }
                        else if (reader.Name.ToLower() == "issues")
                        {
                            FileTypeString = "BURP_ISSUES";
                            Debug.WriteLine("Confirmed as BurpSuite issues export");
                            break;
                        }
                        else if (reader.Name.ToLower() == "items")
                        {
                            FileTypeString = "BURP_ITEMS";
                            Debug.WriteLine("Confirmed as BurpSuite site tree export");
                            break;
                        }
                        else if (reader.Name.ToLower().StartsWith("metasploit"))
                        {
                            FileTypeString = "METASPLOIT";
                            Debug.WriteLine("Confirmed as Metasploit");
                            break;
                        }
                        else if (reader.Name.ToLower() == "site")
                        {
                            if (reader.GetAttribute("name")!.Length > 0)
                            {
                                FileTypeString = "OWASPZAP";
                                Debug.WriteLine("Confirmed as OWASP ZAP");
                                break;
                            }
                        }
                        else if (reader.Name.ToLower() == "report")
                        {
                            string nm = "", val = "";
                            while (reader.Read())
                            {
                                nm = reader.ToString()!.ToLower();
                                val = reader.ReadString().ToLower();
                                if (val.Equals("xml"))
                                {
                                    FileTypeString = "OPENVAS_XML";
                                    Debug.WriteLine("Confirmed as OpenVAS Standard XML");
                                    break;
                                }
                                else if (val.Equals("anonymous xml"))
                                {
                                    FileTypeString = "OPENVAS_ANONYMOUS_XML";
                                    Debug.WriteLine("Confirmed as OpenVAS Anonymous XML");
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            catch (System.Xml.XmlException xe)
            {
                Debug.WriteLine("XML related exception in FileRecog: " + xe.Message);
                ExceptionMessage = xe.Message;
                return (false);

            }
            catch (Exception e)
            {
                Debug.WriteLine("Non-XML related exception in FileRecog: " + e.Message);
                ExceptionMessage = e.Message;
            }
            finally { }
            return (ret);
        }
    }
}
