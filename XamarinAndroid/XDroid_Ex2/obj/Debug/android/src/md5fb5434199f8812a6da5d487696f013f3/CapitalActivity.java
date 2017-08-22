package md5fb5434199f8812a6da5d487696f013f3;


public class CapitalActivity
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
		mono.android.Runtime.register ("XDroid_Ex2.CapitalActivity, XDroid_Ex2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CapitalActivity.class, __md_methods);
	}


	public CapitalActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CapitalActivity.class)
			mono.android.TypeManager.Activate ("XDroid_Ex2.CapitalActivity, XDroid_Ex2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
