using System;
using System.Collections.Generic;
using System.Linq;

namespace Nextmethod.Cex
{
// ReSharper disable InconsistentNaming
    public enum Symbol
    {
        BTC,    
        DVC,
        GHS,
        IXC,
        LTC,
        NMC,
        USD,
        EUR,
        ETH,
        XRP,
        BCH,
        BTG,
        DASH,
        XLM,
        ZEC,
        OMG,
        MHC,
        TRX,
        BTT,
        ADA,
        NEO,
        GAS,
        BAT,
        ATOM,
        XTZ,
        GUSD,
        ONT,
        ONG,
        USDC,
        MATIC,
        LINK,
        USDT,
        GBP
    }


    public sealed class SymbolPair
    {
        
        #region USD markets
        public static readonly SymbolPair BTC_USD = new SymbolPair(Symbol.BTC, Symbol.USD);
        public static readonly SymbolPair ETH_USD = new SymbolPair(Symbol.ETH, Symbol.USD);
        public static readonly SymbolPair BCH_USD = new SymbolPair(Symbol.BCH, Symbol.USD);
        public static readonly SymbolPair BTG_USD = new SymbolPair(Symbol.BTG, Symbol.USD);
        public static readonly SymbolPair DASH_USD = new SymbolPair(Symbol.DASH, Symbol.USD);
        public static readonly SymbolPair LTC_USD = new SymbolPair(Symbol.LTC, Symbol.USD);
        public static readonly SymbolPair XRP_USD = new SymbolPair(Symbol.XRP, Symbol.USD);
        public static readonly SymbolPair XLM_USD = new SymbolPair(Symbol.XLM, Symbol.USD);
        public static readonly SymbolPair OMG_USD = new SymbolPair(Symbol.OMG, Symbol.USD);
        public static readonly SymbolPair MHC_USD = new SymbolPair(Symbol.MHC, Symbol.USD);
        public static readonly SymbolPair TRX_USD = new SymbolPair(Symbol.TRX, Symbol.USD);
        public static readonly SymbolPair BTT_USD = new SymbolPair(Symbol.BTT, Symbol.USD);
        public static readonly SymbolPair ADA_USD = new SymbolPair(Symbol.ADA, Symbol.USD);
        public static readonly SymbolPair NEO_USD = new SymbolPair(Symbol.NEO, Symbol.USD);
        public static readonly SymbolPair GAS_USD = new SymbolPair(Symbol.GAS, Symbol.USD);
        public static readonly SymbolPair BAT_USD = new SymbolPair(Symbol.BAT, Symbol.USD);
        public static readonly SymbolPair ATOM_USD = new SymbolPair(Symbol.ATOM, Symbol.USD);
        public static readonly SymbolPair XTZ_USD = new SymbolPair(Symbol.XTZ, Symbol.USD);
        public static readonly SymbolPair GUSD_USD = new SymbolPair(Symbol.GUSD, Symbol.USD);
        public static readonly SymbolPair ONT_USD = new SymbolPair(Symbol.ONT, Symbol.USD);
        public static readonly SymbolPair ONG_USD = new SymbolPair(Symbol.ONG, Symbol.USD);
        public static readonly SymbolPair USDC_USD = new SymbolPair(Symbol.USDC, Symbol.USD);
        public static readonly SymbolPair MATIC_USD = new SymbolPair(Symbol.MATIC, Symbol.USD);
        public static readonly SymbolPair LINK_USD = new SymbolPair(Symbol.LINK, Symbol.USD);
        #endregion

        #region EUR markets
        public static readonly SymbolPair BTC_EUR = new SymbolPair(Symbol.BTC, Symbol.EUR);
        public static readonly SymbolPair ETH_EUR = new SymbolPair(Symbol.ETH, Symbol.EUR);
        public static readonly SymbolPair BCH_EUR = new SymbolPair(Symbol.BCH, Symbol.EUR);
        public static readonly SymbolPair BTG_EUR = new SymbolPair(Symbol.BTG, Symbol.EUR);
        public static readonly SymbolPair DASH_EUR = new SymbolPair(Symbol.DASH, Symbol.EUR);
        public static readonly SymbolPair LTC_EUR = new SymbolPair(Symbol.LTC, Symbol.EUR);
        public static readonly SymbolPair XRP_EUR = new SymbolPair(Symbol.XRP, Symbol.EUR);
        public static readonly SymbolPair XLM_EUR = new SymbolPair(Symbol.XLM, Symbol.EUR);
        public static readonly SymbolPair OMG_EUR = new SymbolPair(Symbol.OMG, Symbol.EUR);
        public static readonly SymbolPair MHC_EUR = new SymbolPair(Symbol.MHC, Symbol.EUR);
        public static readonly SymbolPair TRX_EUR = new SymbolPair(Symbol.TRX, Symbol.EUR);
        public static readonly SymbolPair BTT_EUR = new SymbolPair(Symbol.BTT, Symbol.EUR);
        public static readonly SymbolPair ADA_EUR = new SymbolPair(Symbol.ADA, Symbol.EUR);
        public static readonly SymbolPair NEO_EUR = new SymbolPair(Symbol.NEO, Symbol.EUR);
        public static readonly SymbolPair GAS_EUR = new SymbolPair(Symbol.GAS, Symbol.EUR);
        public static readonly SymbolPair BAT_EUR = new SymbolPair(Symbol.BAT, Symbol.EUR);
        public static readonly SymbolPair ATOM_EUR = new SymbolPair(Symbol.ATOM, Symbol.EUR);
        public static readonly SymbolPair XTZ_EUR = new SymbolPair(Symbol.XTZ, Symbol.EUR);
        public static readonly SymbolPair GUSD_EUR = new SymbolPair(Symbol.GUSD, Symbol.EUR);
        public static readonly SymbolPair ONT_EUR = new SymbolPair(Symbol.ONT, Symbol.EUR);
        public static readonly SymbolPair ONG_EUR = new SymbolPair(Symbol.ONG, Symbol.EUR);
        public static readonly SymbolPair MATIC_EUR = new SymbolPair(Symbol.MATIC, Symbol.EUR);
        public static readonly SymbolPair LINK_EUR = new SymbolPair(Symbol.LINK, Symbol.EUR);
        #endregion

        #region GBP markets
        public static readonly SymbolPair BTC_GBP = new SymbolPair(Symbol.BTC, Symbol.GBP);
        public static readonly SymbolPair ETH_GBP = new SymbolPair(Symbol.ETH, Symbol.GBP);
        public static readonly SymbolPair BCH_GBP = new SymbolPair(Symbol.BCH, Symbol.GBP);
        public static readonly SymbolPair MHC_GBP = new SymbolPair(Symbol.MHC, Symbol.GBP);
        public static readonly SymbolPair LTC_GBP = new SymbolPair(Symbol.LTC, Symbol.GBP);
        public static readonly SymbolPair XRP_GBP = new SymbolPair(Symbol.XRP, Symbol.GBP);
        public static readonly SymbolPair ADA_GBP = new SymbolPair(Symbol.ADA, Symbol.GBP);
        public static readonly SymbolPair NEO_GBP = new SymbolPair(Symbol.NEO, Symbol.GBP);
        public static readonly SymbolPair GAS_GBP = new SymbolPair(Symbol.GAS, Symbol.GBP);
        public static readonly SymbolPair BAT_GBP = new SymbolPair(Symbol.BAT, Symbol.GBP);
        public static readonly SymbolPair ATOM_GBP = new SymbolPair(Symbol.ATOM, Symbol.GBP);
        public static readonly SymbolPair XTZ_GBP = new SymbolPair(Symbol.XTZ, Symbol.GBP);
        public static readonly SymbolPair MATIC_GBP = new SymbolPair(Symbol.MATIC, Symbol.GBP);
        public static readonly SymbolPair LINK_GBP = new SymbolPair(Symbol.LINK, Symbol.GBP);
        #endregion

        #region BTC markets
        public static readonly SymbolPair ETH_BTC = new SymbolPair(Symbol.ETH, Symbol.BTC);
        public static readonly SymbolPair BCH_BTC = new SymbolPair(Symbol.BCH, Symbol.BTC);
        public static readonly SymbolPair BTG_BTC = new SymbolPair(Symbol.BTG, Symbol.BTC);
        public static readonly SymbolPair DASH_BTC = new SymbolPair(Symbol.DASH, Symbol.BTC);
        public static readonly SymbolPair LTC_BTC = new SymbolPair(Symbol.LTC, Symbol.BTC);
		public static readonly SymbolPair XRP_BTC = new SymbolPair(Symbol.XRP, Symbol.BTC);
        public static readonly SymbolPair XLM_BTC = new SymbolPair(Symbol.XLM, Symbol.BTC);
        public static readonly SymbolPair OMG_BTC = new SymbolPair(Symbol.OMG, Symbol.BTC);
        public static readonly SymbolPair MHC_BTC = new SymbolPair(Symbol.MHC, Symbol.BTC);
        public static readonly SymbolPair TRX_BTC = new SymbolPair(Symbol.TRX, Symbol.BTC);
        public static readonly SymbolPair BTT_BTC = new SymbolPair(Symbol.BTT, Symbol.BTC);
        public static readonly SymbolPair ONT_BTC = new SymbolPair(Symbol.ONT, Symbol.BTC);
        public static readonly SymbolPair ONG_BTC = new SymbolPair(Symbol.ONG, Symbol.BTC);
        #endregion

        public static readonly SymbolPair MHC_ETH = new SymbolPair(Symbol.MHC, Symbol.ETH);
        public static readonly SymbolPair BTC_USDC = new SymbolPair(Symbol.BTC, Symbol.USDC);

        #region USDT Market
        public static readonly SymbolPair BTC_USDT = new SymbolPair(Symbol.BTC, Symbol.USDT);
        public static readonly SymbolPair ETH_USDT = new SymbolPair(Symbol.ETH, Symbol.USD);
        public static readonly SymbolPair LTC_USDT = new SymbolPair(Symbol.LTC, Symbol.USDT);
        public static readonly SymbolPair XRP_USDT = new SymbolPair(Symbol.XRP, Symbol.USDT);
        public static readonly SymbolPair ADA_USDT = new SymbolPair(Symbol.ADA, Symbol.USDT);
        #endregion

        private SymbolPair(KeyValuePair<Symbol, Symbol> pair)
            : this(pair.Key, pair.Value)
        {}

        private SymbolPair(Symbol @from, Symbol to)
        {
            From = @from;
            To = to;
        }

        public Symbol From { get; private set; }

        public Symbol To { get; private set; }

        public bool Equals(SymbolPair other)
        {
            return From == other.From && To == other.To;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != this.GetType()) { return false; }
            return Equals((SymbolPair) obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int) From * 397) ^ (int) To; }
        }

        public static bool operator ==(SymbolPair left, SymbolPair right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SymbolPair left, SymbolPair right)
        {
            return !Equals(left, right);
        }

    }

// ReSharper restore InconsistentNaming


    internal static class SymbolExtensions
    {

        public static string Name(this Symbol sym)
        {
            return sym.ToString();
        }

    }

}
