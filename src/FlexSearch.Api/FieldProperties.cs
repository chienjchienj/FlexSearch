/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
//using System.ServiceModel;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace FlexSearch.Api
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  [DataContract(Namespace="")]
  public partial class FieldProperties : TBase
  {
    private bool _Analyze;
    private bool _Index;
    private bool _Store;
    private string _IndexAnalyzer;
    private string _SearchAnalyzer;
    private FieldType _FieldType;
    private FieldPostingsFormat _PostingsFormat;
    private FieldIndexOptions _IndexOptions;
    private FieldTermVector _TermVector;
    private bool _OmitNorms;
    private string _ScriptName;

    [DataMember]
    public bool Analyze
    {
      get
      {
        return _Analyze;
      }
      set
      {
        __isset.Analyze = true;
        this._Analyze = value;
      }
    }

    [DataMember]
    public bool Index
    {
      get
      {
        return _Index;
      }
      set
      {
        __isset.Index = true;
        this._Index = value;
      }
    }

    [DataMember]
    public bool Store
    {
      get
      {
        return _Store;
      }
      set
      {
        __isset.Store = true;
        this._Store = value;
      }
    }

    [DataMember]
    public string IndexAnalyzer
    {
      get
      {
        return _IndexAnalyzer;
      }
      set
      {
        __isset.IndexAnalyzer = true;
        this._IndexAnalyzer = value;
      }
    }

    [DataMember]
    public string SearchAnalyzer
    {
      get
      {
        return _SearchAnalyzer;
      }
      set
      {
        __isset.SearchAnalyzer = true;
        this._SearchAnalyzer = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="FieldType"/>
    /// </summary>
    [DataMember]
    public FieldType FieldType
    {
      get
      {
        return _FieldType;
      }
      set
      {
        __isset.FieldType = true;
        this._FieldType = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="FieldPostingsFormat"/>
    /// </summary>
    [DataMember]
    public FieldPostingsFormat PostingsFormat
    {
      get
      {
        return _PostingsFormat;
      }
      set
      {
        __isset.PostingsFormat = true;
        this._PostingsFormat = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="FieldIndexOptions"/>
    /// </summary>
    [DataMember]
    public FieldIndexOptions IndexOptions
    {
      get
      {
        return _IndexOptions;
      }
      set
      {
        __isset.IndexOptions = true;
        this._IndexOptions = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="FieldTermVector"/>
    /// </summary>
    [DataMember]
    public FieldTermVector TermVector
    {
      get
      {
        return _TermVector;
      }
      set
      {
        __isset.TermVector = true;
        this._TermVector = value;
      }
    }

    [DataMember]
    public bool OmitNorms
    {
      get
      {
        return _OmitNorms;
      }
      set
      {
        __isset.OmitNorms = true;
        this._OmitNorms = value;
      }
    }

    [DataMember]
    public string ScriptName
    {
      get
      {
        return _ScriptName;
      }
      set
      {
        __isset.ScriptName = true;
        this._ScriptName = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    [DataContract]
    public struct Isset {
      public bool Analyze;
      public bool Index;
      public bool Store;
      public bool IndexAnalyzer;
      public bool SearchAnalyzer;
      public bool FieldType;
      public bool PostingsFormat;
      public bool IndexOptions;
      public bool TermVector;
      public bool OmitNorms;
      public bool ScriptName;
    }

    public FieldProperties() {
      this._Analyze = true;
      this.__isset.Analyze = true;
      this._Index = true;
      this.__isset.Index = true;
      this._Store = true;
      this.__isset.Store = true;
      this._IndexAnalyzer = "standardanalyzer";
      this.__isset.IndexAnalyzer = true;
      this._SearchAnalyzer = "standardanalyzer";
      this.__isset.SearchAnalyzer = true;
      this._FieldType = FieldType.Text;
      this.__isset.FieldType = true;
      this._PostingsFormat = FieldPostingsFormat.Lucene41PostingsFormat;
      this.__isset.PostingsFormat = true;
      this._IndexOptions = FieldIndexOptions.DocsAndFreqsAndPositions;
      this.__isset.IndexOptions = true;
      this._TermVector = FieldTermVector.StoreTermVectorsWithPositions;
      this.__isset.TermVector = true;
      this._OmitNorms = true;
      this.__isset.OmitNorms = true;
      this._ScriptName = "";
      this.__isset.ScriptName = true;
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Bool) {
              Analyze = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              Index = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              Store = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              IndexAnalyzer = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              SearchAnalyzer = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              FieldType = (FieldType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              PostingsFormat = (FieldPostingsFormat)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              IndexOptions = (FieldIndexOptions)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              TermVector = (FieldTermVector)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Bool) {
              OmitNorms = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              ScriptName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("FieldProperties");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.Analyze) {
        field.Name = "Analyze";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Analyze);
        oprot.WriteFieldEnd();
      }
      if (__isset.Index) {
        field.Name = "Index";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Index);
        oprot.WriteFieldEnd();
      }
      if (__isset.Store) {
        field.Name = "Store";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Store);
        oprot.WriteFieldEnd();
      }
      if (IndexAnalyzer != null && __isset.IndexAnalyzer) {
        field.Name = "IndexAnalyzer";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(IndexAnalyzer);
        oprot.WriteFieldEnd();
      }
      if (SearchAnalyzer != null && __isset.SearchAnalyzer) {
        field.Name = "SearchAnalyzer";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SearchAnalyzer);
        oprot.WriteFieldEnd();
      }
      if (__isset.FieldType) {
        field.Name = "FieldType";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)FieldType);
        oprot.WriteFieldEnd();
      }
      if (__isset.PostingsFormat) {
        field.Name = "PostingsFormat";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)PostingsFormat);
        oprot.WriteFieldEnd();
      }
      if (__isset.IndexOptions) {
        field.Name = "IndexOptions";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)IndexOptions);
        oprot.WriteFieldEnd();
      }
      if (__isset.TermVector) {
        field.Name = "TermVector";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)TermVector);
        oprot.WriteFieldEnd();
      }
      if (__isset.OmitNorms) {
        field.Name = "OmitNorms";
        field.Type = TType.Bool;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(OmitNorms);
        oprot.WriteFieldEnd();
      }
      if (ScriptName != null && __isset.ScriptName) {
        field.Name = "ScriptName";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ScriptName);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override bool Equals(object that) {
      var other = that as FieldProperties;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.Analyze == other.__isset.Analyze) && ((!__isset.Analyze) || (System.Object.Equals(Analyze, other.Analyze))))
        && ((__isset.Index == other.__isset.Index) && ((!__isset.Index) || (System.Object.Equals(Index, other.Index))))
        && ((__isset.Store == other.__isset.Store) && ((!__isset.Store) || (System.Object.Equals(Store, other.Store))))
        && ((__isset.IndexAnalyzer == other.__isset.IndexAnalyzer) && ((!__isset.IndexAnalyzer) || (System.Object.Equals(IndexAnalyzer, other.IndexAnalyzer))))
        && ((__isset.SearchAnalyzer == other.__isset.SearchAnalyzer) && ((!__isset.SearchAnalyzer) || (System.Object.Equals(SearchAnalyzer, other.SearchAnalyzer))))
        && ((__isset.FieldType == other.__isset.FieldType) && ((!__isset.FieldType) || (System.Object.Equals(FieldType, other.FieldType))))
        && ((__isset.PostingsFormat == other.__isset.PostingsFormat) && ((!__isset.PostingsFormat) || (System.Object.Equals(PostingsFormat, other.PostingsFormat))))
        && ((__isset.IndexOptions == other.__isset.IndexOptions) && ((!__isset.IndexOptions) || (System.Object.Equals(IndexOptions, other.IndexOptions))))
        && ((__isset.TermVector == other.__isset.TermVector) && ((!__isset.TermVector) || (System.Object.Equals(TermVector, other.TermVector))))
        && ((__isset.OmitNorms == other.__isset.OmitNorms) && ((!__isset.OmitNorms) || (System.Object.Equals(OmitNorms, other.OmitNorms))))
        && ((__isset.ScriptName == other.__isset.ScriptName) && ((!__isset.ScriptName) || (System.Object.Equals(ScriptName, other.ScriptName))));
    }

    public override int GetHashCode() {
      int hashcode = 0;
      unchecked {
        hashcode = (hashcode * 397) ^ (!__isset.Analyze ? 0 : (Analyze.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.Index ? 0 : (Index.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.Store ? 0 : (Store.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.IndexAnalyzer ? 0 : (IndexAnalyzer.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.SearchAnalyzer ? 0 : (SearchAnalyzer.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.FieldType ? 0 : (FieldType.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.PostingsFormat ? 0 : (PostingsFormat.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.IndexOptions ? 0 : (IndexOptions.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.TermVector ? 0 : (TermVector.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.OmitNorms ? 0 : (OmitNorms.GetHashCode()));
        hashcode = (hashcode * 397) ^ (!__isset.ScriptName ? 0 : (ScriptName.GetHashCode()));
      }
      return hashcode;
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("FieldProperties(");
      sb.Append("Analyze: ");
      sb.Append(Analyze);
      sb.Append(",Index: ");
      sb.Append(Index);
      sb.Append(",Store: ");
      sb.Append(Store);
      sb.Append(",IndexAnalyzer: ");
      sb.Append(IndexAnalyzer);
      sb.Append(",SearchAnalyzer: ");
      sb.Append(SearchAnalyzer);
      sb.Append(",FieldType: ");
      sb.Append(FieldType);
      sb.Append(",PostingsFormat: ");
      sb.Append(PostingsFormat);
      sb.Append(",IndexOptions: ");
      sb.Append(IndexOptions);
      sb.Append(",TermVector: ");
      sb.Append(TermVector);
      sb.Append(",OmitNorms: ");
      sb.Append(OmitNorms);
      sb.Append(",ScriptName: ");
      sb.Append(ScriptName);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
