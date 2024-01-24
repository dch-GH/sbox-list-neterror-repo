using System;
using System.Collections.Generic;
using Sandbox;

public sealed class MyComponent : Component
{
	public enum TestEnum
	{
		Zero,
		One,
		Two,
		Three
	}

	[Sync] public List<TestEnum> _list { get; set; }

	protected override void OnStart()
	{
		_list = new();
	}

	protected override void OnUpdate()
	{
		if ( Input.Pressed( "jump" ) )
		{
			_list.Add( TestEnum.One );
			Log.Info( $"List: {_list}" );
			foreach ( var x in _list )
			{
				Log.Info( $"Entry: {x}" );
			}
		}
	}
}
