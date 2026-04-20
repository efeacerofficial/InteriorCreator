/*
 * Created by SharpDevelop.
 * User: efeac
 * Date: 30.03.2025
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace InteriorOlusturucu
{
	public class GTASAPlayerPositionReader
	{
	    // GTA San Andreas process adı
	    private const string ProcessName = "gta_sa";
	    
	    // Oyuncu konumu için bellek adresleri (versiyona göre değişebilir)
	    private const int PlayerXOffset = 0xB6F2E0;
	    private const int PlayerYOffset = PlayerXOffset + 4;
	    private const int PlayerZOffset = PlayerYOffset + 4;
	    
	    [DllImport("kernel32.dll")]
	    public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
	
	    [DllImport("kernel32.dll")]
	    public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
	
	    [DllImport("kernel32.dll")]
	    public static extern bool CloseHandle(IntPtr hObject);
	    
	    public static float[] GetPlayerPosition()
	    {
	        Process[] processes = Process.GetProcessesByName(ProcessName);
	        if (processes.Length == 0)
	        {
	            Console.WriteLine("GTA San Andreas processi bulunamadı!");
	            return null;
	        }
	
	        Process gameProcess = processes[0];
	        IntPtr processHandle = OpenProcess(0x0010, false, gameProcess.Id);
	        
	        if (processHandle == IntPtr.Zero)
	        {
	            Console.WriteLine("Process açılamadı!");
	            return null;
	        }
	
	        try
	        {
	            float[] position = new float[4];
	            int bytesRead = 0;
	            byte[] buffer = new byte[4];
	            
	            // X koordinatını oku
	            ReadProcessMemory((int)processHandle, PlayerXOffset + 4, buffer, 4, ref bytesRead);
	            position[0] = BitConverter.ToSingle(buffer, 0);
	            
	            // Y koordinatını oku
	            ReadProcessMemory((int)processHandle, PlayerZOffset, buffer, 4, ref bytesRead);
	            position[1] = BitConverter.ToSingle(buffer, 0);
	            
	            // Z koordinatını oku
	            ReadProcessMemory((int)processHandle, PlayerYOffset + 8, buffer, 4, ref bytesRead);
	            position[2] = BitConverter.ToSingle(buffer, 0);
	            return position;
	        }
	        finally
	        {
	            CloseHandle(processHandle);
	        }
	    }
	}
}
