namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PostTokenResponse (HTWu1SLT4EenLTf6vJZiqw)
///  <code>ST_d5188f28891fd075d6bc1034899cfadeStructure</code> that represent
/// s <code>PostTokenResponse</code> <p>Description: </p>
/// </summary>
// Name: PostTokenResponse
public partial struct ST_d5188f28891fd075d6bc1034899cfadeStructure : ITypedRecord<ST_d5188f28891fd075d6bc1034899cfadeStructure> {
internal static readonly GlobalObjectKey IdToken_type = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*PKatSAaNbUSanE1VfriRdA");
internal static readonly GlobalObjectKey IdExpires_in = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*cUDNXeKSpU6zjdPyw5_RoA");
internal static readonly GlobalObjectKey IdExt_expires_in = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*FvxwBBE8uUqamnPFWIh3VQ");
internal static readonly GlobalObjectKey IdAccess_token = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*2H4uB7ACF0mD12QJid7wcg");

public string ssToken_type;

public long ssExpires_in;

public long ssExt_expires_in;

public string ssAccess_token;


public BitArray OptimizedAttributes;

public ST_d5188f28891fd075d6bc1034899cfadeStructure() {
OptimizedAttributes = null;
ssToken_type = "";
ssExpires_in = 0L;
ssExt_expires_in = 0L;
ssAccess_token = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssToken_type = r.ReadText(index++, "PostTokenResponse.Token_type", "");
ssExpires_in = r.ReadLongInteger(index++, "PostTokenResponse.Expires_in", 0L);
ssExt_expires_in = r.ReadLongInteger(index++, "PostTokenResponse.Ext_expires_in", 0L);
ssAccess_token = r.ReadText(index++, "PostTokenResponse.Access_token", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_d5188f28891fd075d6bc1034899cfadeStructure r) {
this = r;
}


public static bool operator == (ST_d5188f28891fd075d6bc1034899cfadeStructure a, ST_d5188f28891fd075d6bc1034899cfadeStructure b) {
if (a.ssToken_type != b.ssToken_type) return false;
if (a.ssExpires_in != b.ssExpires_in) return false;
if (a.ssExt_expires_in != b.ssExt_expires_in) return false;
if (a.ssAccess_token != b.ssAccess_token) return false;
return true;
}

public static bool operator != (ST_d5188f28891fd075d6bc1034899cfadeStructure a, ST_d5188f28891fd075d6bc1034899cfadeStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d5188f28891fd075d6bc1034899cfadeStructure)) return false;
return (this == (ST_d5188f28891fd075d6bc1034899cfadeStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssToken_type.GetHashCode()
 ^ ssExpires_in.GetHashCode()
 ^ ssExt_expires_in.GetHashCode()
 ^ ssAccess_token.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d5188f28891fd075d6bc1034899cfadeStructure Duplicate() {
ST_d5188f28891fd075d6bc1034899cfadeStructure t;
t.ssToken_type = this.ssToken_type;
t.ssExpires_in = this.ssExpires_in;
t.ssExt_expires_in = this.ssExt_expires_in;
t.ssAccess_token = this.ssAccess_token;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "token_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Token_type")) variable.Value = ssToken_type; else variable.Optimized = true;
} else if (head == "expires_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Expires_in")) variable.Value = ssExpires_in; else variable.Optimized = true;
} else if (head == "ext_expires_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ext_expires_in")) variable.Value = ssExt_expires_in; else variable.Optimized = true;
} else if (head == "access_token") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Access_token")) variable.Value = ssAccess_token; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdToken_type) {
return ssToken_type;
}
if (key == IdExpires_in) {
return ssExpires_in;
}
if (key == IdExt_expires_in) {
return ssExt_expires_in;
}
if (key == IdAccess_token) {
return ssAccess_token;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdToken_type.Key.AsGuid) {
return ssToken_type;
}
if (attributeKey == IdExpires_in.Key.AsGuid) {
return ssExpires_in;
}
if (attributeKey == IdExt_expires_in.Key.AsGuid) {
return ssExt_expires_in;
}
if (attributeKey == IdAccess_token.Key.AsGuid) {
return ssAccess_token;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssToken_type = (string) other.AttributeGet(IdToken_type);
ssExpires_in = (long) other.AttributeGet(IdExpires_in);
ssExt_expires_in = (long) other.AttributeGet(IdExt_expires_in);
ssAccess_token = (string) other.AttributeGet(IdAccess_token);
}
} // ST_d5188f28891fd075d6bc1034899cfadeStructure
/// <summary>
/// RecordList type <code>PostTokenResponseList</code> that represents a record list of
///  <code>PostTokenResponse</code>
/// </summary>
public partial class RL_aa4255e5225fae183b24f24e0dfdedbc : GenericRecordList<ST_d5188f28891fd075d6bc1034899cfadeStructure>, IEnumerable, IEnumerator {

protected override ST_d5188f28891fd075d6bc1034899cfadeStructure GetElementDefaultValue() {
return new ST_d5188f28891fd075d6bc1034899cfadeStructure();
}

public T[] ToArray<T>(Func<ST_d5188f28891fd075d6bc1034899cfadeStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aa4255e5225fae183b24f24e0dfdedbc recordList, Func<ST_d5188f28891fd075d6bc1034899cfadeStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aa4255e5225fae183b24f24e0dfdedbc(ST_d5188f28891fd075d6bc1034899cfadeStructure[] array) {
  RL_aa4255e5225fae183b24f24e0dfdedbc result = new RL_aa4255e5225fae183b24f24e0dfdedbc();
result.InnerFromArray(array);
    return result;
}

public static RL_aa4255e5225fae183b24f24e0dfdedbc ToList<T>(T[] array, Func <T, ST_d5188f28891fd075d6bc1034899cfadeStructure> converter) {
  RL_aa4255e5225fae183b24f24e0dfdedbc result = new RL_aa4255e5225fae183b24f24e0dfdedbc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aa4255e5225fae183b24f24e0dfdedbc FromRestList<T>(RestList<T> restList, Func <T, ST_d5188f28891fd075d6bc1034899cfadeStructure> converter) {
  RL_aa4255e5225fae183b24f24e0dfdedbc result = new RL_aa4255e5225fae183b24f24e0dfdedbc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aa4255e5225fae183b24f24e0dfdedbc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d5188f28891fd075d6bc1034899cfadeStructure> NewList() {
return new RL_aa4255e5225fae183b24f24e0dfdedbc();
}


} // RL_aa4255e5225fae183b24f24e0dfdedbc
}

