using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ITTrust.UI.Common
{
	/// <summary>
	/// ����� ��� ���������� ��������� ������� �� ������ ��� ��������� ������ � ���� ��� ��������.
	/// <example><code>
	/// // 'this' must be an instance of Control.
	/// //
	/// using (new WaitCursor(this))
	/// {
	///   document.Save();
	/// }
	///
	/// // Application wide wait.
	/// //
	/// using (new WaitCursor())
	/// {
	///   document.Save();
	/// }
	/// </code></example>
	/// </summary>
	public class WaitCursor : IDisposable
	{
		public WaitCursor() : this (null)
		{
		}

		public WaitCursor(Control ctl)
		{
			_ctl           = ctl;
			_useWaitCursor = ctl != null? ctl.UseWaitCursor: Application.UseWaitCursor;

			// ���� �������� UseWaitCursor ��� ���������� � true, ������ �� �������
			if (!_useWaitCursor)
			{
				SetWaitCursor(true);
				Cursor.Current = Cursors.WaitCursor;
			}
		}

		public void Dispose()
		{
			// ���������������, ���� �����
			if (!_useWaitCursor)
			{
				SetWaitCursor(false);
				Cursor.Position = Cursor.Position;
			}

			GC.SuppressFinalize(this);
		}

		private void SetWaitCursor(bool value)
		{
			if (_ctl != null)
				_ctl.UseWaitCursor = value;
			else
				Application.UseWaitCursor = value;
		}

		private readonly Control _ctl;
		private readonly bool    _useWaitCursor;

#if DEBUG
		~WaitCursor()
		{
			Debug.Assert(false, "You forgot to dispose WaitCursor");
		}
#endif
	}
}