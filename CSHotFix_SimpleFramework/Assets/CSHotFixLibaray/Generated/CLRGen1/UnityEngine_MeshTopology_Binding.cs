
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_MeshTopology_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.MeshTopology);

            field = type.GetField("Triangles", flag);
            app.RegisterCLRFieldGetter(field, get_Triangles_0);
            field = type.GetField("Quads", flag);
            app.RegisterCLRFieldGetter(field, get_Quads_1);
            field = type.GetField("Lines", flag);
            app.RegisterCLRFieldGetter(field, get_Lines_2);
            field = type.GetField("LineStrip", flag);
            app.RegisterCLRFieldGetter(field, get_LineStrip_3);
            field = type.GetField("Points", flag);
            app.RegisterCLRFieldGetter(field, get_Points_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.MeshTopology());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.MeshTopology[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.MeshTopology instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.MeshTopology[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Triangles_0(ref object o)
        {
            return UnityEngine.MeshTopology.Triangles;
        }
        static object get_Quads_1(ref object o)
        {
            return UnityEngine.MeshTopology.Quads;
        }
        static object get_Lines_2(ref object o)
        {
            return UnityEngine.MeshTopology.Lines;
        }
        static object get_LineStrip_3(ref object o)
        {
            return UnityEngine.MeshTopology.LineStrip;
        }
        static object get_Points_4(ref object o)
        {
            return UnityEngine.MeshTopology.Points;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.MeshTopology();
            ins = (UnityEngine.MeshTopology)o;
            return ins;
        }


    }
}
#endif
