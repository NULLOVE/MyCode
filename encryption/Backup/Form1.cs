using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace encryption
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.DirectoryServices.DirectorySearcher directorySearcher1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
        private string DefaultPath=@" C:\Documents and Settings\";
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		
		MyFile MyClass;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
            
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(248, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 216);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 24);
			this.button1.TabIndex = 5;
			this.button1.Text = "加密";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "被加密的文件名";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 149);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(248, 21);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "加密后的文件名";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(112, 80);
			this.textBox3.MaxLength = 16;
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(248, 21);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "密码";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(16, 184);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(408, 24);
			this.progressBar1.TabIndex = 8;
			this.progressBar1.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "再输一遍密码";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(112, 112);
			this.textBox4.MaxLength = 16;
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '*';
			this.textBox4.Size = new System.Drawing.Size(248, 21);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(56, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(368, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "请谨记密码，一旦丢失密码，加密文件将永远无法解开！";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(272, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 24);
			this.button3.TabIndex = 7;
			this.button3.Text = "退出";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(368, 40);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 12;
			this.button4.Text = "浏览";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(368, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 24);
			this.button5.TabIndex = 13;
			this.button5.Text = "浏览";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem1});
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem3.Text = "功能选择";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "加密";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "解密";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem6});
			this.menuItem1.Text = "帮助";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "About encryption";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "Help";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 254);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "通用文件加密器 encryption v1.0.0   蒋程2005";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{   string strMsg="";
			//检查文件的合法性
			if(button1.Text=="加密")
			{   
				if(textBox2.Text.Trim().ToUpper().LastIndexOf(".ENC")==-1)
				{
					MessageBox.Show("加密文件的扩展名必须为.enc!","Warning",
					 MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox2.Focus();
					return;
				}	
				strMsg="加密完成！请牢记密码！";
			   }
			else{			
				if(textBox1.Text.Trim().ToUpper().LastIndexOf(".ENC")==-1)
				{
					MessageBox.Show("被解密文件的扩展名必须为.enc!","Warning",
						MessageBoxButtons.OK,MessageBoxIcon.Warning);
					textBox1.Focus();
					return;
				}			
				strMsg="解密完成！";
			}
			if(textBox1.Text.Trim()==textBox2.Text.Trim())
			{
				MessageBox.Show("加密文件与被加密文件重名！","warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				textBox1.Focus();
				return;
						
			}
			
			if (!File.Exists(textBox1.Text)){
		        MessageBox.Show(textBox1.Text +" does not exist!","Warning");	
			    textBox1.Focus();
				return;			
			} 

			if (File.Exists(textBox2.Text))
			{
				if(MessageBox.Show(textBox2.Text +" will be overwrite! Are you sure?",
				"Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation)!=DialogResult.Yes)
				{				
			      textBox2.Focus();
				  return;			
				}	
				
			} 
		
//check password
			textBox3.Text=textBox3.Text.Trim();
			textBox4.Text=textBox4.Text.Trim();
			if(textBox3.Text.Length==0)
			{
				MessageBox.Show("密码不能为空！");
	            return;		
			}
			if(textBox3.Text!=textBox4.Text){
			    MessageBox.Show("密码输入不一致！请重新输入！","warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			    textBox3.Focus();
				return;
			}

			MyClass = new MyFile(textBox1.Text,textBox2.Text,textBox3.Text,progressBar1);
			
			if (!MyClass.encoded())
			{
				if (MyClass.encry())
				 				
					MessageBox.Show( strMsg,
						"提示信息", MessageBoxButtons.OK,MessageBoxIcon.Information);
		 			  				 
				else
				 
					MessageBox.Show(textBox1.Text +" 加密/解密失败！",
						"Failure",MessageBoxButtons.OK,MessageBoxIcon.Information);
				 
			}

			else
				MessageBox.Show("已经被加密了！");           
            
		}

		 
		private void button3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			if (e.ToString().Equals('\x0D')){
										textBox2.Focus();	  
											  }
		}

		private void button4_Click(object sender, System.EventArgs e)
		{ 
			Stream myStream;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = DefaultPath ;
////			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
////			openFileDialog1.FilterIndex = 2 ;
////			openFileDialog1.RestoreDirectory = true ;

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog1.OpenFile())!= null)
				{					
					myStream.Close();
					textBox1.Text = openFileDialog1.FileName.ToString();
				}
				else
				{
				   MessageBox.Show("File does not exist!","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
				
					
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = DefaultPath ;
			openFileDialog1.Filter = "enc files (*.enc)|*.enc|All files (*.*)|*.*" ;
			openFileDialog1.FilterIndex = 2 ;
////			openFileDialog1.RestoreDirectory = true ;

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog1.OpenFile())!= null)
				{					
					myStream.Close();					 
					textBox2.Text = openFileDialog1.FileName.ToString();					
					
				}
						
					
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
		   MessageBox.Show("加密原理：A xor PWD = C (加密) \x0d"+
			               "          C xor PWD = A (解密) \x0d"+
                           "注意：加密文件的扩展名必须为 .enc \x0d"+
                           "另外，不要删除原文件，以作解密用！\x0d"+
			               "原文件已被写入无用的信息，若无密码，\x0d"+
			               "本人也无法解密! 请记牢密码！\x0d"+
			               "加密过程：打开功能菜单，选择\"加密\"\0xd"+
			               "输入待加密的文件，输入密码，然后再重复一遍\x0d"+
			               "输入加密后的文件名，扩展名必须为.enc \x0d"+
			               "按 加密 按钮进行加密！ \x0d"+
			               "解密过程类似，只是由*.enc-->*.*"+
                           "联系方式:  CanX027@163.com",
           "Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		label1.Text="被解密的文件名";
        label2.Text="解密文件名";
		button1.Text="解密";
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			label1.Text="被加密的文件名";
			label2.Text="加密后的文件名";
			button1.Text="加密";
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
		
		}

					
	}
	public class MyFile{
		private string FName;
		private string FOName;
		private string PWD;
        private ProgressBar pb;
        FileInfo fi;
		private const int MAXINT=2147483647;
		public MyFile(string FN,string FON,string PassWord,ProgressBar prb){
		  FName=FN;		
		  FOName=FON;
		  PWD=PassWord;
		  pb=prb;
		}
    
		public bool encoded(){
		  return false;
		}
		public bool encry(){
		int FileLen;
		FileStream fs;
		BinaryReader r;

		char[] MSG={'E','N','C','O','D','E','D','B','Y','J','C'};
        string FILE_NAME = FName;  //被加密的文件;
        string FILE_OUT=FOName;//输出的加密文件;
		string PassWord=PWD;  //密码
		PassWord.ToCharArray();
			try
			{
				fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
				r = new BinaryReader(fs);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString(),"Warning!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			 return false;
			}
	   	    fi=new FileInfo(FILE_NAME);
			if(fi.Length >MAXINT)
			{
				MessageBox.Show( " File is too large to encode! ");
			    return false;
			}

		FileLen=(int)fi.Length ;
		
		FileStream fso = new FileStream(FILE_OUT, FileMode.Create);
		BinaryWriter wo = new BinaryWriter(fso);
//		 Read data from Test.data.
	     pb.Maximum=FileLen;
         pb.Value=0;
		 pb.Visible =true;
		for(int i=0;i<FileLen;i+=2)
		{  

			wo.Write((byte)(r.ReadByte()^(byte)PassWord[i%PassWord.Length]));//关键，进行异或操作
			wo.Write((byte)(r.ReadByte()));
			pb.Value+=2;
		}
			wo.Close();
            fso.Close();
			r.Close();
            fs.Close();
//    若是原文件是加密文件，则不要回写“ENCODEDBYJC”
			if(FILE_NAME.ToUpper().IndexOf(".ENC")==-1) 
			{
				fs = new FileStream(FILE_NAME, FileMode.Create);
				BinaryWriter w = new BinaryWriter(fs);
				fi=new FileInfo(FILE_NAME);	
			
				for(int i=0;i<99;i++)
				{			 
					w.Write((byte)MSG[i%MSG.Length]);
				}
				r.Close();
				fs.Close ();
			}
		  pb.Visible =false;
		  return true;
    
    }
	
	}
}
