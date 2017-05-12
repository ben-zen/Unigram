﻿using System;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods;
using Telegram.Api.TL.Methods.Updates;

namespace Telegram.Api.Services
{
	public partial class MTProtoService
	{
        public void GetStateAsync(Action<TLUpdatesState> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLUpdatesGetState();

            SendInformativeMessage("updates.getState", obj, callback, faultCallback);
        }

        public void GetStateWithoutUpdatesAsync(Action<TLUpdatesState> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLInvokeWithoutUpdates { Query = new ITLUpdatesGetState() };

            SendInformativeMessage("updates.getState", obj, callback, faultCallback);
        }

        public void GetDifferenceAsync(int pts, int date, int qts, Action<TLUpdatesDifferenceBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLUpdatesGetDifference { Date = date, Pts = pts, Qts = qts };

            SendInformativeMessage("updates.getDifference", obj, callback, faultCallback);
        }

        public void GetDifferenceWithoutUpdatesAsync(int pts, int date, int qts, Action<TLUpdatesDifferenceBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLUpdatesGetDifference { Date = date, Pts = pts, Qts = qts };

            SendInformativeMessage("updates.getDifference", new ITLInvokeWithoutUpdates{Query = obj}, callback, faultCallback);
        }
	}
}
