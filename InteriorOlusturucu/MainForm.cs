/*
 * Created by SharpDevelop.
 * User: Acr
 * Date: 25.01.2025
 * Time: 17:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace InteriorOlusturucu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			txtPlayerAngle1.Text = "24";
			txtPlayerAngle2.Text = "24";
		}
		bool isOk = false;
		void Listele()
		{
			string textToRemove = "end";
			lbListe.Items.Clear();
			string[] ls = File.ReadAllLines(txtFileWay.Text+@"\data\maps\int\int.ipl");
	        List<string> newLines = new List<string>();
	        foreach (string line in ls)
	        {
	            if (!line.Contains(textToRemove))
	            {
	                newLines.Add(line);
	            }
	        }
	        File.WriteAllLines(txtFileWay.Text+@"\data\maps\int\int.ipl", newLines.ToArray());
			if(File.Exists(txtFileWay.Text+@"\data\maps\int\int.ipl"))
			{
				string[] lines=File.ReadAllLines(txtFileWay.Text+@"\data\maps\int\int.ipl");
				foreach(var line in lines)
				{
					lbListe.Items.Add(line);
				}
				lbListe.Items.RemoveAt(0);
				
			}
		}
		void BtnSelectFolderClick(object sender, EventArgs e)
		{
			
			FolderBrowserDialog folder=new FolderBrowserDialog();
			if(folder.ShowDialog()== DialogResult.OK)
			{
				string gameName = folder.SelectedPath.ToUpper();
				if(gameName.Contains("GTA"))
				{
					txtFileWay.Text=folder.SelectedPath;
					string path = txtFileWay.Text+@"\data\maps"+@"\int";
					if(!Directory.Exists(path))
					Directory.CreateDirectory(path);
					path = txtFileWay.Text+@"\data\maps"+@"\int" +@"\int.ipl";
					
					if(!File.Exists(path))
					{
						FileStream fs = File.Create(path);
						fs.Close();
						StreamWriter writer = new StreamWriter(path);
						writer.WriteLine("enex\nend");
						writer.Close();
					}
					if(File.Exists(txtFileWay.Text+@"\data\maps\int\int.ipl.txt"))
					{
						Path.ChangeExtension(txtFileWay.Text+@"\data\maps\int\int.ipl.txt",".ipl");
						File.Move(txtFileWay.Text+@"\data\maps\int\int.ipl.ipl", txtFileWay.Text+@"\data\maps\int\int.ipl");
					}
					
					Listele();
					string texts;
					
					using(StreamReader reader=new StreamReader(txtFileWay.Text+@"\data\gta.dat"))
					{
						texts = reader.ReadToEnd();
						reader.Close();
					}
					if(!File.Exists(txtFileWay.Text+@"\data\maps\int\int.ipl") || !Directory.Exists(txtFileWay.Text+@"\data\maps\int") || !texts.Contains(@"IPL DATA\MAPS\int\int.IPL"))
					{
						MessageBox.Show("Marker Dosyası Yoktur. \nLütfen Marker Ekleyiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
					isOk = true;
				}
				else
				{
					MessageBox.Show("GTA Yolu İçermiyor","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}
		
		void BtnWriteFileClick(object sender, EventArgs e)
		{
			try
			{
				double mx=Convert.ToDouble(txtMarkerX.Text);
				double my=Convert.ToDouble(txtMarkerY.Text);
				double mz=Convert.ToDouble(txtMarkerZ.Text);
				
				double px=Convert.ToDouble(txtMarkerX.Text);
				double py=Convert.ToDouble(txtMarkerY.Text);
				double pz=Convert.ToDouble(txtMarkerZ.Text);
				
				double oa1=Convert.ToDouble(txtPlayerAngle1.Text);
				double oa2=Convert.ToDouble(txtPlayerAngle2.Text);

			}
			catch
			{
				MessageBox.Show("Lütfen Hataları Düzeltiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(isOk && !(txtMarkerName1.Text==txtMarkerName2.Text) && !(txtMarkerX.Text.Contains(",") || txtMarkerY.Text.Contains(",") || txtMarkerZ.Text.Contains(",") || txtPlayerX.Text.Contains(",") || txtPlayerY.Text.Contains(",") || txtPlayerZ.Text.Contains(",") || txtPlayerAngle1.Text.Contains(",") || txtPlayerAngle2.Text.Contains(",")))
			{
				string way = txtFileWay.Text+@"\data\maps";
				if(way.EndsWith(@"\maps"))
				{
					way = way.Remove(way.Length - string.Format(@"\maps").Length);
					way += @"\gta.dat";
				}
				if(File.Exists(way))
				{
					string arananMetin = @"IPL DATA\MAPS\interior\savehous.IPL";
        			string eklenenMetin = @"IPL DATA\MAPS\int\int.IPL";
					string[] satirlar = File.ReadAllLines(way);
					StreamReader sr = new StreamReader(way);
					string t=sr.ReadToEnd();
					sr.Close();
					if(!t.Contains(eklenenMetin))
					{
						using (StreamWriter writer = new StreamWriter(way + ".tmp")) 
					    {
					        foreach (string satir in satirlar)
					        {
					            writer.WriteLine(satir); 
					
					            if (satir.Contains(arananMetin)) 
					            {
					                writer.WriteLine(eklenenMetin); 
					            }
					        }
					    }
					    File.Delete(way);
					    File.Move(way + ".tmp", way);
					}
				}
			    else
			    {
			    	MessageBox.Show("gta.dat Dosyası Bulunamamaktadır.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			    }
			    
				string path = txtFileWay.Text+@"\data\maps"+@"\int";
				if(!Directory.Exists(path))
				Directory.CreateDirectory(path);
				path = txtFileWay.Text+@"\data\maps"+@"\int" +@"\int.ipl";
				
				if(!File.Exists(path))
				{
					FileStream fs = File.Create(path);
					fs.Close();
				}
				if(File.Exists(txtFileWay.Text+@"\data\maps\int\int.ipl.txt"))
				{
					Path.ChangeExtension(txtFileWay.Text+@"\data\maps\int\int.ipl.txt",".ipl");
					File.Move(txtFileWay.Text+@"\data\maps\int\int.ipl.ipl", txtFileWay.Text+@"\data\maps\int\int.ipl");
				}
				StreamReader reader = new StreamReader(path);
				string texts=reader.ReadToEnd();
				reader.Close();
				if(texts.Contains("enex"))
				{
					if(texts.Contains("end"))
					{
						string trimWord="end";
						if (texts.EndsWith(trimWord))
    						texts = texts.Remove(texts.Length - trimWord.Length);
						if (texts.StartsWith("enex"))
							texts = texts.Remove(0, string.Format("enex").Length);
						FileStream fs = File.Create(path);
						fs.Close();
						StreamWriter writer=new StreamWriter(path);
						writer.Write("enex");
						writer.Write("\n"+texts);
						writer.Write(txtMarkerX.Text+", "+txtMarkerY.Text+", "+txtMarkerZ.Text+", 0, 0.8, 0.696777, 8, "+txtPlayerX.Text+", "+txtPlayerY.Text+", "+txtPlayerZ.Text+", 0, "+txtToInterior.Value+", "+txtFromInterior.Value+", '"+txtMarkerName1.Text+"' , 0, 0, 0, "+txtPlayerAngle1.Text);
						writer.Write("\n"+txtPlayerX.Text+", "+txtPlayerY.Text+", "+txtPlayerZ.Text+", 0, 0.8, 0.696777, 8, "+txtMarkerX.Text+", "+txtMarkerY.Text+", "+txtMarkerZ.Text+", 0, "+txtFromInterior.Value+", "+txtToInterior.Value+", '"+txtMarkerName2.Text+"' , 0, 0, 0, "+txtPlayerAngle2.Text);
						writer.Write("\n"+trimWord);
						writer.Close();
						
					}
					else
					{
						string trimWord="end";
						if (texts.StartsWith("enex"))
							texts = texts.Remove(0, string.Format("enex").Length);
						FileStream fs = File.Create(path);
						fs.Close();
						StreamWriter writer=new StreamWriter(path);
						writer.Write("enex");
						writer.Write("\n"+texts);
						writer.Write(txtMarkerX.Text+", "+txtMarkerY.Text+", "+txtMarkerZ.Text+", 0, 0.8, 0.696777, 8, "+txtPlayerX.Text+", "+txtPlayerY.Text+", "+txtPlayerZ.Text+", 0, "+txtToInterior.Value+", "+txtFromInterior.Value+", '"+txtMarkerName1.Text+"' , 0, 0, 0, "+txtPlayerAngle1.Text);
						writer.Write("\n"+txtPlayerX.Text+", "+txtPlayerY.Text+", "+txtPlayerZ.Text+", 0, 0.8, 0.696777, 8, "+txtMarkerX.Text+", "+txtMarkerY.Text+", "+txtMarkerZ.Text+", 0, "+txtFromInterior.Value+", "+txtToInterior.Value+", '"+txtMarkerName2.Text+"' , 0, 0, 0, "+txtPlayerAngle2.Text);
						writer.Write("\n"+trimWord);
						writer.Close();
					}
				}
				else
				{
					string trimWord="enex";
					FileStream fs = File.Create(path);
					fs.Close();
					StreamWriter writer=new StreamWriter(path);
					writer.Write(trimWord);
					writer.Write("\n"+texts);
					writer.Write(txtMarkerX.Text+", "+txtMarkerY.Text+", "+txtMarkerZ.Text+", 0, 0.8, 0.696777, 8, "+txtPlayerX.Text+", "+txtPlayerY.Text+", "+txtPlayerZ.Text+", 0, "+txtToInterior.Value+", "+txtFromInterior.Value+", '"+txtMarkerName1.Text+"' , 0, 0, 0, "+txtPlayerAngle1.Text);
					writer.Write("\n"+txtPlayerX.Text+", "+txtPlayerY.Text+", "+txtPlayerZ.Text+", 0, 0.8, 0.696777, 8, "+txtMarkerX.Text+", "+txtMarkerY.Text+", "+txtMarkerZ.Text+", 0, "+txtFromInterior.Value+", "+txtToInterior.Value+", '"+txtMarkerName2.Text+"' , 0, 0, 0, "+txtPlayerAngle2.Text);
					writer.Write("\n"+"end");
					writer.Close();
				}
				string[] lines = File.ReadAllLines(path);    
			    var nonEmptyLines = Array.FindAll(lines, line => !string.IsNullOrEmpty(line));
			    File.WriteAllLines(path, nonEmptyLines);
				MessageBox.Show("Marker İşlemi Başarıyla Tamamlandı.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Listele();
				Reflesh();
				
			}
			else
			{
				MessageBox.Show("Lütfen Hataları Düzeltiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void Reflesh()
		{
			string path = txtFileWay.Text+@"\data\maps\int\int.ipl";
			if(File.Exists(path) && isOk)
			{
				string way = txtFileWay.Text+@"\data\maps";
				if(way.EndsWith(@"\maps"))
				{
					way = way.Remove(way.Length - string.Format(@"\maps").Length);
					way += @"\gta.dat";
				}
				if(File.Exists(way))
				{
					string arananMetin = @"IPL DATA\MAPS\interior\savehous.IPL";
        			string eklenenMetin = @"IPL DATA\MAPS\int\int.IPL";
					string[] satirlar = File.ReadAllLines(way);
					StreamReader sr = new StreamReader(way);
					string t=sr.ReadToEnd();
					sr.Close();
					if(!t.Contains(eklenenMetin))
					{
						using (StreamWriter writer = new StreamWriter(way + ".tmp")) 
					    {
					        foreach (string satir in satirlar)
					        {
					            writer.WriteLine(satir); 
					
					            if (satir.Contains(arananMetin)) 
					            {
					                writer.WriteLine(eklenenMetin); 
					            }
					        }
					    }
					    File.Delete(way);
					    File.Move(way + ".tmp", way);
					}
				}
			    else
			    {
			    	MessageBox.Show("gta.dat Dosyası Bulunamamaktadır.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			    }
				if(lbListe.Items.Count<=0)
				{
					if(File.Exists(path))
					{
						File.Delete(path);
					}
					path = txtFileWay.Text+@"\data\maps\int";
					if(Directory.Exists(path))
					{
						Directory.Delete(path);
					}
					path = txtFileWay.Text+@"\data\gta.dat";
					StreamReader reader=new StreamReader(path);
					string lines=reader.ReadToEnd();
					reader.Close();
					string textToRemove = @"IPL DATA\MAPS\int\int.IPL";
					if(lines.Contains(textToRemove))
					{
						try
					    {
					        string[] ls = File.ReadAllLines(path);
					        List<string> newLines = new List<string>();
					        foreach (string line in ls)
					        {
					            if (!line.Contains(textToRemove))
					            {
					                newLines.Add(line);
					            }
					        }
					        File.WriteAllLines(path, newLines.ToArray());
					        MessageBox.Show("Marker Yenilendi.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
					    }
					    catch
					    {
					       MessageBox.Show("Bir Hata Oluştu Lütfen Tekrardan Deneyiniz. ","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
					    }
					}
				}
				else
				{
					FileStream fs = File.Create(path);
					fs.Close();
					using(StreamWriter writer=new StreamWriter(path))
					{
						writer.WriteLine("enex");
						foreach(var item in lbListe.Items)
						{
							writer.WriteLine(item);
						}
						writer.Write("end");
						writer.Close();
						MessageBox.Show("Marker Yenilendi.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
				}
				
			}
			else
			{
				if(lbListe.Items.Count<=0)
				{
					if(File.Exists(path))
					{
						File.Delete(path);
					}
					path = txtFileWay.Text+@"\data\maps\int";
					if(Directory.Exists(path))
					{
						Directory.Delete(path);
					}
					path = txtFileWay.Text+@"\data\gta.dat";
					StreamReader reader=new StreamReader(path);
					string lines=reader.ReadToEnd();
					reader.Close();
					string textToRemove = @"IPL DATA\MAPS\int\int.IPL";
					if(lines.Contains(textToRemove))
					{
						try
					    {
					        string[] ls = File.ReadAllLines(path);
					        List<string> newLines = new List<string>();
					        foreach (string line in ls)
					        {
					            if (!line.Contains(textToRemove))
					            {
					                newLines.Add(line);
					            }
					        }
					        File.WriteAllLines(path, newLines.ToArray());

					        MessageBox.Show("Marker Yenilendi.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
					    }
					    catch
					    {
					       MessageBox.Show("Bir Hata Oluştu Lütfen Tekrardan Deneyiniz. ","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
					    }
					}
				}
				else
				MessageBox.Show("Lütfen Hataları Düzeltiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void BtnRefleshClick(object sender, EventArgs e)
		{
			try{Reflesh();}
			catch{MessageBox.Show("GTA San Andreas Dosyasını Seçmediniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);}
		}
		void LbListeMouseDoubleClick(object sender, MouseEventArgs e)
		{
			lbListe.Items.RemoveAt(lbListe.SelectedIndex);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			lbListe.Items.Clear();
		}
		void Button2Click(object sender, EventArgs e)
		{
			try
			{
				float[] pos = GTASAPlayerPositionReader.GetPlayerPosition();
				txtMarkerX.Text = pos[0].ToString().Replace(",",".");
				txtMarkerY.Text = pos[1].ToString().Replace(",",".");
				txtMarkerZ.Text = (pos[2]-2).ToString().Replace(",",".");
			}
			catch
			{
				MessageBox.Show("GTA San Andreas Açık Değil","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			try
			{
				float[] pos = GTASAPlayerPositionReader.GetPlayerPosition();
				txtPlayerX.Text = pos[0].ToString().Replace(",",".");
				txtPlayerY.Text = pos[1].ToString().Replace(",",".");
				txtPlayerZ.Text = (pos[2]-2).ToString().Replace(",",".");
			}
			catch
			{
				MessageBox.Show("GTA San Andreas Açık Değil","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			try
			{
				string processName = "gta_sa";
		        Process[] processes = Process.GetProcessesByName(processName);
		        
		        if (processes.Length > 0)
		        {
		            try
		            {
		                string path = processes[0].MainModule.FileName;
		                txtFileWay.Text = path.Replace(@"\gta_sa.exe","");
		                path = txtFileWay.Text+@"\data\maps\int";
						if(!Directory.Exists(path))
						Directory.CreateDirectory(path);
						path = txtFileWay.Text+@"\data\maps"+@"\int" +@"\int.ipl";
						
						if(!File.Exists(path))
						{
							FileStream fs = File.Create(path);
							fs.Close();
							StreamWriter writer = new StreamWriter(path);
							writer.WriteLine("enex\nend");
						
							writer.Close();
						}
						if(File.Exists(txtFileWay.Text+@"\data\maps\int\int.ipl.txt"))
						{
							Path.ChangeExtension(txtFileWay.Text+@"\data\maps\int\int.ipl.txt",".ipl");
							File.Move(txtFileWay.Text+@"\data\maps\int\int.ipl.ipl", txtFileWay.Text+@"\data\maps\int\int.ipl");
						}
						
						Listele();
						string texts;
						
						using(StreamReader reader=new StreamReader(txtFileWay.Text+@"\data\gta.dat"))
						{
							texts = reader.ReadToEnd();
							reader.Close();
						}
						if(!File.Exists(txtFileWay.Text+@"\data\maps\int\int.ipl") || !Directory.Exists(txtFileWay.Text+@"\data\maps\int") || !texts.Contains(@"IPL DATA\MAPS\int\int.IPL"))
						{
							MessageBox.Show("Marker Dosyası Yoktur. \nLütfen Marker Ekleyiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}
						isOk = true;
		            }
		            catch
		            {
		                MessageBox.Show("GTA San Andreas Açık Değil","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
		            }
		        }
		        else
		        {
		            MessageBox.Show("GTA San Andreas Açık Değil","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
		        }
			}
			catch
			{
				
			}
		}
	}
}
