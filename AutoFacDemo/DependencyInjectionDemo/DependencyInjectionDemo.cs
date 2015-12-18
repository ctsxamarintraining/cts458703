using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

public interface IMobileMessage{
	void execute1();

}
public interface IMailMessage
{
	void execute2();
}
public interface ILetter
{
	void execute();
}


public class Mobile : IMobileMessage
{
	public void execute1()
	{
		Console.WriteLine("IMobilemessage executed");
	}
}


public class Mail : IMailMessage
{
	public  void execute2()
	{
		Console.WriteLine("IMailMessage executed");
	}
}

public class Letter : ILetter
{
	public void execute()
	{
		Console.WriteLine("ILetter executed");
	}

}
public class Notification
{
	public IMobileMessage _mobilemessage;
	public IMailMessage _mailmessage;
	public Notification(IMobileMessage mobile)
	{
		_mobilemessage = mobile;
	}
	public IMailMessage mail { set { _mailmessage = value; } }

	public  void method(ILetter l)
	{
		l.execute();
	}
	public void SendNotifications()
	{
		_mobilemessage.execute1();
		_mailmessage.execute2();

	
}
}

namespace DependencyInjectionDemo

{
			class Program
	{
			
		static void Main(string[] args)
		{


			var builder = new ContainerBuilder ();

		builder.RegisterType<Mobile> ().As<IMobileMessage> ();
		builder.RegisterType<Mail> ().As<IMailMessage> ();

		var container = builder.Build ();


		container.Resolve<IMobileMessage> ().execute1 ();
		container.Resolve<IMailMessage> ().execute2 ();
		container.Resolve<ILetter> ().execute ();


		}
	}
}







