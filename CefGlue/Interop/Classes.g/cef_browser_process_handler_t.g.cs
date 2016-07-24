﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_browser_process_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _on_context_initialized;
        internal IntPtr _on_before_child_process_launch;
        internal IntPtr _on_render_process_thread_created;
        internal IntPtr _get_print_handler;
        internal IntPtr _on_schedule_message_pump_work;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_browser_process_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_browser_process_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_browser_process_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_context_initialized_delegate(cef_browser_process_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_before_child_process_launch_delegate(cef_browser_process_handler_t* self, cef_command_line_t* command_line);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_render_process_thread_created_delegate(cef_browser_process_handler_t* self, cef_list_value_t* extra_info);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_print_handler_t* get_print_handler_delegate(cef_browser_process_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_schedule_message_pump_work_delegate(cef_browser_process_handler_t* self, long delay_ms);
        
        private static int _sizeof;
        
        static cef_browser_process_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_browser_process_handler_t));
        }
        
        internal static cef_browser_process_handler_t* Alloc()
        {
            var ptr = (cef_browser_process_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_browser_process_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_browser_process_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
