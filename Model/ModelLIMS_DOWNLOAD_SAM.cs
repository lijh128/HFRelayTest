using System;
namespace RELAYTEST.Model
{
	/// <summary>
	/// ModelLIMS_DOWNLOAD_SAM:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelLIMS_DOWNLOAD_SAM
	{
		public ModelLIMS_DOWNLOAD_SAM()
		{}
		#region Model
		private int _样品号;
		private string _组别;
		private string _任务号;
		private int _检测号;
		private int _排程号;
		private string _分析名称;
		private DateTime? _排程开始时间;
		/// <summary>
		/// 
		/// </summary>
		public int 样品号
		{
			set{ _样品号=value;}
			get{return _样品号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 组别
		{
			set{ _组别=value;}
			get{return _组别;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 任务号
		{
			set{ _任务号=value;}
			get{return _任务号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 检测号
		{
			set{ _检测号=value;}
			get{return _检测号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 排程号
		{
			set{ _排程号=value;}
			get{return _排程号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 分析名称
		{
			set{ _分析名称=value;}
			get{return _分析名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 排程开始时间
		{
			set{ _排程开始时间=value;}
			get{return _排程开始时间;}
		}
		#endregion Model

	}
}

