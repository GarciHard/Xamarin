package md50301e62f768c6eb1e84ade283aae32dc;


public class RelativeActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("LayoutDroid.RelativeActivity, LayoutDroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RelativeActivity.class, __md_methods);
	}


	public RelativeActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RelativeActivity.class)
			mono.android.TypeManager.Activate ("LayoutDroid.RelativeActivity, LayoutDroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
