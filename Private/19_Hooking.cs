using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Private
{
    internal class _19_Hooking
    {
        static void Main(string[] args)
        {
            Hook hook = new Hook();
            hook.SetHook();

            while(true)
            {
                while (Console.KeyAvailable == false)
                {

                }

                var key = Console.ReadKey();

                if (key.ToString() == "A")
                {
                    break;
                }
            }
        }

        public class Hook
        {
            // ... { GLOBAL HOOK }

            [DllImport("user32.dll")]
            static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

            [DllImport("user32.dll")]
            static extern bool UnhookWindowsHookEx(IntPtr hInstance);

            [DllImport("user32.dll")]
            static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

            [DllImport("kernel32.dll")]
            static extern IntPtr LoadLibrary(string lpFileName);

            private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

            const int WH_KEYBOARD_LL = 13;
            const int WM_KEYDOWN = 0x100;

            private LowLevelKeyboardProc _proc = hookProc;
            private static IntPtr hhook = IntPtr.Zero;
            
            public void SetHook()
            {
                IntPtr hInstance = LoadLibrary("User32");
                hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
            }

            public static void UnHook()
            {
                UnhookWindowsHookEx(hhook);
            }

            public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
            {
                if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);

                    if (vkCode.ToString() == "162")
                    {
                        Console.WriteLine("You press CTRL key");
                    }
                    return CallNextHookEx(hhook, code, (int)wParam, lParam);
                }
                else
                {
                    return CallNextHookEx(hhook, code, (int)wParam, lParam);
                }
            }
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging; 
using System.Runtime.InteropServices;  

namespace Private
{
public class Hook
{
    // ... { GLOBAL HOOK }

    [DllImport("user32.dll")]        
    static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);         

    [DllImport("user32.dll")]        
    static extern bool UnhookWindowsHookEx(IntPtr hInstance);         

    [DllImport("user32.dll")]        
    static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);         

    [DllImport("kernel32.dll")]        
    static extern IntPtr LoadLibrary(string lpFileName);         

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);         

    const int WH_KEYBOARD_LL = 13; 
    const int WM_KEYDOWN = 0x100; 

    private LowLevelKeyboardProc _proc = hookProc;         
    private static IntPtr hhook = IntPtr.Zero;         
    public void SetHook()        
    {            
        IntPtr hInstance = LoadLibrary("User32");            
        hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);        
    }         

    public static void UnHook()        
    {            
        UnhookWindowsHookEx(hhook);        
    }

    public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
    {
        if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);

            if (vkCode.ToString() == "162")
            {
                Console.WriteLine("You press CTRL key");
            }
            return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
        else
        {
            return CallNextHookEx(hhook, code, (int)wParam, lParam);
        } 
    }         
} 
}
*/
// 참고 사이트
// https://sosal.kr/734

// 내일 참고해보기
// https://derveljunit.tistory.com/290

// 역시 참고해보기
// https://m.blog.naver.com/oihijkoh/221513339733

// https://www.google.com/search?q=%ED%9B%84%ED%82%B9+%EC%9D%98%EB%AF%B8&rlz=1C1IBEF_koKR1014KR1014&oq=%ED%9B%84%ED%82%B9+%EC%9D%98%EB%AF%B8&aqs=chrome..69i57j0i131i433i512l2j0i3l3j46i433i512j46i199i465i512j0i131i433i512j0i512.1112j0j15&sourceid=chrome&ie=UTF-8
// 후킹(영어: hooking)은
// 소프트웨어 공학 용어로, 운영 체제나 응용 소프트웨어 등의 각종 컴퓨터 프로그램에서
// 소프트웨어 구성 요소 간에 발생하는 함수 호출, 메시지, 이벤트 등을
// 중간에서 바꾸거나 가로채는 명령, 방법, 기술이나 행위를 말한다