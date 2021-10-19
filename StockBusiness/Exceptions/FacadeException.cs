using System;
using ST.Utils;
using ST.Facade;
using ST.Exceptions;
using ST.Business;
using ST.Model;
namespace ST.Exceptions
{
	public class FacadeException : Exception
	{
		public FacadeException(String message) : base(message)
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public FacadeException(Exception e)
		{			
		}
	}
}