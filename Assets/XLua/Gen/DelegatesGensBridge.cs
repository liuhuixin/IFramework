﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;


namespace XLua
{
    public partial class DelegateBridge : DelegateBridgeBase
    {
		
		public void __Gen_Delegate_Imp0(XLua.LuaFunction p0, object[] p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.Push(L, p0);
                if (p1 != null)  { for (int __gen_i = 0; __gen_i < p1.Length; ++__gen_i) translator.PushAny(L, p1[__gen_i]); };
                
                PCall(L, 1 + (p1 == null ? 0 : p1.Length), 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp1(int p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                
                LuaAPI.xlua_pushinteger(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public UnityEngine.Vector3 __Gen_Delegate_Imp2(UnityEngine.Vector3 p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushUnityEngineVector3(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                UnityEngine.Vector3 __gen_ret;translator.Get(L, errFunc + 1, out __gen_ret);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public IFramework.Hotfix.Lua.MyStruct __Gen_Delegate_Imp3(IFramework.Hotfix.Lua.MyStruct p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushIFrameworkHotfixLuaMyStruct(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                IFramework.Hotfix.Lua.MyStruct __gen_ret;translator.Get(L, errFunc + 1, out __gen_ret);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public IFramework.Hotfix.Lua.MyEnum __Gen_Delegate_Imp4(IFramework.Hotfix.Lua.MyEnum p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushIFrameworkHotfixLuaMyEnum(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                IFramework.Hotfix.Lua.MyEnum __gen_ret;translator.Get(L, errFunc + 1, out __gen_ret);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public decimal __Gen_Delegate_Imp5(decimal p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushDecimal(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                decimal __gen_ret;translator.Get(L, errFunc + 1, out __gen_ret);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp6(System.Array p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.Push(L, p0);
                
                PCall(L, 1, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp7()
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                
                
                PCall(L, 0, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp8(bool p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                
                LuaAPI.lua_pushboolean(L, p0);
                
                PCall(L, 1, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp9(int p0, string p1, out Tutorial.CSCallLua.DClass p2)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                LuaAPI.xlua_pushinteger(L, p0);
                LuaAPI.lua_pushstring(L, p1);
                
                PCall(L, 2, 2, errFunc);
                
                p2 = (Tutorial.CSCallLua.DClass)translator.GetObject(L, errFunc + 2, typeof(Tutorial.CSCallLua.DClass));
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public System.Action __Gen_Delegate_Imp10()
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                
                PCall(L, 0, 1, errFunc);
                
                
                System.Action __gen_ret = translator.GetDelegate<System.Action>(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public IFramework.Hotfix.Lua.Luac.ICalc __Gen_Delegate_Imp11(int p0, string[] p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                LuaAPI.xlua_pushinteger(L, p0);
                if (p1 != null)  { for (int __gen_i = 0; __gen_i < p1.Length; ++__gen_i) LuaAPI.lua_pushstring(L, p1[__gen_i]); };
                
                PCall(L, 1 + (p1 == null ? 0 : p1.Length), 1, errFunc);
                
                
                IFramework.Hotfix.Lua.Luac.ICalc __gen_ret = (IFramework.Hotfix.Lua.Luac.ICalc)translator.GetObject(L, errFunc + 1, typeof(IFramework.Hotfix.Lua.Luac.ICalc));
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp12(object p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                
                PCall(L, 1, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp13(object p0, int p1, int p2)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                LuaAPI.xlua_pushinteger(L, p2);
                
                PCall(L, 3, 1, errFunc);
                
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public UnityEngine.Vector3 __Gen_Delegate_Imp14(object p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                translator.PushUnityEngineVector3(L, p1);
                translator.PushUnityEngineVector3(L, p2);
                
                PCall(L, 3, 1, errFunc);
                
                
                UnityEngine.Vector3 __gen_ret;translator.Get(L, errFunc + 1, out __gen_ret);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp15(object p0, int p1, out double p2, ref string p3)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                LuaAPI.lua_pushstring(L, p3);
                
                PCall(L, 3, 3, errFunc);
                
                p2 = LuaAPI.lua_tonumber(L, errFunc + 2);
                p3 = LuaAPI.lua_tostring(L, errFunc + 3);
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp16(object p0, int p1, out double p2, ref string p3, object p4)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                LuaAPI.lua_pushstring(L, p3);
                translator.PushAny(L, p4);
                
                PCall(L, 4, 3, errFunc);
                
                p2 = LuaAPI.lua_tonumber(L, errFunc + 2);
                p3 = LuaAPI.lua_tostring(L, errFunc + 3);
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp17(object p0, int p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                
                PCall(L, 2, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public string __Gen_Delegate_Imp18(object p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                string __gen_ret = LuaAPI.lua_tostring(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public UnityEngine.GameObject __Gen_Delegate_Imp19(IFramework.Hotfix.Lua.StructTest p0, int p1, object p2)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.Push(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                translator.PushAny(L, p2);
                
                PCall(L, 3, 1, errFunc);
                
                
                UnityEngine.GameObject __gen_ret = (UnityEngine.GameObject)translator.GetObject(L, errFunc + 1, typeof(UnityEngine.GameObject));
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public string __Gen_Delegate_Imp20(IFramework.Hotfix.Lua.StructTest p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.Push(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                string __gen_ret = LuaAPI.lua_tostring(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp21(IFramework.Hotfix.Lua.StructTest p0, object p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.Push(L, p0);
                translator.PushAny(L, p1);
                
                PCall(L, 2, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp22(object p0)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                
                PCall(L, 1, 1, errFunc);
                
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp23(object p0, object p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                translator.PushAny(L, p1);
                
                PCall(L, 2, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public int __Gen_Delegate_Imp24(object p0, object p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                translator.PushAny(L, p1);
                
                PCall(L, 2, 1, errFunc);
                
                
                int __gen_ret = LuaAPI.xlua_tointeger(L, errFunc + 1);
                LuaAPI.lua_settop(L, errFunc - 1);
                return  __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp25(object p0, object p1, int p2)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                translator.PushAny(L, p1);
                LuaAPI.xlua_pushinteger(L, p2);
                
                PCall(L, 3, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp26(int p0, int p1)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                
                LuaAPI.xlua_pushinteger(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                
                PCall(L, 2, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
		public void __Gen_Delegate_Imp27(object p0, int p1, int p2)
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
                RealStatePtr L = luaEnv.rawL;
                int errFunc = LuaAPI.pcall_prepare(L, errorFuncRef, luaReference);
                ObjectTranslator translator = luaEnv.translator;
                translator.PushAny(L, p0);
                LuaAPI.xlua_pushinteger(L, p1);
                LuaAPI.xlua_pushinteger(L, p2);
                
                PCall(L, 3, 0, errFunc);
                
                
                
                LuaAPI.lua_settop(L, errFunc - 1);
                
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        
        
		static DelegateBridge()
		{
		    Gen_Flag = true;
		}
		
		public override Delegate GetDelegateByType(Type type)
		{
		
		    if (type == typeof(IFramework.Hotfix.Lua.DoSth2))
			{
			    return new IFramework.Hotfix.Lua.DoSth2(__Gen_Delegate_Imp0);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.IntParam))
			{
			    return new IFramework.Hotfix.Lua.IntParam(__Gen_Delegate_Imp1);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.Vector3Param))
			{
			    return new IFramework.Hotfix.Lua.Vector3Param(__Gen_Delegate_Imp2);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.CustomValueTypeParam))
			{
			    return new IFramework.Hotfix.Lua.CustomValueTypeParam(__Gen_Delegate_Imp3);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.EnumParam))
			{
			    return new IFramework.Hotfix.Lua.EnumParam(__Gen_Delegate_Imp4);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.DecimalParam))
			{
			    return new IFramework.Hotfix.Lua.DecimalParam(__Gen_Delegate_Imp5);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.ArrayAccess))
			{
			    return new IFramework.Hotfix.Lua.ArrayAccess(__Gen_Delegate_Imp6);
			}
		
		    if (type == typeof(System.Action))
			{
			    return new System.Action(__Gen_Delegate_Imp7);
			}
		
		    if (type == typeof(UnityEngine.Events.UnityAction))
			{
			    return new UnityEngine.Events.UnityAction(__Gen_Delegate_Imp7);
			}
		
		    if (type == typeof(System.Action<bool>))
			{
			    return new System.Action<bool>(__Gen_Delegate_Imp8);
			}
		
		    if (type == typeof(Tutorial.CSCallLua.FDelegate))
			{
			    return new Tutorial.CSCallLua.FDelegate(__Gen_Delegate_Imp9);
			}
		
		    if (type == typeof(Tutorial.CSCallLua.GetE))
			{
			    return new Tutorial.CSCallLua.GetE(__Gen_Delegate_Imp10);
			}
		
		    if (type == typeof(IFramework.Hotfix.Lua.Luac.CalcNew))
			{
			    return new IFramework.Hotfix.Lua.Luac.CalcNew(__Gen_Delegate_Imp11);
			}
		
		    return null;
		}
	}
    
}