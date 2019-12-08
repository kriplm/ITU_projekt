package md556c390a733df854af1b9036cc4485de7;


public class ComboBoxRendererDroid
	extends md58432a647068b097f9637064b8985a5e0.PickerRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ITU_mb.Droid.Renderers.ComboBoxRendererDroid, ITU_mb.Android", ComboBoxRendererDroid.class, __md_methods);
	}


	public ComboBoxRendererDroid (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ComboBoxRendererDroid.class)
			mono.android.TypeManager.Activate ("ITU_mb.Droid.Renderers.ComboBoxRendererDroid, ITU_mb.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ComboBoxRendererDroid (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ComboBoxRendererDroid.class)
			mono.android.TypeManager.Activate ("ITU_mb.Droid.Renderers.ComboBoxRendererDroid, ITU_mb.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ComboBoxRendererDroid (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ComboBoxRendererDroid.class)
			mono.android.TypeManager.Activate ("ITU_mb.Droid.Renderers.ComboBoxRendererDroid, ITU_mb.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
