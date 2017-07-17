using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class Invoice
    {
        public int INVOICE_NO { get; set; }
        public int MOVED_RECIEPT { get; set; }
        public string INVOICE_DATE { get; set; }
        public int VENDOR_ID{ get; set; }
        public int RPS_ID{ get; set; }
        public string COMMODITY{ get;set;}
        public int TRADED{get;set;}
        public string COMMODITY_CODE{get;set;}
        public string FRR_NO{ get; set;}
        public string LPC{get;set;}
        public string VFA{get;set;}
        public float BARREL_QTY{get;set;}
        public float LUMB_QTY{get;set;}
        public float EMPTY_QTY { get; set; }
        public float WET_WT{get;set;}
        public float DRC{get;set;}
        public float RATE_KG{get;set;}
        public int SPOT_CONTRACT{get;set;}
        public string CODE_NO{get;set;}
        public float DRY_WT{get;set;}
        public float AMOUNT{ get; set;}
        public float LUMB_PRICE { get; set; }
        public float LUMB_AMOUNT { get; set; }
        public float NO_TAX_AMOUNT { get; set; }
        public float CGST{ get; set;}
        public float SGST{get;set;}
        public float TOTAL_AMOUNT{ get;set;}


        public Invoice(int ino, int moved, string date,int vid,int rid,string comm,int trade,string commcode,string frr,string lpc,string vfa,float bqty,float lqty,float eqty,float wwt,float drc,float ratekg,int spot_contract,string code,float dwt,float amnt,float lumbprice,float lumbamnt,float notaxamnt,float cgst,float sgst,float tamnt)

        {
            this.INVOICE_NO = ino;
            this.MOVED_RECIEPT = moved;
            this.INVOICE_DATE = date;
            this.VENDOR_ID = vid;
            this.RPS_ID = rid;
            this.COMMODITY = comm;
            this.COMMODITY_CODE = commcode;
            this.FRR_NO = frr;
            this.LPC = lpc;
            this.VFA = vfa;
            this.BARREL_QTY = bqty;
            this.LUMB_QTY = lqty;
            this.EMPTY_QTY = eqty;
            this.WET_WT = wwt;
            this.DRC = drc;
            this.RATE_KG = ratekg;
            this.SPOT_CONTRACT = spot_contract;
            this.CODE_NO = code;
            this.DRY_WT = dwt;
            this.AMOUNT = amnt;
            this.LUMB_PRICE = lumbprice;
            this.LUMB_AMOUNT = lumbamnt;
            this.NO_TAX_AMOUNT = notaxamnt;
            this.CGST = cgst;
            this.SGST = sgst;
            this.TOTAL_AMOUNT = tamnt;

        }
    }
}
