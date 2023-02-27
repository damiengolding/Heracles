#!/bin/bash
nmap -vv -Pn -T5 -sS -A -oA external -p 80,443 -iL hnames.txt --script=ip-forwarding --script-args="ip-forwarding.target=www.google.com"
