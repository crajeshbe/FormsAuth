using System;
namespace FormsAuthOnly.Configuration
{
	public enum MachineKeyValidation
	{
		MD5,
		SHA1,
		TripleDES,
		AES,
		HMACSHA256,
		HMACSHA384,
		HMACSHA512,
		Custom
	}
}
