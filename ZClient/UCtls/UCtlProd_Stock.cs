﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace Com.Fadong.ZClient.UCtls {
    public partial class UCtlProd_Stock : UCtlProd {
        public UCtlProd_Stock() {
            InitializeComponent();
            stock = new FInstrumentStock();
            stock.InsType = INSTYPE.Stock;
            stock.CreatedTime = DateTime.Now;
            stock.UpdatedTime = DateTime.Now;
            stock.ObjectStatus = OBJECTSTATUS.Created;
        }

        public override bool Save() {
            try {
                List<Exception> exps = new List<Exception>();

                if (txtName.Text.Length != 0) {
                    stock.Name = txtName.Text;
                } else {
                    exps.Add(new Exception("상품명이 설정되지 않음"));
                }
                for (int i = 0; i < 10000; i++) {
                    ZServer.BE.Svr.SaveInstrument(stock.ToXML());
                }
                return true;
            } catch (Exception err) {
                Logger.Error(this, err.Message);
                return false;
            }
        }

        FInstrument stock = null;
    }
}
