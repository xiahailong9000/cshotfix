using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal enum ElementType : byte
	{
		None,
		Void,
		Boolean,
		Char,
		I1,
		U1,
		I2,
		U2,
		I4,
		U4,
		I8,
		U8,
		R4,
		R8,
		String,
		Ptr,
		ByRef,
		ValueType,
		Class,
		Var,
		Array,
		GenericInst,
		TypedByRef,
		I = 24,
		U,
		FnPtr = 27,
		Object,
		SzArray,
		MVar,
		CModReqD,
		CModOpt,
		Internal,
		Modifier = 64,
		Sentinel,
		Pinned = 69,
		Type = 80,
		Boxed,
		Enum = 85
	}
}
