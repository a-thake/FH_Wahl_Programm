﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinWahlLFH
{
    public class Wahl
    {
        private uint _id = 0;
        private string _titel;
        private uint _maxStimmen;
        private DateTime _termin;

        public Wahl()
        {
            this._titel = string.Empty;
        }

        public Wahl(string titel, uint maxStimmen)
        {
            this._titel = titel;
            this._maxStimmen = maxStimmen;
        }

        public Wahl(string titel, uint maxStimmen, DateTime termin, uint id)
        {
            this._titel = titel;
            this._maxStimmen = maxStimmen;
            this._termin = termin;
            this._id = id;
        }

        public void SetTitel(string titel)
        {
            this._titel = titel;
        }
        public string GetTitel()
        {
            if (_titel == null)
                return string.Empty;
            else
                return _titel;
        }

        public void SetMaxStimmen(uint value)
        {
            _maxStimmen = value;
        }

        public uint GetMaxStimmen()
        {
            return _maxStimmen;
        }

        //public string Name => $"{Titel} : {string.Format("{0:dd.MM.yyyy}", _termin)}"; // 0: Platzhalter für das erste Element
        public string Name => $"{_id} : {_titel} : {_termin.ToString("dd.MM.yyyy")}";

        // einfache get Variante
        public string Titel => _titel;
        
        public DateTime Termin
        {
            get { return _termin; }
            set { _termin = value; }
        }

        public uint Id
        { 
            get { return _id; }
            set { _id = value; }
        }


    }
}
