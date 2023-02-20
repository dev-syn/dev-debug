/*
    © Copyright 2023 Dev Syn, Casey Ollis
    
    This file is part of DevDebug
    
    DevDebug is a free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published
    by the Free Software Foundation, either version 3 of the License, or any later version.

    DevDebug is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with DevDebug.  If not, see https://www.gnu.org/licenses/agpl-3.0.txt or a later variation
    of the GNU Affero General Public License at https://www.gnu.org/licenses/.
    
    Source code for DevDebug can be found at https://github.com/dev-syn/dev-debug
*/

using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace DevDebug.Runtime {
	
	public static class DevDebug {

	#region Asserts
		
		[Conditional("DEV_BUILD"), Conditional("UNITY_ASSERTS")]
		public static void Assert(bool condition) { Debug.Assert(condition); }
		
		[Conditional("DEV_BUILD"), Conditional("UNITY_ASSERTS")]
		public static void Assert(bool condition, Object context) { Debug.Assert(condition,context); }
		
		[Conditional("DEV_BUILD"), Conditional("UNITY_ASSERTS")]
		public static void Assert(bool condition, object message) { Debug.Assert(condition,message); }
		
		[Conditional("DEV_BUILD"), Conditional("UNITY_ASSERTS")]
		public static void Assert(bool condition, object message, Object context) { Debug.Assert(condition,message, context); }
		
	#endregion

	#region DrawLine & DrawRay

		[Conditional("DEV_BUILD")]
		public static void DrawLine(Vector3 start, Vector3 end, Color color = default, float duration = 0.0f, bool depthTest = true) {
			Debug.DrawLine(start,end,color,duration,depthTest);
		}
		
		[Conditional("DEV_BUILD")]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color = default, float duration = 0.0f, bool depthTest = true) {
			Debug.DrawRay(start,dir,color,duration,depthTest);
		}
		
	#endregion

	#region General
		
		[Conditional("DEV_BUILD")]
		public static void Log(object message) { Debug.Log(message); }
		
		[Conditional("DEV_BUILD")]
		public static void Log(object message, Object context) { Debug.Log(message,context); }
		
		[Conditional("DEV_BUILD")]
		public static void Error(object message) { Debug.LogError(message); }
		
		[Conditional("DEV_BUILD")]
		public static void Error(object message, Object context) { Debug.LogError(message,context); }
		
		[Conditional("DEV_BUILD")]
		public static void Warn(object message) { Debug.LogWarning(message); }
		
		[Conditional("DEV_BUILD")]
		public static void Warn(object message, Object context) { Debug.LogWarning(message,context); }

	#endregion
		
	}

}