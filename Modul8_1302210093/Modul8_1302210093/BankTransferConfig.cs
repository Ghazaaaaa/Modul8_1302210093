﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Modul8_1302210093
{
    public class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public string[] methods { get; set; }
        public Confirmation confirmation { get; set; }
        public BankTransferConfig()
        {
            lang = "en";
            transfer = new Transfer();
            transfer.low_fee = 6500;
            transfer.high_fee = 15000;
            transfer.threshold = 25000000;
            methods = new string[] { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            confirmation = new Confirmation();
            confirmation.en = "yes";
            confirmation.id = "ya";

        }
    }
    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }

    }
    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
}
