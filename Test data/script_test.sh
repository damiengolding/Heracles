#!/bin/bash
nmap -vv -Pn -T5 -sS -A -oA wellknown --script=ip-forwarding --script=ip-geolocation-ipinfodb --script-args=ip-forwarding.target=www.google.com -p 80,443 -iL hnames.txt
