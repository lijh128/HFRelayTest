using System;
namespace RELAYTEST.Model
{
	/// <summary>
	/// ModelLIMS_DOWNLOAD_SAM:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelLIMS_DOWNLOAD_SAM
	{
		public ModelLIMS_DOWNLOAD_SAM()
		{}
		#region Model
		private int _��Ʒ��;
		private string _���;
		private string _�����;
		private int _����;
		private int _�ų̺�;
		private string _��������;
		private DateTime? _�ų̿�ʼʱ��;
		/// <summary>
		/// 
		/// </summary>
		public int ��Ʒ��
		{
			set{ _��Ʒ��=value;}
			get{return _��Ʒ��;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ���
		{
			set{ _���=value;}
			get{return _���;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �����
		{
			set{ _�����=value;}
			get{return _�����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ����
		{
			set{ _����=value;}
			get{return _����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int �ų̺�
		{
			set{ _�ų̺�=value;}
			get{return _�ų̺�;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ��������
		{
			set{ _��������=value;}
			get{return _��������;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? �ų̿�ʼʱ��
		{
			set{ _�ų̿�ʼʱ��=value;}
			get{return _�ų̿�ʼʱ��;}
		}
		#endregion Model

	}
}

