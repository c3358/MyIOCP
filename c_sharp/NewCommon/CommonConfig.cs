﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewCommon.Data;
namespace NewCommon
{
	public class CommonConfig
	{
		public static byte[] key = new byte[] { 0xED, 0x2A, 0x88, 0x10, 0x8D, 0x0A, 0x01, 0x1A, 0x8C, 0x5E, 0x88, 0x6E, 0xA6, 0xF8, 0xDF, 0x67, 0xE0, 0x6F, 0xDA, 0xA8, 0x62, 0xC3, 0xAB, 0x58, 0x6A, 0xDE, 0xBA, 0x7B, 0x92, 0x08, 0x93, 0xAD };
		public static byte[] iv = new byte[] { 0x15, 0xB6, 0x88, 0xE4, 0x39, 0x85, 0xD3, 0xAC, 0x48, 0x08, 0x43, 0x0E, 0x92, 0x7D, 0xCE, 0x00 };

		public static void memcpy(out byte[] target, byte[] source, int length)
		{
			target = new byte[length];
			for (int i = 0; i < length; i++)
			{
				target[i] = source[i];
			}
		}
	}
}
