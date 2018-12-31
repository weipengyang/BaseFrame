using BaseFrame.Core;

namespace TestPluginForm
{
	public class ShowCommannd:Command
    {
		public override bool Enable()
		{
			return true;
		}

		public override void Run()
		{
			Form1 form = new Form1();
			form.ShowDialog();
		}

	}
}
