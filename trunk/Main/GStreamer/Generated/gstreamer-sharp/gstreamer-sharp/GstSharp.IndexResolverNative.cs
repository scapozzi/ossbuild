// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool IndexResolverNative(IntPtr index, IntPtr writer, out IntPtr writer_string, IntPtr user_data);

	internal class IndexResolverInvoker {

		IndexResolverNative native_cb;
		IntPtr __data;
		Gst.GLib.DestroyNotify __notify;

		~IndexResolverInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal IndexResolverInvoker (IndexResolverNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal IndexResolverInvoker (IndexResolverNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal IndexResolverInvoker (IndexResolverNative native_cb, IntPtr data, Gst.GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.IndexResolver Handler {
			get {
				return new Gst.IndexResolver(InvokeNative);
			}
		}

		bool InvokeNative (Gst.Index index, Gst.Object writer, out string writer_string)
		{
			IntPtr native_writer_string;
			bool result = native_cb (index == null ? IntPtr.Zero : index.Handle, writer == null ? IntPtr.Zero : writer.Handle, out native_writer_string, __data);
			writer_string = Gst.GLib.Marshaller.PtrToStringGFree(native_writer_string);
			return result;
		}
	}

	internal class IndexResolverWrapper {

		public bool NativeCallback (IntPtr index, IntPtr writer, out IntPtr writer_string, IntPtr user_data)
		{
			try {
				string mywriter_string;

				bool __ret = managed (Gst.GLib.Object.GetObject(index) as Gst.Index, Gst.GLib.Object.GetObject(writer) as Gst.Object, out mywriter_string);
				writer_string = Gst.GLib.Marshaller.StringToPtrGStrdup(mywriter_string);

				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal IndexResolverNative NativeDelegate;
		Gst.IndexResolver managed;

		public IndexResolverWrapper (Gst.IndexResolver managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new IndexResolverNative (NativeCallback);
		}

		public static Gst.IndexResolver GetManagedDelegate (IndexResolverNative native)
		{
			if (native == null)
				return null;
			IndexResolverWrapper wrapper = (IndexResolverWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}