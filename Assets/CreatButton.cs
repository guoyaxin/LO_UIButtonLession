using UnityEngine;
using System.Collections;

public class CreatButton : MonoBehaviour
{

	public GameObject root;
	public UIAtlas useAtlas;
	void Start ()
	{
		LO_CreateBtn ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	/**
	 * 创建按钮 
	 */
	void LO_CreateBtn ()
	{
		//创建一个空对象
		GameObject go = NGUITools.AddChild (root);
		//增加Sprite脚本组件
		UISprite sp = go.AddComponent<UISprite> ();
		//设置图集
		sp.atlas = useAtlas;
		//设置图片名称
		sp.spriteName = "fail@2x";
		//设置尺寸
		sp.width = 128;
		sp.height = 56;
		//增加collider
		BoxCollider box = go.AddComponent<BoxCollider> ();
		sp.ResizeCollider ();

		//增加button脚本组件 
		UIButton btn = go.AddComponent<UIButton> ();
		//增加button的点击方法
		EventDelegate.Add (btn.onClick, BtnClick);

	}

	/**
	 * 按钮点击执行的方法 
	 */
	void BtnClick ()
	{
		print ("btn click.......");
	}
}
