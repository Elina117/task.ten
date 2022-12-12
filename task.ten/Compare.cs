using System;
namespace task.ten
{
	public class Compare
	{
        //издатель
        public delegate void Reaction(string entered);
        public event Reaction React;

        public void compare(string entered)
		{
            React(entered);
        }
	}
}

