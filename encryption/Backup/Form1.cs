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
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// ����������������
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
			// Windows ���������֧���������
			//
			InitializeComponent();
            
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.button1.Text = "����";
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
			this.label1.Text = "�����ܵ��ļ���";
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
			this.label2.Text = "���ܺ���ļ���";
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
			this.label3.Text = "����";
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
			this.label4.Text = "����һ������";
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
			this.label5.Text = "��������룬һ����ʧ���룬�����ļ�����Զ�޷��⿪��";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(272, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 24);
			this.button3.TabIndex = 7;
			this.button3.Text = "�˳�";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(368, 40);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 12;
			this.button4.Text = "���";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(368, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 24);
			this.button5.TabIndex = 13;
			this.button5.Text = "���";
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
			this.menuItem3.Text = "����ѡ��";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "����";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "����";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem6});
			this.menuItem1.Text = "����";
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
			this.Text = "ͨ���ļ������� encryption v1.0.0   ����2005";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{   string strMsg="";
			//����ļ��ĺϷ���
			if(button1.Text=="����")
			{   
				if(textBox2.Text.Trim().ToUpper().LastIndexOf(".ENC")==-1)
				{
					MessageBox.Show("�����ļ�����չ������Ϊ.enc!","Warning",
					 MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox2.Focus();
					return;
				}	
				strMsg="������ɣ����μ����룡";
			   }
			else{			
				if(textBox1.Text.Trim().ToUpper().LastIndexOf(".ENC")==-1)
				{
					MessageBox.Show("�������ļ�����չ������Ϊ.enc!","Warning",
						MessageBoxButtons.OK,MessageBoxIcon.Warning);
					textBox1.Focus();
					return;
				}			
				strMsg="������ɣ�";
			}
			if(textBox1.Text.Trim()==textBox2.Text.Trim())
			{
				MessageBox.Show("�����ļ��뱻�����ļ�������","warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
				MessageBox.Show("���벻��Ϊ�գ�");
	            return;		
			}
			if(textBox3.Text!=textBox4.Text){
			    MessageBox.Show("�������벻һ�£����������룡","warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			    textBox3.Focus();
				return;
			}

			MyClass = new MyFile(textBox1.Text,textBox2.Text,textBox3.Text,progressBar1);
			
			if (!MyClass.encoded())
			{
				if (MyClass.encry())
				 				
					MessageBox.Show( strMsg,
						"��ʾ��Ϣ", MessageBoxButtons.OK,MessageBoxIcon.Information);
		 			  				 
				else
				 
					MessageBox.Show(textBox1.Text +" ����/����ʧ�ܣ�",
						"Failure",MessageBoxButtons.OK,MessageBoxIcon.Information);
				 
			}

			else
				MessageBox.Show("�Ѿ��������ˣ�");           
            
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
		   MessageBox.Show("����ԭ��A xor PWD = C (����) \x0d"+
			               "          C xor PWD = A (����) \x0d"+
                           "ע�⣺�����ļ�����չ������Ϊ .enc \x0d"+
                           "���⣬��Ҫɾ��ԭ�ļ������������ã�\x0d"+
			               "ԭ�ļ��ѱ�д�����õ���Ϣ���������룬\x0d"+
			               "����Ҳ�޷�����! ��������룡\x0d"+
			               "���ܹ��̣��򿪹��ܲ˵���ѡ��\"����\"\0xd"+
			               "��������ܵ��ļ����������룬Ȼ�����ظ�һ��\x0d"+
			               "������ܺ���ļ�������չ������Ϊ.enc \x0d"+
			               "�� ���� ��ť���м��ܣ� \x0d"+
			               "���ܹ������ƣ�ֻ����*.enc-->*.*"+
                           "��ϵ��ʽ:  CanX027@163.com",
           "Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		label1.Text="�����ܵ��ļ���";
        label2.Text="�����ļ���";
		button1.Text="����";
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			label1.Text="�����ܵ��ļ���";
			label2.Text="���ܺ���ļ���";
			button1.Text="����";
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
        string FILE_NAME = FName;  //�����ܵ��ļ�;
        string FILE_OUT=FOName;//����ļ����ļ�;
		string PassWord=PWD;  //����
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

			wo.Write((byte)(r.ReadByte()^(byte)PassWord[i%PassWord.Length]));//�ؼ�������������
			wo.Write((byte)(r.ReadByte()));
			pb.Value+=2;
		}
			wo.Close();
            fso.Close();
			r.Close();
            fs.Close();
//    ����ԭ�ļ��Ǽ����ļ�����Ҫ��д��ENCODEDBYJC��
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
