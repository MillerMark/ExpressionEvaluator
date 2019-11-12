/******************************************************************************************************
    Title : ExpressionEvaluator (https://github.com/codingseb/ExpressionEvaluator)
    Version : 1.4.4.0 
    (if last digit (the forth) is not a zero, the version is an intermediate version and can be unstable)

    Author : Mark Miller
    License : MIT (https://github.com/codingseb/ExpressionEvaluator/blob/master/LICENSE.md)
*******************************************************************************************************/

using System;
using System.Linq;

namespace CodingSeb.ExpressionEvaluator
{
	public delegate void ExecutionPointerChangedHandler(object sender, ExecutionPointerChangedEventArgs ea);
	public class ExecutionPointerChangedEventArgs : EventArgs
	{
		public ExecutionPointerChangedEventArgs()
		{
		}

		public void Set(string originalScript, int oldExecutionPointer, int oldExecutionLength, int executionPointer, int executionLength, string script)
		{
			Script = script;
			OriginalScript = originalScript;
			ExecutionPointer = executionPointer;
			OldExecutionLength = oldExecutionLength;
			OldExecutionPointer = oldExecutionPointer;
			ExecutionLength = executionLength;
		}

		public int ExecutionLength { get; set; }
		public int OldExecutionPointer { get; set; }
		public int OldExecutionLength { get; set; }
		public int ExecutionPointer { get; set; }
		public string OriginalScript { get; set; }
		public string Script { get; set; }
	}
}
