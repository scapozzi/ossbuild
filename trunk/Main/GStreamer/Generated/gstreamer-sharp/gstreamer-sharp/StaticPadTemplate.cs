// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class StaticPadTemplate : Gst.GLib.Opaque {

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gstsharp_gst_staticpadtemplate_get_direction_offset ();

		static uint direction_offset = gstsharp_gst_staticpadtemplate_get_direction_offset ();
		public Gst.PadDirection Direction {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + direction_offset);
					return (Gst.PadDirection) (*raw_ptr);
				}
			}
		}

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gstsharp_gst_staticpadtemplate_get_name_template_offset ();

		static uint name_template_offset = gstsharp_gst_staticpadtemplate_get_name_template_offset ();
		public string NameTemplate {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + name_template_offset);
					return Gst.GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
		}

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gstsharp_gst_staticpadtemplate_get_presence_offset ();

		static uint presence_offset = gstsharp_gst_staticpadtemplate_get_presence_offset ();
		public Gst.PadPresence Presence {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + presence_offset);
					return (Gst.PadPresence) (*raw_ptr);
				}
			}
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_static_pad_template_get_type();

		public static Gst.GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_static_pad_template_get_type();
				Gst.GLib.GType ret = new Gst.GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_static_pad_template_get(IntPtr raw);

		public Gst.PadTemplate PadTemplate { 
			get {
				IntPtr raw_ret = gst_static_pad_template_get(Handle);
				Gst.PadTemplate ret = Gst.GLib.Object.GetObject(raw_ret, true) as Gst.PadTemplate;
				return ret;
			}
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_static_pad_template_get_caps(IntPtr raw);

		public Gst.Caps Caps { 
			get {
				IntPtr raw_ret = gst_static_pad_template_get_caps(Handle);
				Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
				return ret;
			}
		}

		public StaticPadTemplate(IntPtr raw) : base(raw) {}

#endregion
	}
}