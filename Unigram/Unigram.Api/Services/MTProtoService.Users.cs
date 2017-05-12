﻿using System;
using Telegram.Api.Extensions;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods.Users;

namespace Telegram.Api.Services
{
	public partial class MTProtoService
	{
        public void GetUsersAsync(TLVector<TLInputUserBase> id, Action<TLVector<TLUserBase>> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLUsersGetUsers { Id = id };

            const string caption = "users.getUsers";
            SendInformativeMessage<TLVector<TLUserBase>>(caption, obj, result =>
            {
                _cacheService.SyncUsers(result, callback);
            }, 
            faultCallback);
        }

        public void GetFullUserAsync(TLInputUserBase id, Action<TLUserFull> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLUsersGetFullUser { Id = id };

            const string caption = "users.getFullUser";
            SendInformativeMessage<TLUserFull>(caption, obj, userFull =>
            {
                _cacheService.SyncUser(userFull, result => callback?.Invoke(result));
            },
            faultCallback);
        }
	}
}
