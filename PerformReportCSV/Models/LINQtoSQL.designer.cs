﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerformReportCSV.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JPStarter")]
	public partial class LINQtoSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKWPerformanceReport(KWPerformanceReport instance);
    partial void UpdateKWPerformanceReport(KWPerformanceReport instance);
    partial void DeleteKWPerformanceReport(KWPerformanceReport instance);
    partial void InsertKWPerformanceReportproduction(KWPerformanceReportproduction instance);
    partial void UpdateKWPerformanceReportproduction(KWPerformanceReportproduction instance);
    partial void DeleteKWPerformanceReportproduction(KWPerformanceReportproduction instance);
    #endregion
		
		public LINQtoSQLDataContext() : 
				base(global::PerformReportCSV.Properties.Settings.Default.JPStarterConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KWPerformanceReport> KWPerformanceReports
		{
			get
			{
				return this.GetTable<KWPerformanceReport>();
			}
		}
		
		public System.Data.Linq.Table<KWPerformanceReportproduction> KWPerformanceReportproductions
		{
			get
			{
				return this.GetTable<KWPerformanceReportproduction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KWPerformanceReports")]
	public partial class KWPerformanceReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _channel;
		
		private string _day;
		
		private string _campaignid;
		
		private string _campaign;
		
		private string _campaignState;
		
		private string _adgroupid;
		
		private string _adGroup;
		
		private string _adGroupState;
		
		private string _keywordid;
		
		private string _keyword;
		
		private string _matchType;
		
		private string _firstpagecpc;
		
		private string _qualityscore;
		
		private string _maxcpc;
		
		private string _impressions;
		
		private string _searchimpressionshare;
		
		private string _clicks;
		
		private string _avgcpc;
		
		private string _cost;
		
		private string _avgposition;
		
		private string _finalurls;
		
		private string _importedat;
		
		private string _filename;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnchannelChanging(string value);
    partial void OnchannelChanged();
    partial void OndayChanging(string value);
    partial void OndayChanged();
    partial void OncampaignidChanging(string value);
    partial void OncampaignidChanged();
    partial void OncampaignChanging(string value);
    partial void OncampaignChanged();
    partial void OncampaignStateChanging(string value);
    partial void OncampaignStateChanged();
    partial void OnadgroupidChanging(string value);
    partial void OnadgroupidChanged();
    partial void OnadGroupChanging(string value);
    partial void OnadGroupChanged();
    partial void OnadGroupStateChanging(string value);
    partial void OnadGroupStateChanged();
    partial void OnkeywordidChanging(string value);
    partial void OnkeywordidChanged();
    partial void OnkeywordChanging(string value);
    partial void OnkeywordChanged();
    partial void OnmatchTypeChanging(string value);
    partial void OnmatchTypeChanged();
    partial void OnfirstpagecpcChanging(string value);
    partial void OnfirstpagecpcChanged();
    partial void OnqualityscoreChanging(string value);
    partial void OnqualityscoreChanged();
    partial void OnmaxcpcChanging(string value);
    partial void OnmaxcpcChanged();
    partial void OnimpressionsChanging(string value);
    partial void OnimpressionsChanged();
    partial void OnsearchimpressionshareChanging(string value);
    partial void OnsearchimpressionshareChanged();
    partial void OnclicksChanging(string value);
    partial void OnclicksChanged();
    partial void OnavgcpcChanging(string value);
    partial void OnavgcpcChanged();
    partial void OncostChanging(string value);
    partial void OncostChanged();
    partial void OnavgpositionChanging(string value);
    partial void OnavgpositionChanged();
    partial void OnfinalurlsChanging(string value);
    partial void OnfinalurlsChanged();
    partial void OnimportedatChanging(string value);
    partial void OnimportedatChanged();
    partial void OnfilenameChanging(string value);
    partial void OnfilenameChanged();
    #endregion
		
		public KWPerformanceReport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_channel", DbType="VarChar(50)")]
		public string channel
		{
			get
			{
				return this._channel;
			}
			set
			{
				if ((this._channel != value))
				{
					this.OnchannelChanging(value);
					this.SendPropertyChanging();
					this._channel = value;
					this.SendPropertyChanged("channel");
					this.OnchannelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_day", DbType="VarChar(50)")]
		public string day
		{
			get
			{
				return this._day;
			}
			set
			{
				if ((this._day != value))
				{
					this.OndayChanging(value);
					this.SendPropertyChanging();
					this._day = value;
					this.SendPropertyChanged("day");
					this.OndayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_campaignid", DbType="VarChar(50)")]
		public string campaignid
		{
			get
			{
				return this._campaignid;
			}
			set
			{
				if ((this._campaignid != value))
				{
					this.OncampaignidChanging(value);
					this.SendPropertyChanging();
					this._campaignid = value;
					this.SendPropertyChanged("campaignid");
					this.OncampaignidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_campaign", DbType="VarChar(50)")]
		public string campaign
		{
			get
			{
				return this._campaign;
			}
			set
			{
				if ((this._campaign != value))
				{
					this.OncampaignChanging(value);
					this.SendPropertyChanging();
					this._campaign = value;
					this.SendPropertyChanged("campaign");
					this.OncampaignChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_campaignState", DbType="VarChar(50)")]
		public string campaignState
		{
			get
			{
				return this._campaignState;
			}
			set
			{
				if ((this._campaignState != value))
				{
					this.OncampaignStateChanging(value);
					this.SendPropertyChanging();
					this._campaignState = value;
					this.SendPropertyChanged("campaignState");
					this.OncampaignStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adgroupid", DbType="VarChar(50)")]
		public string adgroupid
		{
			get
			{
				return this._adgroupid;
			}
			set
			{
				if ((this._adgroupid != value))
				{
					this.OnadgroupidChanging(value);
					this.SendPropertyChanging();
					this._adgroupid = value;
					this.SendPropertyChanged("adgroupid");
					this.OnadgroupidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adGroup", DbType="VarChar(50)")]
		public string adGroup
		{
			get
			{
				return this._adGroup;
			}
			set
			{
				if ((this._adGroup != value))
				{
					this.OnadGroupChanging(value);
					this.SendPropertyChanging();
					this._adGroup = value;
					this.SendPropertyChanged("adGroup");
					this.OnadGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adGroupState", DbType="VarChar(50)")]
		public string adGroupState
		{
			get
			{
				return this._adGroupState;
			}
			set
			{
				if ((this._adGroupState != value))
				{
					this.OnadGroupStateChanging(value);
					this.SendPropertyChanging();
					this._adGroupState = value;
					this.SendPropertyChanged("adGroupState");
					this.OnadGroupStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keywordid", DbType="VarChar(50)")]
		public string keywordid
		{
			get
			{
				return this._keywordid;
			}
			set
			{
				if ((this._keywordid != value))
				{
					this.OnkeywordidChanging(value);
					this.SendPropertyChanging();
					this._keywordid = value;
					this.SendPropertyChanged("keywordid");
					this.OnkeywordidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keyword", DbType="VarChar(50)")]
		public string keyword
		{
			get
			{
				return this._keyword;
			}
			set
			{
				if ((this._keyword != value))
				{
					this.OnkeywordChanging(value);
					this.SendPropertyChanging();
					this._keyword = value;
					this.SendPropertyChanged("keyword");
					this.OnkeywordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matchType", DbType="VarChar(50)")]
		public string matchType
		{
			get
			{
				return this._matchType;
			}
			set
			{
				if ((this._matchType != value))
				{
					this.OnmatchTypeChanging(value);
					this.SendPropertyChanging();
					this._matchType = value;
					this.SendPropertyChanged("matchType");
					this.OnmatchTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstpagecpc", DbType="VarChar(50)")]
		public string firstpagecpc
		{
			get
			{
				return this._firstpagecpc;
			}
			set
			{
				if ((this._firstpagecpc != value))
				{
					this.OnfirstpagecpcChanging(value);
					this.SendPropertyChanging();
					this._firstpagecpc = value;
					this.SendPropertyChanged("firstpagecpc");
					this.OnfirstpagecpcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qualityscore", DbType="VarChar(50)")]
		public string qualityscore
		{
			get
			{
				return this._qualityscore;
			}
			set
			{
				if ((this._qualityscore != value))
				{
					this.OnqualityscoreChanging(value);
					this.SendPropertyChanging();
					this._qualityscore = value;
					this.SendPropertyChanged("qualityscore");
					this.OnqualityscoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maxcpc", DbType="VarChar(50)")]
		public string maxcpc
		{
			get
			{
				return this._maxcpc;
			}
			set
			{
				if ((this._maxcpc != value))
				{
					this.OnmaxcpcChanging(value);
					this.SendPropertyChanging();
					this._maxcpc = value;
					this.SendPropertyChanged("maxcpc");
					this.OnmaxcpcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_impressions", DbType="VarChar(50)")]
		public string impressions
		{
			get
			{
				return this._impressions;
			}
			set
			{
				if ((this._impressions != value))
				{
					this.OnimpressionsChanging(value);
					this.SendPropertyChanging();
					this._impressions = value;
					this.SendPropertyChanged("impressions");
					this.OnimpressionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_searchimpressionshare", DbType="VarChar(50)")]
		public string searchimpressionshare
		{
			get
			{
				return this._searchimpressionshare;
			}
			set
			{
				if ((this._searchimpressionshare != value))
				{
					this.OnsearchimpressionshareChanging(value);
					this.SendPropertyChanging();
					this._searchimpressionshare = value;
					this.SendPropertyChanged("searchimpressionshare");
					this.OnsearchimpressionshareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clicks", DbType="VarChar(50)")]
		public string clicks
		{
			get
			{
				return this._clicks;
			}
			set
			{
				if ((this._clicks != value))
				{
					this.OnclicksChanging(value);
					this.SendPropertyChanging();
					this._clicks = value;
					this.SendPropertyChanged("clicks");
					this.OnclicksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_avgcpc", DbType="VarChar(50)")]
		public string avgcpc
		{
			get
			{
				return this._avgcpc;
			}
			set
			{
				if ((this._avgcpc != value))
				{
					this.OnavgcpcChanging(value);
					this.SendPropertyChanging();
					this._avgcpc = value;
					this.SendPropertyChanged("avgcpc");
					this.OnavgcpcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cost", DbType="VarChar(50)")]
		public string cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this.OncostChanging(value);
					this.SendPropertyChanging();
					this._cost = value;
					this.SendPropertyChanged("cost");
					this.OncostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_avgposition", DbType="VarChar(50)")]
		public string avgposition
		{
			get
			{
				return this._avgposition;
			}
			set
			{
				if ((this._avgposition != value))
				{
					this.OnavgpositionChanging(value);
					this.SendPropertyChanging();
					this._avgposition = value;
					this.SendPropertyChanged("avgposition");
					this.OnavgpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_finalurls", DbType="VarChar(8000)")]
		public string finalurls
		{
			get
			{
				return this._finalurls;
			}
			set
			{
				if ((this._finalurls != value))
				{
					this.OnfinalurlsChanging(value);
					this.SendPropertyChanging();
					this._finalurls = value;
					this.SendPropertyChanged("finalurls");
					this.OnfinalurlsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_importedat", DbType="VarChar(50)")]
		public string importedat
		{
			get
			{
				return this._importedat;
			}
			set
			{
				if ((this._importedat != value))
				{
					this.OnimportedatChanging(value);
					this.SendPropertyChanging();
					this._importedat = value;
					this.SendPropertyChanged("importedat");
					this.OnimportedatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_filename", DbType="VarChar(8000)")]
		public string filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				if ((this._filename != value))
				{
					this.OnfilenameChanging(value);
					this.SendPropertyChanging();
					this._filename = value;
					this.SendPropertyChanged("filename");
					this.OnfilenameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="production.KWPerformanceReports")]
	public partial class KWPerformanceReportproduction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Day;
		
		private string _CampaignID;
		
		private string _Campaign;
		
		private string _Campaignstate;
		
		private string _AdgroupID;
		
		private string _Adgroup;
		
		private string _adgroupstate;
		
		private string _KeywordID;
		
		private string _Keyword;
		
		private string _Matchtype;
		
		private string _FirstpageCPC;
		
		private string _Qualityscore;
		
		private string _Maxcpc;
		
		private string _Impressions;
		
		private string _SearchImpressionShare;
		
		private string _Clicks;
		
		private string _AvgCPC;
		
		private string _Cost;
		
		private string _AVGposition;
		
		private string _FinalURL;
		
		private string _importedat;
		
		private string _filename;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnDayChanging(string value);
    partial void OnDayChanged();
    partial void OnCampaignIDChanging(string value);
    partial void OnCampaignIDChanged();
    partial void OnCampaignChanging(string value);
    partial void OnCampaignChanged();
    partial void OnCampaignstateChanging(string value);
    partial void OnCampaignstateChanged();
    partial void OnAdgroupIDChanging(string value);
    partial void OnAdgroupIDChanged();
    partial void OnAdgroupChanging(string value);
    partial void OnAdgroupChanged();
    partial void OnadgroupstateChanging(string value);
    partial void OnadgroupstateChanged();
    partial void OnKeywordIDChanging(string value);
    partial void OnKeywordIDChanged();
    partial void OnKeywordChanging(string value);
    partial void OnKeywordChanged();
    partial void OnMatchtypeChanging(string value);
    partial void OnMatchtypeChanged();
    partial void OnFirstpageCPCChanging(string value);
    partial void OnFirstpageCPCChanged();
    partial void OnQualityscoreChanging(string value);
    partial void OnQualityscoreChanged();
    partial void OnMaxcpcChanging(string value);
    partial void OnMaxcpcChanged();
    partial void OnImpressionsChanging(string value);
    partial void OnImpressionsChanged();
    partial void OnSearchImpressionShareChanging(string value);
    partial void OnSearchImpressionShareChanged();
    partial void OnClicksChanging(string value);
    partial void OnClicksChanged();
    partial void OnAvgCPCChanging(string value);
    partial void OnAvgCPCChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    partial void OnAVGpositionChanging(string value);
    partial void OnAVGpositionChanged();
    partial void OnFinalURLChanging(string value);
    partial void OnFinalURLChanged();
    partial void OnimportedatChanging(string value);
    partial void OnimportedatChanged();
    partial void OnfilenameChanging(string value);
    partial void OnfilenameChanged();
    #endregion
		
		public KWPerformanceReportproduction()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Day", DbType="NVarChar(50)")]
		public string Day
		{
			get
			{
				return this._Day;
			}
			set
			{
				if ((this._Day != value))
				{
					this.OnDayChanging(value);
					this.SendPropertyChanging();
					this._Day = value;
					this.SendPropertyChanged("Day");
					this.OnDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CampaignID", DbType="NVarChar(50)")]
		public string CampaignID
		{
			get
			{
				return this._CampaignID;
			}
			set
			{
				if ((this._CampaignID != value))
				{
					this.OnCampaignIDChanging(value);
					this.SendPropertyChanging();
					this._CampaignID = value;
					this.SendPropertyChanged("CampaignID");
					this.OnCampaignIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign", DbType="VarChar(50)")]
		public string Campaign
		{
			get
			{
				return this._Campaign;
			}
			set
			{
				if ((this._Campaign != value))
				{
					this.OnCampaignChanging(value);
					this.SendPropertyChanging();
					this._Campaign = value;
					this.SendPropertyChanged("Campaign");
					this.OnCampaignChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaignstate", DbType="VarChar(50)")]
		public string Campaignstate
		{
			get
			{
				return this._Campaignstate;
			}
			set
			{
				if ((this._Campaignstate != value))
				{
					this.OnCampaignstateChanging(value);
					this.SendPropertyChanging();
					this._Campaignstate = value;
					this.SendPropertyChanged("Campaignstate");
					this.OnCampaignstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdgroupID", DbType="NVarChar(50)")]
		public string AdgroupID
		{
			get
			{
				return this._AdgroupID;
			}
			set
			{
				if ((this._AdgroupID != value))
				{
					this.OnAdgroupIDChanging(value);
					this.SendPropertyChanging();
					this._AdgroupID = value;
					this.SendPropertyChanged("AdgroupID");
					this.OnAdgroupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adgroup", DbType="VarChar(50)")]
		public string Adgroup
		{
			get
			{
				return this._Adgroup;
			}
			set
			{
				if ((this._Adgroup != value))
				{
					this.OnAdgroupChanging(value);
					this.SendPropertyChanging();
					this._Adgroup = value;
					this.SendPropertyChanged("Adgroup");
					this.OnAdgroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adgroupstate", DbType="VarChar(50)")]
		public string adgroupstate
		{
			get
			{
				return this._adgroupstate;
			}
			set
			{
				if ((this._adgroupstate != value))
				{
					this.OnadgroupstateChanging(value);
					this.SendPropertyChanging();
					this._adgroupstate = value;
					this.SendPropertyChanged("adgroupstate");
					this.OnadgroupstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeywordID", DbType="NVarChar(50)")]
		public string KeywordID
		{
			get
			{
				return this._KeywordID;
			}
			set
			{
				if ((this._KeywordID != value))
				{
					this.OnKeywordIDChanging(value);
					this.SendPropertyChanging();
					this._KeywordID = value;
					this.SendPropertyChanged("KeywordID");
					this.OnKeywordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Keyword", DbType="VarChar(50)")]
		public string Keyword
		{
			get
			{
				return this._Keyword;
			}
			set
			{
				if ((this._Keyword != value))
				{
					this.OnKeywordChanging(value);
					this.SendPropertyChanging();
					this._Keyword = value;
					this.SendPropertyChanged("Keyword");
					this.OnKeywordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matchtype", DbType="VarChar(50)")]
		public string Matchtype
		{
			get
			{
				return this._Matchtype;
			}
			set
			{
				if ((this._Matchtype != value))
				{
					this.OnMatchtypeChanging(value);
					this.SendPropertyChanging();
					this._Matchtype = value;
					this.SendPropertyChanged("Matchtype");
					this.OnMatchtypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstpageCPC", DbType="VarChar(50)")]
		public string FirstpageCPC
		{
			get
			{
				return this._FirstpageCPC;
			}
			set
			{
				if ((this._FirstpageCPC != value))
				{
					this.OnFirstpageCPCChanging(value);
					this.SendPropertyChanging();
					this._FirstpageCPC = value;
					this.SendPropertyChanged("FirstpageCPC");
					this.OnFirstpageCPCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qualityscore", DbType="VarChar(50)")]
		public string Qualityscore
		{
			get
			{
				return this._Qualityscore;
			}
			set
			{
				if ((this._Qualityscore != value))
				{
					this.OnQualityscoreChanging(value);
					this.SendPropertyChanging();
					this._Qualityscore = value;
					this.SendPropertyChanged("Qualityscore");
					this.OnQualityscoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maxcpc", DbType="NVarChar(50)")]
		public string Maxcpc
		{
			get
			{
				return this._Maxcpc;
			}
			set
			{
				if ((this._Maxcpc != value))
				{
					this.OnMaxcpcChanging(value);
					this.SendPropertyChanging();
					this._Maxcpc = value;
					this.SendPropertyChanged("Maxcpc");
					this.OnMaxcpcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Impressions", DbType="NVarChar(50)")]
		public string Impressions
		{
			get
			{
				return this._Impressions;
			}
			set
			{
				if ((this._Impressions != value))
				{
					this.OnImpressionsChanging(value);
					this.SendPropertyChanging();
					this._Impressions = value;
					this.SendPropertyChanged("Impressions");
					this.OnImpressionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SearchImpressionShare", DbType="VarChar(50)")]
		public string SearchImpressionShare
		{
			get
			{
				return this._SearchImpressionShare;
			}
			set
			{
				if ((this._SearchImpressionShare != value))
				{
					this.OnSearchImpressionShareChanging(value);
					this.SendPropertyChanging();
					this._SearchImpressionShare = value;
					this.SendPropertyChanged("SearchImpressionShare");
					this.OnSearchImpressionShareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clicks", DbType="NVarChar(50)")]
		public string Clicks
		{
			get
			{
				return this._Clicks;
			}
			set
			{
				if ((this._Clicks != value))
				{
					this.OnClicksChanging(value);
					this.SendPropertyChanging();
					this._Clicks = value;
					this.SendPropertyChanged("Clicks");
					this.OnClicksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvgCPC", DbType="NVarChar(50)")]
		public string AvgCPC
		{
			get
			{
				return this._AvgCPC;
			}
			set
			{
				if ((this._AvgCPC != value))
				{
					this.OnAvgCPCChanging(value);
					this.SendPropertyChanging();
					this._AvgCPC = value;
					this.SendPropertyChanged("AvgCPC");
					this.OnAvgCPCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="NVarChar(50)")]
		public string Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AVGposition", DbType="NVarChar(50)")]
		public string AVGposition
		{
			get
			{
				return this._AVGposition;
			}
			set
			{
				if ((this._AVGposition != value))
				{
					this.OnAVGpositionChanging(value);
					this.SendPropertyChanging();
					this._AVGposition = value;
					this.SendPropertyChanged("AVGposition");
					this.OnAVGpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FinalURL", DbType="VarChar(8000)")]
		public string FinalURL
		{
			get
			{
				return this._FinalURL;
			}
			set
			{
				if ((this._FinalURL != value))
				{
					this.OnFinalURLChanging(value);
					this.SendPropertyChanging();
					this._FinalURL = value;
					this.SendPropertyChanged("FinalURL");
					this.OnFinalURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_importedat", DbType="VarChar(50)")]
		public string importedat
		{
			get
			{
				return this._importedat;
			}
			set
			{
				if ((this._importedat != value))
				{
					this.OnimportedatChanging(value);
					this.SendPropertyChanging();
					this._importedat = value;
					this.SendPropertyChanged("importedat");
					this.OnimportedatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_filename", DbType="VarChar(8000)")]
		public string filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				if ((this._filename != value))
				{
					this.OnfilenameChanging(value);
					this.SendPropertyChanging();
					this._filename = value;
					this.SendPropertyChanged("filename");
					this.OnfilenameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
