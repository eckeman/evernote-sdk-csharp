/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Evernote.EDAM.NoteStore
{

  /// <summary>
  /// A description of the thing for which we are searching for related
  /// entities.
  /// 
  /// You must specify either <em>noteGuid</em> or <em>plainText</em>, but
  /// not both. <em>filter</em> and <em>referenceUri</em> are optional.
  /// 
  /// <dl>
  /// <dt>noteGuid</dt>
  /// <dd>The GUID of an existing note in your account for which related
  ///     entities will be found.</dd>
  /// 
  /// <dt>plainText</dt>
  /// <dd>A string of plain text for which to find related entities.
  ///     You should provide a text block with a number of characters between
  ///     EDAM_RELATED_PLAINTEXT_LEN_MIN and EDAM_RELATED_PLAINTEXT_LEN_MAX.
  ///     </dd>
  /// 
  /// <dt>filter</dt>
  /// <dd>The list of criteria that will constrain the notes being considered
  ///     related.
  ///     Please note that some of the parameters may be ignored, such as
  ///     <em>order</em> and <em>ascending</em>.
  /// </dd>
  /// 
  /// <dt>referenceUri</dt>
  /// <dd>A URI string specifying a reference entity, around which "relatedness"
  ///     should be based. This can be an URL pointing to a web page, for example.
  /// </dd>
  /// 
  /// <dt>context</dt>
  /// <dd>Specifies the context to consider when determining related results.
  ///     Clients must leave this value unset unless they wish to explicitly specify a known
  ///     non-default context.
  /// </dd>
  /// 
  /// <dt>cacheKey</dt>
  /// <dd>If set and non-empty, this is an indicator for the server whether it is actually
  ///     necessary to perform a new findRelated call at all. Cache Keys are opaque strings
  ///     which are returned by the server as part of "RelatedResult" in response
  ///     to a "NoteStore.findRelated" query. Cache Keys are inherently query specific.
  /// 
  ///     If set to an empty string, this indicates that the server should generate a cache
  ///     key in the response as part of "RelatedResult".
  /// 
  ///     If not set, the server will not attempt to generate a cache key at all.
  /// </dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RelatedQuery : TBase
  {
    private string _noteGuid;
    private string _plainText;
    private NoteFilter _filter;
    private string _referenceUri;
    private string _context;
    private string _cacheKey;

    public string NoteGuid
    {
      get
      {
        return _noteGuid;
      }
      set
      {
        __isset.noteGuid = true;
        this._noteGuid = value;
      }
    }

    public string PlainText
    {
      get
      {
        return _plainText;
      }
      set
      {
        __isset.plainText = true;
        this._plainText = value;
      }
    }

    public NoteFilter Filter
    {
      get
      {
        return _filter;
      }
      set
      {
        __isset.filter = true;
        this._filter = value;
      }
    }

    public string ReferenceUri
    {
      get
      {
        return _referenceUri;
      }
      set
      {
        __isset.referenceUri = true;
        this._referenceUri = value;
      }
    }

    public string Context
    {
      get
      {
        return _context;
      }
      set
      {
        __isset.context = true;
        this._context = value;
      }
    }

    public string CacheKey
    {
      get
      {
        return _cacheKey;
      }
      set
      {
        __isset.cacheKey = true;
        this._cacheKey = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool noteGuid;
      public bool plainText;
      public bool filter;
      public bool referenceUri;
      public bool context;
      public bool cacheKey;
    }

    public RelatedQuery() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
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
              if (field.Type == TType.String) {
                NoteGuid = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                PlainText = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Filter = new NoteFilter();
                Filter.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                ReferenceUri = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Context = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                CacheKey = iprot.ReadString();
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
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("RelatedQuery");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (NoteGuid != null && __isset.noteGuid) {
          field.Name = "noteGuid";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NoteGuid);
          oprot.WriteFieldEnd();
        }
        if (PlainText != null && __isset.plainText) {
          field.Name = "plainText";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(PlainText);
          oprot.WriteFieldEnd();
        }
        if (Filter != null && __isset.filter) {
          field.Name = "filter";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Filter.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (ReferenceUri != null && __isset.referenceUri) {
          field.Name = "referenceUri";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ReferenceUri);
          oprot.WriteFieldEnd();
        }
        if (Context != null && __isset.context) {
          field.Name = "context";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Context);
          oprot.WriteFieldEnd();
        }
        if (CacheKey != null && __isset.cacheKey) {
          field.Name = "cacheKey";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CacheKey);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("RelatedQuery(");
      bool __first = true;
      if (NoteGuid != null && __isset.noteGuid) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoteGuid: ");
        __sb.Append(NoteGuid);
      }
      if (PlainText != null && __isset.plainText) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PlainText: ");
        __sb.Append(PlainText);
      }
      if (Filter != null && __isset.filter) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Filter: ");
        __sb.Append(Filter== null ? "<null>" : Filter.ToString());
      }
      if (ReferenceUri != null && __isset.referenceUri) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ReferenceUri: ");
        __sb.Append(ReferenceUri);
      }
      if (Context != null && __isset.context) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Context: ");
        __sb.Append(Context);
      }
      if (CacheKey != null && __isset.cacheKey) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CacheKey: ");
        __sb.Append(CacheKey);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
