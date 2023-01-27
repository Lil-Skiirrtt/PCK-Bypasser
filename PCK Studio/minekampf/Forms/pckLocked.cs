using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MinecraftUSkinEditor;

namespace minekampf.Forms
{
	// Token: 0x02000071 RID: 113
	public partial class pckLocked : MetroForm
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00003598 File Offset: 0x00001798
		public pckLocked(string pass, bool correct)
		{
			this.pass = pass;
			this.InitializeComponent();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000035AD File Offset: 0x000017AD
		private void textBoxPass_Click(object sender, EventArgs e)
		{
			if (this.textBoxPass.Text == "Password")
			{
				this.textBoxPass.Text = "";
				this.textBoxPass.UseSystemPasswordChar = true;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000035E2 File Offset: 0x000017E2
		private void buttonUnlocked_Click(object sender, EventArgs e)
		{
			if (this.textBoxPass.Text == this.pass)
			{
				FormMain.correct = true;
				base.Close();
				return;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000035AD File Offset: 0x000017AD
		private void textBoxPass_TextChanged(object sender, EventArgs e)
		{
			if (this.textBoxPass.Text == "Password")
			{
				this.textBoxPass.Text = "";
				this.textBoxPass.UseSystemPasswordChar = true;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000035AD File Offset: 0x000017AD
		private void textBoxPass_Enter(object sender, EventArgs e)
		{
			if (this.textBoxPass.Text == "Password")
			{
				this.textBoxPass.Text = "";
				this.textBoxPass.UseSystemPasswordChar = true;
			}
		}

		// Token: 0x0400033E RID: 830
		private string pass;
	}
}
